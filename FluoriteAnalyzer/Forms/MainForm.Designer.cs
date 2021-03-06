﻿namespace FluoriteAnalyzer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logMergerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixInsertStringCommandRepeatCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateFixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logClosingFixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAnnotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixRenamingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTyposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectMovesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateActiveWorkingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractOperationConflictsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countEditedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.performPipelinedAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanPipelinedAnalysisResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.snapCurrentWindowLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapCurrentWindowRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juxtaposePatternsEventsWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSnapLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSnapRight = new System.Windows.Forms.ToolStripButton();
            this.countEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1105, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.recentFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // openLogToolStripMenuItem
            // 
            this.openLogToolStripMenuItem.Name = "openLogToolStripMenuItem";
            this.openLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openLogToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openLogToolStripMenuItem.Text = "&Open Log";
            this.openLogToolStripMenuItem.Click += new System.EventHandler(this.openLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent &Files";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logMergerToolStripMenuItem,
            this.fixInsertStringCommandRepeatCountToolStripMenuItem,
            this.duplicateFixToolStripMenuItem,
            this.logClosingFixToolStripMenuItem,
            this.adjustTimeToolStripMenuItem,
            this.extractAnnotationsToolStripMenuItem,
            this.fixRenamingsToolStripMenuItem,
            this.removeTyposToolStripMenuItem,
            this.detectMovesToolStripMenuItem,
            this.calculateActiveWorkingTimeToolStripMenuItem,
            this.extractOperationConflictsToolStripMenuItem,
            this.countEditedFilesToolStripMenuItem,
            this.countEventsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.performPipelinedAnalysisToolStripMenuItem,
            this.cleanPipelinedAnalysisResultsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.toolsToolStripMenuItem_DropDownOpening);
            // 
            // logMergerToolStripMenuItem
            // 
            this.logMergerToolStripMenuItem.Image = global::FluoriteAnalyzer.Properties.Resources.Merge;
            this.logMergerToolStripMenuItem.Name = "logMergerToolStripMenuItem";
            this.logMergerToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.logMergerToolStripMenuItem.Text = "&Log Merger";
            this.logMergerToolStripMenuItem.Click += new System.EventHandler(this.logMergerToolStripMenuItem_Click);
            // 
            // fixInsertStringCommandRepeatCountToolStripMenuItem
            // 
            this.fixInsertStringCommandRepeatCountToolStripMenuItem.Name = "fixInsertStringCommandRepeatCountToolStripMenuItem";
            this.fixInsertStringCommandRepeatCountToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.fixInsertStringCommandRepeatCountToolStripMenuItem.Text = "&Repeat Count Fix";
            this.fixInsertStringCommandRepeatCountToolStripMenuItem.Click += new System.EventHandler(this.fixInsertStringCommandRepeatCountToolStripMenuItem_Click);
            // 
            // duplicateFixToolStripMenuItem
            // 
            this.duplicateFixToolStripMenuItem.Name = "duplicateFixToolStripMenuItem";
            this.duplicateFixToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.duplicateFixToolStripMenuItem.Text = "&Duplicate Fix";
            this.duplicateFixToolStripMenuItem.Click += new System.EventHandler(this.duplicateFixToolStripMenuItem_Click);
            // 
            // logClosingFixToolStripMenuItem
            // 
            this.logClosingFixToolStripMenuItem.Name = "logClosingFixToolStripMenuItem";
            this.logClosingFixToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.logClosingFixToolStripMenuItem.Text = "Log Closing Fix";
            this.logClosingFixToolStripMenuItem.Click += new System.EventHandler(this.logClosingFixToolStripMenuItem_Click);
            // 
            // adjustTimeToolStripMenuItem
            // 
            this.adjustTimeToolStripMenuItem.Name = "adjustTimeToolStripMenuItem";
            this.adjustTimeToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.adjustTimeToolStripMenuItem.Text = "&Adjust Time";
            this.adjustTimeToolStripMenuItem.Click += new System.EventHandler(this.adjustTimeToolStripMenuItem_Click);
            // 
            // extractAnnotationsToolStripMenuItem
            // 
            this.extractAnnotationsToolStripMenuItem.Name = "extractAnnotationsToolStripMenuItem";
            this.extractAnnotationsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.extractAnnotationsToolStripMenuItem.Text = "&Extract Annotations";
            this.extractAnnotationsToolStripMenuItem.Click += new System.EventHandler(this.extractAnnotationsToolStripMenuItem_Click);
            // 
            // fixRenamingsToolStripMenuItem
            // 
            this.fixRenamingsToolStripMenuItem.Name = "fixRenamingsToolStripMenuItem";
            this.fixRenamingsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.fixRenamingsToolStripMenuItem.Text = "Fix Renamings";
            this.fixRenamingsToolStripMenuItem.Click += new System.EventHandler(this.fixRenamingsToolStripMenuItem_Click);
            // 
            // removeTyposToolStripMenuItem
            // 
            this.removeTyposToolStripMenuItem.Name = "removeTyposToolStripMenuItem";
            this.removeTyposToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.removeTyposToolStripMenuItem.Text = "Remove &Typos";
            this.removeTyposToolStripMenuItem.Click += new System.EventHandler(this.removeTyposToolStripMenuItem_Click);
            // 
            // detectMovesToolStripMenuItem
            // 
            this.detectMovesToolStripMenuItem.Name = "detectMovesToolStripMenuItem";
            this.detectMovesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.detectMovesToolStripMenuItem.Text = "Detect &Moves";
            this.detectMovesToolStripMenuItem.Click += new System.EventHandler(this.detectMovesToolStripMenuItem_Click);
            // 
            // calculateActiveWorkingTimeToolStripMenuItem
            // 
            this.calculateActiveWorkingTimeToolStripMenuItem.Name = "calculateActiveWorkingTimeToolStripMenuItem";
            this.calculateActiveWorkingTimeToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.calculateActiveWorkingTimeToolStripMenuItem.Text = "&Calculate Active Working Time";
            this.calculateActiveWorkingTimeToolStripMenuItem.Click += new System.EventHandler(this.calculateActiveWorkingTimeToolStripMenuItem_Click);
            // 
            // extractOperationConflictsToolStripMenuItem
            // 
            this.extractOperationConflictsToolStripMenuItem.Name = "extractOperationConflictsToolStripMenuItem";
            this.extractOperationConflictsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.extractOperationConflictsToolStripMenuItem.Text = "Extract Operation Conflicts";
            this.extractOperationConflictsToolStripMenuItem.Click += new System.EventHandler(this.extractOperationConflictsToolStripMenuItem_Click);
            // 
            // countEditedFilesToolStripMenuItem
            // 
            this.countEditedFilesToolStripMenuItem.Name = "countEditedFilesToolStripMenuItem";
            this.countEditedFilesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.countEditedFilesToolStripMenuItem.Text = "Count Edited Files";
            this.countEditedFilesToolStripMenuItem.Click += new System.EventHandler(this.countEditedFilesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(239, 6);
            // 
            // performPipelinedAnalysisToolStripMenuItem
            // 
            this.performPipelinedAnalysisToolStripMenuItem.Name = "performPipelinedAnalysisToolStripMenuItem";
            this.performPipelinedAnalysisToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.performPipelinedAnalysisToolStripMenuItem.Text = "Perform Pipelined Analysis";
            this.performPipelinedAnalysisToolStripMenuItem.Click += new System.EventHandler(this.performPipelinedAnalysisToolStripMenuItem_Click);
            // 
            // cleanPipelinedAnalysisResultsToolStripMenuItem
            // 
            this.cleanPipelinedAnalysisResultsToolStripMenuItem.Name = "cleanPipelinedAnalysisResultsToolStripMenuItem";
            this.cleanPipelinedAnalysisResultsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.cleanPipelinedAnalysisResultsToolStripMenuItem.Text = "Clean Pipelined Analysis Results";
            this.cleanPipelinedAnalysisResultsToolStripMenuItem.Click += new System.EventHandler(this.cleanPipelinedAnalysisResultsToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tileHorizontallyToolStripMenuItem,
            this.toolStripSeparator2,
            this.snapCurrentWindowLeftToolStripMenuItem,
            this.snapCurrentWindowRightToolStripMenuItem,
            this.juxtaposePatternsEventsWindowToolStripMenuItem,
            this.toolStripSeparator3});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            this.windowToolStripMenuItem.DropDownOpening += new System.EventHandler(this.windowToolStripMenuItem_DropDownOpening);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(257, 22);
            this.toolStripMenuItem2.Text = "Tile &Vertically";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tileHorizontallyToolStripMenuItem
            // 
            this.tileHorizontallyToolStripMenuItem.Name = "tileHorizontallyToolStripMenuItem";
            this.tileHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.tileHorizontallyToolStripMenuItem.Text = "Tile &Horizontally";
            this.tileHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // snapCurrentWindowLeftToolStripMenuItem
            // 
            this.snapCurrentWindowLeftToolStripMenuItem.Image = global::FluoriteAnalyzer.Properties.Resources.FillLeftHS;
            this.snapCurrentWindowLeftToolStripMenuItem.Name = "snapCurrentWindowLeftToolStripMenuItem";
            this.snapCurrentWindowLeftToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.snapCurrentWindowLeftToolStripMenuItem.Text = "Snap Current Window &Left";
            this.snapCurrentWindowLeftToolStripMenuItem.Click += new System.EventHandler(this.snapCurrentWindowLeftToolStripMenuItem_Click);
            // 
            // snapCurrentWindowRightToolStripMenuItem
            // 
            this.snapCurrentWindowRightToolStripMenuItem.Image = global::FluoriteAnalyzer.Properties.Resources.FillRightHS;
            this.snapCurrentWindowRightToolStripMenuItem.Name = "snapCurrentWindowRightToolStripMenuItem";
            this.snapCurrentWindowRightToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.snapCurrentWindowRightToolStripMenuItem.Text = "Snap Current Window &Right";
            this.snapCurrentWindowRightToolStripMenuItem.Click += new System.EventHandler(this.snapCurrentWindowRightToolStripMenuItem_Click);
            // 
            // juxtaposePatternsEventsWindowToolStripMenuItem
            // 
            this.juxtaposePatternsEventsWindowToolStripMenuItem.Name = "juxtaposePatternsEventsWindowToolStripMenuItem";
            this.juxtaposePatternsEventsWindowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.juxtaposePatternsEventsWindowToolStripMenuItem.Text = "Juxtapose Patterns/Events Window";
            this.juxtaposePatternsEventsWindowToolStripMenuItem.Click += new System.EventHandler(this.juxtaposePatternsEventsWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripSeparator1,
            this.toolStripTextSearch,
            this.toolStripLabel1,
            this.toolStripButtonSnapLeft,
            this.toolStripButtonSnapRight});
            this.toolMain.Location = new System.Drawing.Point(0, 24);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(1105, 25);
            this.toolMain.TabIndex = 2;
            this.toolMain.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::FluoriteAnalyzer.Properties.Resources.openHS;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "toolStripButtonOpen";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextSearch
            // 
            this.toolStripTextSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextSearch.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.toolStripTextSearch.Name = "toolStripTextSearch";
            this.toolStripTextSearch.Size = new System.Drawing.Size(350, 25);
            this.toolStripTextSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextSearch_KeyDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // toolStripButtonSnapLeft
            // 
            this.toolStripButtonSnapLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSnapLeft.Image = global::FluoriteAnalyzer.Properties.Resources.FillLeftHS;
            this.toolStripButtonSnapLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSnapLeft.Name = "toolStripButtonSnapLeft";
            this.toolStripButtonSnapLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSnapLeft.Text = "Snap Current Window Left";
            this.toolStripButtonSnapLeft.Click += new System.EventHandler(this.snapCurrentWindowLeftToolStripMenuItem_Click);
            // 
            // toolStripButtonSnapRight
            // 
            this.toolStripButtonSnapRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSnapRight.Image = global::FluoriteAnalyzer.Properties.Resources.FillRightHS;
            this.toolStripButtonSnapRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSnapRight.Name = "toolStripButtonSnapRight";
            this.toolStripButtonSnapRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSnapRight.Text = "Snap Current Window Right";
            this.toolStripButtonSnapRight.ToolTipText = "Snap Current Window Right";
            this.toolStripButtonSnapRight.Click += new System.EventHandler(this.snapCurrentWindowRightToolStripMenuItem_Click);
            // 
            // countEventsToolStripMenuItem
            // 
            this.countEventsToolStripMenuItem.Name = "countEventsToolStripMenuItem";
            this.countEventsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.countEventsToolStripMenuItem.Text = "Count Events";
            this.countEventsToolStripMenuItem.Click += new System.EventHandler(this.countEventsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1105, 613);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "Fluorite Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logMergerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixInsertStringCommandRepeatCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateFixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem extractAnnotationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTyposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectMovesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateActiveWorkingTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractOperationConflictsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logClosingFixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countEditedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem performPipelinedAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapCurrentWindowLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapCurrentWindowRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSnapLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonSnapRight;
        private System.Windows.Forms.ToolStripMenuItem juxtaposePatternsEventsWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanPipelinedAnalysisResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixRenamingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countEventsToolStripMenuItem;
    }
}

