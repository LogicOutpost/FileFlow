using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FileFlow
{
    public partial class homePage : Form
    {
        List<string> Images = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".webp", ".svg", ".tiff" };
        List<string> Documents = new List<string> { ".pdf", ".doc", ".docx", ".txt", ".rtf", ".odt", ".md" };
        List<string> SpreadSheets = new List<string> { ".xls", ".xlsx", ".csv", ".ods" };
        List<string> Audio = new List<string> { ".mp3", ".wav", ".flac", ".m4a", ".aac", ".ogg" };
        List<string> Video = new List<string> { ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".webm", ".m4v" };
        List<string> Arch = new List<string> { ".zip", ".rar", ".7z", ".tar", ".gz" };
        List<string> Code = new List<string> { ".cs", ".csproj", ".sln", ".json", ".xml", ".html", ".css", ".js", ".sql" };
        List<string> Disk = new List<string> { ".exe", ".dll", ".sys", ".bat", ".cmd", ".msi" };
        private string filePath = "";
        public homePage()
        {
            InitializeComponent();
        }

        private void dirButton_Click(object sender, EventArgs e)
        {
            int images = 0;
            int docs = 0;
            int spread = 0;
            int audio = 0;
            int video = 0;
            int arch = 0;
            int code = 0;
            int disk = 0;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            folderLabel.Text = $"Folder: {dialog.SelectedPath}";
            filePath = dialog.SelectedPath;
            string[] files = Directory.GetFiles(filePath);
            foreach (string file in files)
            {
                if (Images.Contains(Path.GetExtension(file)))
                {
                    images++;
                }
                else if (Documents.Contains(Path.GetExtension(file)))
                {
                    docs++;
                }
                else if (SpreadSheets.Contains(Path.GetExtension(file)))
                {
                    spread++;
                }
                else if (Audio.Contains(Path.GetExtension(file)))
                {
                    audio++;
                }
                else if (Video.Contains(Path.GetExtension(file)))
                {
                    video++;
                }
                else if (Arch.Contains(Path.GetExtension(file)))
                {
                    arch++;
                }
                else if (Code.Contains(Path.GetExtension(file)))
                {
                    code++;
                }
                else if (Disk.Contains(Path.GetExtension(file)))
                {
                    disk++;
                }
                int total = images + docs + spread + audio + video + arch + code + disk;
                statsLabel.Text = $"Images: {images}\nDocuments: {docs}\nSpread Sheets: {spread}\nAudio Files: {audio}\nVideos: {video}\nArchive Files: {arch}\n" +
                    $"Code Files: {code}\nDisk/System Files: {disk}\nTotal Files: {total}";
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            SortFiles();
        }

        private void SortFiles()
        {
            string[] files = Directory.GetFiles(filePath);
            string combinedPath = "";
            try
            {
                foreach (string file in files)
                {
                    if (Images.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Images");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (Documents.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Documents");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (SpreadSheets.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Spred Sheets");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (Audio.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Audio Files");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (Video.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Video Files");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (Arch.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Archives");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (Code.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Code files");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                    else if (Disk.Contains(Path.GetExtension(file)))
                    {
                        combinedPath = Path.Combine(filePath, "Disk Files");

                        if (!Directory.Exists(combinedPath))
                        {
                            Directory.CreateDirectory(combinedPath);
                        }

                        string destination = Path.Combine(combinedPath, Path.GetFileName(file));

                        File.Move(file, destination);
                    }
                }
                MessageBox.Show("Files sorted", "We're Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void logStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discord: Austin9675\n" +
                "Email: Austindevat@gmail.com", "Contact");
        }

        private void openLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is currently in development and will soon support file logging", "Coming soon!");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void darkBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor = Color.Red;
            sortButton.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor = Color.Blue;
            sortButton.BackColor = Color.Blue;
        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor = Color.White;
            sortButton.BackColor = Color.White;
        }

        private void orangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor = Color.Orange;
            sortButton.BackColor = Color.Orange;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor = Color.Green;
            sortButton.BackColor = Color.Green;
        }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor = Color.Yellow;
            sortButton.BackColor = Color.Yellow;
        }

        private void darkBlueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor= Color.DarkBlue;
            sortButton.BackColor= Color.DarkBlue;
        }

        private void purpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dirButton.BackColor= Color.Purple;
            sortButton.BackColor= Color.Purple;
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.Blue;
        }

        private void whiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.White;
        }

        private void orangeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.Orange;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.Green;
        }

        private void yellowToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.Yellow;
        }

        private void darkBlueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.DarkBlue;
        }

        private void purpleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            statsBox.BackColor = Color.Purple;
        }
    }
}
