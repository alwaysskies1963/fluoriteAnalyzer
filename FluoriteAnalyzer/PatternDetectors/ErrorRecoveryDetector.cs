﻿using System.Collections.Generic;
using System.Linq;
using FluoriteAnalyzer.Commons;
using FluoriteAnalyzer.Events;

namespace FluoriteAnalyzer.PatternDetectors
{
    class ErrorRecoveryDetector : AbstractPatternDetector
    {
        private static ErrorRecoveryDetector _instance = null;
        internal static ErrorRecoveryDetector GetInstance()
        {
            return _instance ?? (_instance = new ErrorRecoveryDetector());
        }

        private static readonly int _threshold = 2000;  // find all the create/terminate pairs within one second.

        public override IEnumerable<PatternInstance> DetectAsPatternInstances(ILogProvider logProvider)
        {
            List<RunCommand> runCommands = logProvider.LoggedEvents.OfType<RunCommand>().ToList();

            bool lastRunWasErroneous = false;

            foreach (RunCommand runCommand in runCommands.Where(x => !x.IsTerminate))
            {
                bool erroneous = IsErroneous(runCommands, runCommand);
                if (!erroneous && lastRunWasErroneous)
                {
                    yield return new PatternInstance(
                        runCommand,
                        -1,
                        ""
                        );
                }

                lastRunWasErroneous = erroneous;
            }
        }

        private bool IsErroneous(List<RunCommand> runCommands, RunCommand runCommand)
        {
            return IsErroneous(runCommands, runCommands.IndexOf(runCommand));
        }

        private bool IsErroneous(List<RunCommand> runCommands, int index)
        {
            if (index < 0 || index >= runCommands.Count - 1)
            {
                return false;
            }

            return !runCommands[index].IsTerminate &&
                runCommands[index + 1].IsTerminate &&
                runCommands[index + 1].Timestamp - runCommands[index].Timestamp < _threshold;
        }
    }
}
