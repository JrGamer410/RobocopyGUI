using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace RobocopyGUI
{
    public partial class Form1 : Form
    {
        string lastLog = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            pathPicker.ShowNewFolderButton = false;
            pathPicker.Description = "Select the source directory to copy files from.";
            if (pathPicker.ShowDialog() == DialogResult.OK)
            {
                sourcePath.Text = pathPicker.SelectedPath;
            }
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            pathPicker.ShowNewFolderButton = true;
            pathPicker.Description = "Select the destination directory to copy files to.";
            if (pathPicker.ShowDialog() == DialogResult.OK)
            {
                destinationPath.Text = pathPicker.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            action.Text = "Move files only";
            CultureInfo uiCulture = CultureInfo.InstalledUICulture;
            string language = uiCulture.Name;
            switch (language)
            {
                case "de-DE":
                    destinationPath.Text = "Ziel:";
                    sourcePath.Text = "Quelle:";
                    aboutButton.Text = "Um";
                    browseButton.Text = "Durchsuchen...";
                    browseButton2.Text = "Durchsuchen...";
                    doVerbose.Text = "Ausführliche Ausgabe";
                    break;
                case "ru-RU":
                    browseButton.Text = "Просматривать...";
                    browseButton2.Text = "Просматривать...";
                    aboutButton.Text = "О";
                    doVerbose.Text = "Подробный вывод";
                    break;
            }
        }

        private void copySubdirectories_CheckedChanged(object sender, EventArgs e)
        {
            copyEmptySubdirectories.Enabled = copySubdirectories.Checked;
        }

        private void minBytesNum_ValueChanged(object sender, EventArgs e)
        {
            // If the minimum is less or equal to the max, set the max to 1 above the minimum.
            if (minBytes.Value >= maxBytes.Value)
            {
                maxBytes.Value = minBytes.Value + 1;
            }
        }

        private void outputLog_CheckedChanged(object sender, EventArgs e)
        {
            outputLogPath.Enabled = outputLog.Checked;
            logFileBrowseButton.Enabled = outputLog.Checked;
        }

        private void logFileBrowseButton_Click(object sender, EventArgs e)
        {
            if (logOutputSaveDialog.ShowDialog() == DialogResult.OK)
            {
                outputLogPath.Text = logOutputSaveDialog.FileName;
            }
        }

        private void sourcePath_TextChanged(object sender, EventArgs e)
        {
            if (sourcePath.Text != "" && destinationPath.Text != "")
            {
                startButton.Enabled = true;
            }
            else
            {
                startButton.Enabled = false;
            }
        }

        private void destinationPath_TextChanged(object sender, EventArgs e)
        {
            if (sourcePath.Text != "" && destinationPath.Text != "")
            {
                startButton.Enabled = true;
            }
            else
            {
                startButton.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            currentFilePercent.Visible = true;
            lastLog = outputLogPath.Text;
            // We'll clear the output in case the user has ran this before.
            output.Items.Clear();
            // Here we define our args string variable and add command options based on the user's inputs.
            string args = $"\"{sourcePath.Text}\" \"{destinationPath.Text}\"";
            if (doVerbose.Checked)
            {
                args += " /V";
            }
            if (showFileTimestamps.Checked)
            {
                args += " /TS";
            }
            if (showETA.Checked)
            {
                args += " /ETA";
            }
            if (excludeJunctionPoints.Checked)
            {
                args += " /XJ";
            }
            if (enforceMaxBytes.Checked)
            {
                args += $" /MAX:{maxBytes.Value}";
            }
            if (enforceMinBytes.Checked)
            {
                args += $" /MIN:{minBytes.Value}";
            }
            if (copySubdirectories.Checked)
            {
                if (copyEmptySubdirectories.Checked)
                {
                    args += " /E";
                } else
                {
                    args += " /S";
                }
            }
            if (outputLog.Checked)
            {
                args += $" /TEE /LOG:\"{lastLog}\"";
            }
            if (noJobHeader.Checked) {                 
                args += " /NJH";
            }
            if (noJobSummary.Checked)
            {
                args += " /NJS";
            }
            if (doOnlyArchive.Checked)
            {
                args += " /A";
            }
            if (action.Text == "Move files only")
            {
                args += " /MOV";
            }
            else if (action.Text == "Move files and directories")
            {
                args += " /MOVE";
            }
            else if (action.Text == "Test Run")
            {
                args += " /L";
            }
            else if (action.Text == "Copy files and folders with all attributes")
            {
                args += " /COPYALL";
            }
            Process robocopyProcess = new Process();
            robocopyProcess.StartInfo.FileName = "robocopy.exe";
            robocopyProcess.StartInfo.Arguments = args;
            robocopyProcess.StartInfo.UseShellExecute = false;
            robocopyProcess.StartInfo.RedirectStandardOutput = true;
            robocopyProcess.StartInfo.CreateNoWindow = true;
            robocopyProcess.EnableRaisingEvents = true;
            robocopyProcess.OutputDataReceived += (s, outputEvent) =>
            {
                if (!string.IsNullOrEmpty(outputEvent.Data))
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        output.Items.Add(outputEvent.Data);
                        if (outputEvent.Data.EndsWith("%"))
                        {
                            currentFilePercent.Text = outputEvent.Data;
                            outputProgressBar.Value = int.Parse(outputEvent.Data.TrimEnd('%'));
                        }
                        output.TopIndex = output.Items.Count - 1; // Auto-scroll
                    }));
                }
            };
            // Notify the user we're starting with the specific arguments.
            output.Items.Add("Starting Robocopy with arguments: " + args);
            robocopyProcess.Start();
            robocopyProcess.BeginOutputReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RobocopyGUI is a simple GUI wrapper by JrGamer410 for Robocopy, a powerful file copy utility in Windows.\n\n" +
                "This application allows you to easily configure and run Robocopy commands without needing to use the command line.\n\n" +
                "For more information about Robocopy, visit: https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/robocopy",
                "About RobocopyGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maxBytes_ValueChanged(object sender, EventArgs e)
        {
            // If the minimum is less or equal to the max, set the max to 1 above the minimum.
            if (minBytes.Value >= maxBytes.Value)
            {
                maxBytes.Value = minBytes.Value + 1;
            }
        }
    }
}
