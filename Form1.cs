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
            String ip = textBox1.Text;
            startProcess(@".\adb\adb.exe", "connect "+ip);
            startProcess(@".\adb\adb.exe", "install \"" + file + "\"");
        }

        private static void startProcess(string path, string args)
        {
            var p = Process.Start(new ProcessStartInfo
            {
                FileName = path,
                Arguments = args,
                RedirectStandardOutput = true,
                UseShellExecute = false
            });
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
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
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            textBox1.Visible = false;
        }
    }
}
