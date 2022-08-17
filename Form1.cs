using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace EasyToInstall
{
    public partial class Form1 : Form
    {

        public static string path;
        public LanguageManager languageManager = new LanguageManager(Language.CHS);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path = DialogOperate.OpenFile();
            if (path != "")
            {
                install(path);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string path in (Array)e.Data.GetData(DataFormats.FileDrop))
            {
                if (path != "")
                {
                    install(path);
                }
            }
        }

        private void install(string file)
        {
            string ip = textBox1.Text;
            try
            {
                var result = startProcess(@".\adb\adb.exe", $"connect {ip}");
                if (result.output.Contains("connected to"))
                {
                    TopMostMessageBox.Show(languageManager.dic[11], string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TopMostMessageBox.Show(languageManager.dic[12] + result.output, languageManager.dic[18], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                result = startProcess(@".\adb\adb.exe", $@"install ""{file}""");
                if (result.exitCode == 0)
                {
                    TopMostMessageBox.Show(languageManager.dic[13] + file + languageManager.dic[14], string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TopMostMessageBox.Show(languageManager.dic[15] + result.standardError + languageManager.dic[16] + result.exitCode, languageManager.dic[18] , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                TopMostMessageBox.Show(languageManager.dic[17]  + e, languageManager.dic[18],MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static (int exitCode, string output, string standardError) startProcess(string path, string args)
        {
            var p = Process.Start(new ProcessStartInfo
            {
                FileName = path,
                Arguments = args,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                UseShellExecute = false
            });
            p.WaitForExit();
            return (p.ExitCode, p.StandardOutput.ReadToEnd(), p.StandardError.ReadToEnd());
        }

        private void HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
        }

        private void IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            label1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
        }

        private void SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            textBox1.Visible = true;
        }

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\WindowsApps\MicrosoftCorporationII.WindowsSubsystemForAndroid_2205.40000.21.0_x64__8wekyb3d8bbwe\WsaSettings.exe");
        }

        private void CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageManager = new LanguageManager(Language.CHS);
            this.button1.Text = languageManager.dic[1];
            this.安装IToolStripMenuItem.Text = languageManager.dic[6];
            this.帮助HToolStripMenuItem.Text = languageManager.dic[7];
            this.高级SToolStripMenuItem.Text = languageManager.dic[9];
            this.label1.Text = languageManager.dic[3];
            this.label5.Text = languageManager.dic[4];
            this.label6.Text = languageManager.dic[5];
            this.button2.Text = languageManager.dic[2];
            this.语言F5ToolStripMenuItem.Text = languageManager.dic[10];
            this.关于AToolStripMenuItem.Text = languageManager.dic[8];
            this.Text = languageManager.dic[0];
            this.Validate();
        }

        private void EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageManager = new LanguageManager(Language.EN);
            this.button1.Text = languageManager.dic[1];
            this.安装IToolStripMenuItem.Text = languageManager.dic[6];
            this.帮助HToolStripMenuItem.Text = languageManager.dic[7];
            this.高级SToolStripMenuItem.Text = languageManager.dic[9];
            this.label1.Text = languageManager.dic[3];
            this.label5.Text = languageManager.dic[4];
            this.label6.Text = languageManager.dic[5];
            this.button2.Text = languageManager.dic[2];
            this.语言F5ToolStripMenuItem.Text = languageManager.dic[10];
            this.关于AToolStripMenuItem.Text = languageManager.dic[8];
            this.Text = languageManager.dic[0];
        }

        //This method is used to debug tip windows
        private void Debug() 
        {
            TopMostMessageBox.Show(languageManager.dic[11], string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TopMostMessageBox.Show(languageManager.dic[12] + "result.output", languageManager.dic[18], MessageBoxButtons.OK, MessageBoxIcon.Error);
            TopMostMessageBox.Show(languageManager.dic[13] + "file" + languageManager.dic[14], string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TopMostMessageBox.Show(languageManager.dic[15] + "result.standardError" + languageManager.dic[16] + "result.exitCode", languageManager.dic[18], MessageBoxButtons.OK, MessageBoxIcon.Error);
            TopMostMessageBox.Show(languageManager.dic[17] + "e", languageManager.dic[18], MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
