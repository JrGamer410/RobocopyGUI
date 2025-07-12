namespace RobocopyGUI
{
    partial class Form1
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
            this.sourceText = new System.Windows.Forms.Label();
            this.pathPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.destinationText = new System.Windows.Forms.Label();
            this.fileFilterText = new System.Windows.Forms.Label();
            this.fileFilter = new System.Windows.Forms.ComboBox();
            this.attributesGroupBox = new System.Windows.Forms.GroupBox();
            this.noFileInfoCopy = new System.Windows.Forms.CheckBox();
            this.copySubdirectories = new System.Windows.Forms.CheckBox();
            this.copyEmptySubdirectories = new System.Windows.Forms.CheckBox();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.doOnlyArchive = new System.Windows.Forms.CheckBox();
            this.excludeJunctionPoints = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxBytes = new System.Windows.Forms.NumericUpDown();
            this.enforceMaxBytes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minBytes = new System.Windows.Forms.NumericUpDown();
            this.enforceMinBytes = new System.Windows.Forms.CheckBox();
            this.verboseOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.noJobSummary = new System.Windows.Forms.CheckBox();
            this.noJobHeader = new System.Windows.Forms.CheckBox();
            this.logFileBrowseButton = new System.Windows.Forms.Button();
            this.outputLogPath = new System.Windows.Forms.TextBox();
            this.outputLog = new System.Windows.Forms.CheckBox();
            this.showETA = new System.Windows.Forms.CheckBox();
            this.showFileTimestamps = new System.Windows.Forms.CheckBox();
            this.doVerbose = new System.Windows.Forms.CheckBox();
            this.logOutputSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.output = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.attributesGroupBox.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBytes)).BeginInit();
            this.verboseOutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceText
            // 
            this.sourceText.AutoSize = true;
            this.sourceText.Location = new System.Drawing.Point(12, 9);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(44, 13);
            this.sourceText.TabIndex = 0;
            this.sourceText.Text = "Source:";
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(15, 25);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(315, 20);
            this.sourcePath.TabIndex = 1;
            this.sourcePath.TextChanged += new System.EventHandler(this.sourcePath_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(336, 22);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseButton2
            // 
            this.browseButton2.Location = new System.Drawing.Point(336, 61);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(75, 23);
            this.browseButton2.TabIndex = 5;
            this.browseButton2.Text = "Browse...";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(15, 64);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(315, 20);
            this.destinationPath.TabIndex = 4;
            this.destinationPath.TextChanged += new System.EventHandler(this.destinationPath_TextChanged);
            // 
            // destinationText
            // 
            this.destinationText.AutoSize = true;
            this.destinationText.Location = new System.Drawing.Point(12, 48);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(63, 13);
            this.destinationText.TabIndex = 3;
            this.destinationText.Text = "Destination:";
            // 
            // fileFilterText
            // 
            this.fileFilterText.AutoSize = true;
            this.fileFilterText.Enabled = false;
            this.fileFilterText.Location = new System.Drawing.Point(13, 16);
            this.fileFilterText.Name = "fileFilterText";
            this.fileFilterText.Size = new System.Drawing.Size(51, 13);
            this.fileFilterText.TabIndex = 6;
            this.fileFilterText.Text = "File Filter:";
            // 
            // fileFilter
            // 
            this.fileFilter.Enabled = false;
            this.fileFilter.FormattingEnabled = true;
            this.fileFilter.Items.AddRange(new object[] {
            "*.*",
            "*.exe",
            "*.mp4",
            "*.doc",
            "*.docx"});
            this.fileFilter.Location = new System.Drawing.Point(16, 32);
            this.fileFilter.Name = "fileFilter";
            this.fileFilter.Size = new System.Drawing.Size(77, 21);
            this.fileFilter.TabIndex = 7;
            this.fileFilter.Text = "*.*";
            // 
            // attributesGroupBox
            // 
            this.attributesGroupBox.Controls.Add(this.noFileInfoCopy);
            this.attributesGroupBox.Location = new System.Drawing.Point(15, 156);
            this.attributesGroupBox.Name = "attributesGroupBox";
            this.attributesGroupBox.Size = new System.Drawing.Size(201, 45);
            this.attributesGroupBox.TabIndex = 8;
            this.attributesGroupBox.TabStop = false;
            this.attributesGroupBox.Text = "Attributes";
            // 
            // noFileInfoCopy
            // 
            this.noFileInfoCopy.AutoSize = true;
            this.noFileInfoCopy.Location = new System.Drawing.Point(6, 19);
            this.noFileInfoCopy.Name = "noFileInfoCopy";
            this.noFileInfoCopy.Size = new System.Drawing.Size(113, 17);
            this.noFileInfoCopy.TabIndex = 9;
            this.noFileInfoCopy.Text = "Don\'t copy file info";
            this.noFileInfoCopy.UseVisualStyleBackColor = true;
            // 
            // copySubdirectories
            // 
            this.copySubdirectories.AutoSize = true;
            this.copySubdirectories.Location = new System.Drawing.Point(12, 100);
            this.copySubdirectories.Name = "copySubdirectories";
            this.copySubdirectories.Size = new System.Drawing.Size(131, 17);
            this.copySubdirectories.TabIndex = 9;
            this.copySubdirectories.Text = "Copy all subdirectories";
            this.copySubdirectories.UseVisualStyleBackColor = true;
            this.copySubdirectories.CheckedChanged += new System.EventHandler(this.copySubdirectories_CheckedChanged);
            // 
            // copyEmptySubdirectories
            // 
            this.copyEmptySubdirectories.AutoSize = true;
            this.copyEmptySubdirectories.Enabled = false;
            this.copyEmptySubdirectories.Location = new System.Drawing.Point(32, 123);
            this.copyEmptySubdirectories.Name = "copyEmptySubdirectories";
            this.copyEmptySubdirectories.Size = new System.Drawing.Size(149, 17);
            this.copyEmptySubdirectories.TabIndex = 10;
            this.copyEmptySubdirectories.Text = "Copy empty subdirectories";
            this.copyEmptySubdirectories.UseVisualStyleBackColor = true;
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.doOnlyArchive);
            this.filtersGroupBox.Controls.Add(this.excludeJunctionPoints);
            this.filtersGroupBox.Controls.Add(this.label2);
            this.filtersGroupBox.Controls.Add(this.maxBytes);
            this.filtersGroupBox.Controls.Add(this.enforceMaxBytes);
            this.filtersGroupBox.Controls.Add(this.label1);
            this.filtersGroupBox.Controls.Add(this.minBytes);
            this.filtersGroupBox.Controls.Add(this.enforceMinBytes);
            this.filtersGroupBox.Controls.Add(this.fileFilterText);
            this.filtersGroupBox.Controls.Add(this.fileFilter);
            this.filtersGroupBox.Location = new System.Drawing.Point(16, 207);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(407, 105);
            this.filtersGroupBox.TabIndex = 11;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // doOnlyArchive
            // 
            this.doOnlyArchive.AutoSize = true;
            this.doOnlyArchive.Location = new System.Drawing.Point(16, 82);
            this.doOnlyArchive.Name = "doOnlyArchive";
            this.doOnlyArchive.Size = new System.Drawing.Size(132, 17);
            this.doOnlyArchive.TabIndex = 16;
            this.doOnlyArchive.Text = "Only copy archive files";
            this.doOnlyArchive.UseVisualStyleBackColor = true;
            // 
            // excludeJunctionPoints
            // 
            this.excludeJunctionPoints.AutoSize = true;
            this.excludeJunctionPoints.Location = new System.Drawing.Point(120, 57);
            this.excludeJunctionPoints.Name = "excludeJunctionPoints";
            this.excludeJunctionPoints.Size = new System.Drawing.Size(135, 17);
            this.excludeJunctionPoints.TabIndex = 14;
            this.excludeJunctionPoints.Text = "Exclude junction points";
            this.excludeJunctionPoints.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "bytes.";
            // 
            // maxBytes
            // 
            this.maxBytes.Location = new System.Drawing.Point(244, 33);
            this.maxBytes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxBytes.Name = "maxBytes";
            this.maxBytes.Size = new System.Drawing.Size(50, 20);
            this.maxBytes.TabIndex = 12;
            // 
            // enforceMaxBytes
            // 
            this.enforceMaxBytes.AutoSize = true;
            this.enforceMaxBytes.Location = new System.Drawing.Point(120, 34);
            this.enforceMaxBytes.Name = "enforceMaxBytes";
            this.enforceMaxBytes.Size = new System.Drawing.Size(124, 17);
            this.enforceMaxBytes.TabIndex = 11;
            this.enforceMaxBytes.Text = "Only copy files under";
            this.enforceMaxBytes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "bytes.";
            // 
            // minBytes
            // 
            this.minBytes.Location = new System.Drawing.Point(244, 14);
            this.minBytes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.minBytes.Name = "minBytes";
            this.minBytes.Size = new System.Drawing.Size(50, 20);
            this.minBytes.TabIndex = 9;
            this.minBytes.ValueChanged += new System.EventHandler(this.minBytesNum_ValueChanged);
            // 
            // enforceMinBytes
            // 
            this.enforceMinBytes.AutoSize = true;
            this.enforceMinBytes.Location = new System.Drawing.Point(120, 15);
            this.enforceMinBytes.Name = "enforceMinBytes";
            this.enforceMinBytes.Size = new System.Drawing.Size(118, 17);
            this.enforceMinBytes.TabIndex = 8;
            this.enforceMinBytes.Text = "Only copy files over";
            this.enforceMinBytes.UseVisualStyleBackColor = true;
            // 
            // verboseOutputGroupBox
            // 
            this.verboseOutputGroupBox.Controls.Add(this.noJobSummary);
            this.verboseOutputGroupBox.Controls.Add(this.noJobHeader);
            this.verboseOutputGroupBox.Controls.Add(this.logFileBrowseButton);
            this.verboseOutputGroupBox.Controls.Add(this.outputLogPath);
            this.verboseOutputGroupBox.Controls.Add(this.outputLog);
            this.verboseOutputGroupBox.Controls.Add(this.showETA);
            this.verboseOutputGroupBox.Controls.Add(this.showFileTimestamps);
            this.verboseOutputGroupBox.Controls.Add(this.doVerbose);
            this.verboseOutputGroupBox.Location = new System.Drawing.Point(16, 318);
            this.verboseOutputGroupBox.Name = "verboseOutputGroupBox";
            this.verboseOutputGroupBox.Size = new System.Drawing.Size(408, 111);
            this.verboseOutputGroupBox.TabIndex = 12;
            this.verboseOutputGroupBox.TabStop = false;
            this.verboseOutputGroupBox.Text = "Verbose and Output";
            // 
            // noJobSummary
            // 
            this.noJobSummary.AutoSize = true;
            this.noJobSummary.Location = new System.Drawing.Point(176, 86);
            this.noJobSummary.Name = "noJobSummary";
            this.noJobSummary.Size = new System.Drawing.Size(106, 17);
            this.noJobSummary.TabIndex = 16;
            this.noJobSummary.Text = "No Job Summary";
            this.noJobSummary.UseVisualStyleBackColor = true;
            // 
            // noJobHeader
            // 
            this.noJobHeader.AutoSize = true;
            this.noJobHeader.Location = new System.Drawing.Point(14, 86);
            this.noJobHeader.Name = "noJobHeader";
            this.noJobHeader.Size = new System.Drawing.Size(98, 17);
            this.noJobHeader.TabIndex = 15;
            this.noJobHeader.Text = "No Job Header";
            this.noJobHeader.UseVisualStyleBackColor = true;
            // 
            // logFileBrowseButton
            // 
            this.logFileBrowseButton.Enabled = false;
            this.logFileBrowseButton.Location = new System.Drawing.Point(365, 42);
            this.logFileBrowseButton.Name = "logFileBrowseButton";
            this.logFileBrowseButton.Size = new System.Drawing.Size(37, 23);
            this.logFileBrowseButton.TabIndex = 5;
            this.logFileBrowseButton.Text = "...";
            this.logFileBrowseButton.UseVisualStyleBackColor = true;
            this.logFileBrowseButton.Click += new System.EventHandler(this.logFileBrowseButton_Click);
            // 
            // outputLogPath
            // 
            this.outputLogPath.Enabled = false;
            this.outputLogPath.Location = new System.Drawing.Point(176, 42);
            this.outputLogPath.Name = "outputLogPath";
            this.outputLogPath.Size = new System.Drawing.Size(182, 20);
            this.outputLogPath.TabIndex = 4;
            // 
            // outputLog
            // 
            this.outputLog.AutoSize = true;
            this.outputLog.Location = new System.Drawing.Point(176, 19);
            this.outputLog.Name = "outputLog";
            this.outputLog.Size = new System.Drawing.Size(103, 17);
            this.outputLog.TabIndex = 3;
            this.outputLog.Text = "Output log to file";
            this.outputLog.UseVisualStyleBackColor = true;
            this.outputLog.CheckedChanged += new System.EventHandler(this.outputLog_CheckedChanged);
            // 
            // showETA
            // 
            this.showETA.AutoSize = true;
            this.showETA.Location = new System.Drawing.Point(14, 65);
            this.showETA.Name = "showETA";
            this.showETA.Size = new System.Drawing.Size(77, 17);
            this.showETA.TabIndex = 2;
            this.showETA.Text = "Show ETA";
            this.showETA.UseVisualStyleBackColor = true;
            // 
            // showFileTimestamps
            // 
            this.showFileTimestamps.AutoSize = true;
            this.showFileTimestamps.Location = new System.Drawing.Point(14, 42);
            this.showFileTimestamps.Name = "showFileTimestamps";
            this.showFileTimestamps.Size = new System.Drawing.Size(131, 17);
            this.showFileTimestamps.TabIndex = 1;
            this.showFileTimestamps.Text = "Show File Timestamps";
            this.showFileTimestamps.UseVisualStyleBackColor = true;
            // 
            // doVerbose
            // 
            this.doVerbose.AutoSize = true;
            this.doVerbose.Location = new System.Drawing.Point(14, 19);
            this.doVerbose.Name = "doVerbose";
            this.doVerbose.Size = new System.Drawing.Size(100, 17);
            this.doVerbose.TabIndex = 0;
            this.doVerbose.Text = "Verbose Output";
            this.doVerbose.UseVisualStyleBackColor = true;
            // 
            // logOutputSaveDialog
            // 
            this.logOutputSaveDialog.Filter = "Log Files|*.log";
            this.logOutputSaveDialog.Title = "Choose a path to output the log to";
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.HorizontalScrollbar = true;
            this.output.Location = new System.Drawing.Point(427, 25);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(440, 368);
            this.output.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Output:";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(427, 404);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(792, 406);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 16;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 441);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.verboseOutputGroupBox);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.copyEmptySubdirectories);
            this.Controls.Add(this.copySubdirectories);
            this.Controls.Add(this.attributesGroupBox);
            this.Controls.Add(this.browseButton2);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.sourceText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robocopy GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.attributesGroupBox.ResumeLayout(false);
            this.attributesGroupBox.PerformLayout();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBytes)).EndInit();
            this.verboseOutputGroupBox.ResumeLayout(false);
            this.verboseOutputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceText;
        private System.Windows.Forms.FolderBrowserDialog pathPicker;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button browseButton2;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.Label destinationText;
        private System.Windows.Forms.Label fileFilterText;
        private System.Windows.Forms.ComboBox fileFilter;
        private System.Windows.Forms.GroupBox attributesGroupBox;
        private System.Windows.Forms.CheckBox noFileInfoCopy;
        private System.Windows.Forms.CheckBox copySubdirectories;
        private System.Windows.Forms.CheckBox copyEmptySubdirectories;
        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.NumericUpDown minBytes;
        private System.Windows.Forms.CheckBox enforceMinBytes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxBytes;
        private System.Windows.Forms.CheckBox enforceMaxBytes;
        private System.Windows.Forms.CheckBox excludeJunctionPoints;
        private System.Windows.Forms.GroupBox verboseOutputGroupBox;
        private System.Windows.Forms.CheckBox doVerbose;
        private System.Windows.Forms.CheckBox showFileTimestamps;
        private System.Windows.Forms.CheckBox showETA;
        private System.Windows.Forms.Button logFileBrowseButton;
        private System.Windows.Forms.TextBox outputLogPath;
        private System.Windows.Forms.CheckBox outputLog;
        private System.Windows.Forms.SaveFileDialog logOutputSaveDialog;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox noJobSummary;
        private System.Windows.Forms.CheckBox noJobHeader;
        private System.Windows.Forms.CheckBox doOnlyArchive;
        private System.Windows.Forms.Button aboutButton;
    }
}

