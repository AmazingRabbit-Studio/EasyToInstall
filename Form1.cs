using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EasyToInstall
{
    public partial class Form1 : Form
    {

        public static string path;

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
            path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (path != "")
            {
                install(path);
            }
        }

        private void install(string file)
        {
            string ip = textBox1.Text;
            string str = startProcess(@".\adb\adb.exe", $"connect {ip}");
            if (str.Contains("already connected to"))
            {
                TopMostMessageBox.Show("连接成功，点击“确定”继续", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TopMostMessageBox.Show("连接失败，请查看“帮助”页面或检查“高级”页面中的ip是否被修改或是否正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            str = startProcess(@".\adb\adb.exe", $@"install ""{file}""");
            string[] split = str.Split("\r\n".ToCharArray());
            if (split.Length > 1 && split[2] == "Success")
            {
                TopMostMessageBox.Show("安装成功，点击“确定”结束安装", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TopMostMessageBox.Show("安装失败，请检查apk是否有问题或是否是其他原因", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string startProcess(string path, string args)
        {
            var p = Process.Start(new ProcessStartInfo
            {
                FileName = path,
                Arguments = args,
                RedirectStandardOutput = true,
                UseShellExecute = false
            });
            p.WaitForExit();
            return p.StandardOutput.ReadToEnd();
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
        }

        private void 安装IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
        }

        private void 高级SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            textBox1.Visible = true;
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\WindowsApps\MicrosoftCorporationII.WindowsSubsystemForAndroid_2205.40000.21.0_x64__8wekyb3d8bbwe\WsaSettings.exe");
        }
    }
}
