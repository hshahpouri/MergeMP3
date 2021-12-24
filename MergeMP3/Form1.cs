using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Text.Json;

namespace MergeMP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BackgroundImage = null;
        }

        private void ShowDirectoryFiles()
        {
            Cursor = Cursors.WaitCursor;
            listFiles.Items.Clear();
            listFiles.Items.AddRange(Directory.EnumerateFiles(TbDir.Text, "*.mp3").Select(t => new ListViewItem(new[] { t, "" })).ToArray());
            if (listFiles.Items.Count > 0)
            {
                listFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                TbTargetFile.Text = $"{TbDir.Text}.mp3";
                var ffprobe_tasks = new List<Task<KeyValuePair<int, string>>>(listFiles.Items.Count);

                for (int i = 0; i < listFiles.Items.Count; i++)
                {
                    var file_path = listFiles.Items[i].SubItems[0].Text;
                    var index = i;

                    ffprobe_tasks.Add(Task.Run(() =>
                    {
                        var ffprobe = new Process();
                        ffprobe.StartInfo.FileName = "ffprobe.exe";
                        ffprobe.StartInfo.Arguments = $"-i \"{file_path}\" -hide_banner -v quiet -show_entries stream=duration -print_format json";
                        ffprobe.StartInfo.CreateNoWindow = true;
                        ffprobe.StartInfo.RedirectStandardOutput = true;
                        ffprobe.Start();
                        ffprobe.WaitForExit();
                        var result = ffprobe.StandardOutput.ReadToEnd();
                        try
                        {
                            var json = JsonSerializer.Deserialize<JSON_ffprobe>(result);
                            return new KeyValuePair<int, string>(index, json.Duration);
                        }
                        catch (Exception)
                        {
                            return new KeyValuePair<int, string>(index, "cannot read!");
                        }
                    }));

                }

                Task.WhenAll(ffprobe_tasks).Result.ToList().ForEach(task => listFiles.Items[task.Key].SubItems[1].Text = task.Value);
                listFiles.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);

                TimeSpan total_duration = TimeSpan.Zero;
                for (int i = 0; i < listFiles.Items.Count; i++)
                {
                    TimeSpan item_duration = TimeSpan.Parse(listFiles.Items[i].SubItems[1].Text);
                    total_duration = total_duration.Add(item_duration);
                }
                groupBox2.Text = $"Select Target File ({total_duration:hh\\:mm\\:ss})";
                Cursor = DefaultCursor;
            }
        }

        private void TbDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                ShowDirectoryFiles();
            }
        }

        private void BtnBrowseDir_Click(object sender, EventArgs e)
        {
            if (FolderBrowse.ShowDialog() == DialogResult.OK)
            {
                FolderBrowse.InitialDirectory = FolderBrowse.SelectedPath;
                TbDir.Text = FolderBrowse.SelectedPath;
                ShowDirectoryFiles();
            }
        }

        private void BtnBrowseSave_Click(object sender, EventArgs e)
        {
            if (FileSave.ShowDialog() == DialogResult.OK)
            {
                TbTargetFile.Text = FileSave.FileName;
            }
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            if (listFiles.Items.Count == 0)
            {
                MessageBox.Show(this, "There's no file to merge", ".mp3 files not found!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (File.Exists(TbTargetFile.Text))
            {
                if (MessageBox.Show(this, $"File '{TbTargetFile.Text}' already exists.\nOverwrite it?", "Target file exists.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    return;

                File.Delete(TbTargetFile.Text);
            }

            var input_txt = Path.GetTempFileName();
            var txt_content = new List<string>();
            for (int i = 0; i < listFiles.Items.Count; i++)
            {
                txt_content.Add($"file '{listFiles.Items[i].SubItems[0].Text}'");
            }
            File.WriteAllLines(input_txt, txt_content);

            var ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = $"-f concat -safe 0 -i {input_txt} -c copy {TbTargetFile.Text}";
            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.Start();
            ffmpeg.WaitForExit();

            File.Delete(input_txt);
            if (MessageBox.Show(this, "Files in the list has been merged.\nWould you like to open target path?", "Merged", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Process.Start("explorer", $"/select, \"{TbTargetFile.Text}\"");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Escape) && MessageBox.Show(this, "Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Handled = true;
                Application.Exit();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brushGradient = new(new Point(5, 5),
                                                    new Point(5, Height - 10),
                                                    ColorTranslator.FromHtml("#a1e3f6"),
                                                    ColorTranslator.FromHtml("#d0f1fa"));

            Rectangle area = new(5, 5, 190, ClientSize.Height - 10);
            Rectangle area_inner = new(6, 6, 188, ClientSize.Height - 12);

            e.Graphics.Clear(BackColor);

            e.Graphics.FillRectangle(brushGradient, area);

            e.Graphics.DrawRectangle(Pens.Gray, area);
            e.Graphics.DrawRectangle(Pens.White, area_inner);

            e.Graphics.DrawImageUnscaledAndClipped(Properties.Resources.Banner, new Rectangle(0, 0, 200, 150));

            e.Graphics.CompositingQuality = CompositingQuality.AssumeLinear;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            InvokePaint(this, new PaintEventArgs(CreateGraphics(), ClientRectangle));
        }
    }
}