using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace RobocopyGUI
{
    public partial class Form1 : Form
    {
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
                args += $" /TEE /LOG:\"{outputLogPath.Text}\"";
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
                        output.TopIndex = output.Items.Count - 1; // Auto-scroll
                    }));
                }
            };
            // Notify the user we're starting with the specific arguments.
            output.Items.Add("Starting Robocopy with arguments: " + args);
            robocopyProcess.Start();
            robocopyProcess.BeginOutputReadLine();
        }
    }
}
