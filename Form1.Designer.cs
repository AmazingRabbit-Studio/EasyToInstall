using System.Collections.Generic;

namespace EasyToInstall
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.安装IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言F5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体中文CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(0, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 304);
            this.button1.TabIndex = 0;
            this.button1.Text = "点击或拖拽文件来安装";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.安装IToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.高级SToolStripMenuItem,
            this.语言F5ToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 安装IToolStripMenuItem
            // 
            this.安装IToolStripMenuItem.Name = "安装IToolStripMenuItem";
            this.安装IToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.安装IToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.安装IToolStripMenuItem.Text = " 安装(F1)";
            this.安装IToolStripMenuItem.Click += new System.EventHandler(this.IToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(F2)";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.HToolStripMenuItem_Click);
            // 
            // 高级SToolStripMenuItem
            // 
            this.高级SToolStripMenuItem.Name = "高级SToolStripMenuItem";
            this.高级SToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.高级SToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.高级SToolStripMenuItem.Text = "高级(F3)";
            this.高级SToolStripMenuItem.Click += new System.EventHandler(this.SToolStripMenuItem_Click);
            // 
            // 语言F5ToolStripMenuItem
            // 
            this.语言F5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简体中文CToolStripMenuItem,
            this.englishUSEToolStripMenuItem});
            this.语言F5ToolStripMenuItem.Name = "语言F5ToolStripMenuItem";
            this.语言F5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.语言F5ToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.语言F5ToolStripMenuItem.Text = "语言🌏(F4)";
            // 
            // 简体中文CToolStripMenuItem
            // 
            this.简体中文CToolStripMenuItem.Name = "简体中文CToolStripMenuItem";
            this.简体中文CToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.简体中文CToolStripMenuItem.Text = "简体中文";
            this.简体中文CToolStripMenuItem.Click += new System.EventHandler(this.CToolStripMenuItem_Click);
            // 
            // englishUSEToolStripMenuItem
            // 
            this.englishUSEToolStripMenuItem.Name = "englishUSEToolStripMenuItem";
            this.englishUSEToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.englishUSEToolStripMenuItem.Text = "English(US)";
            this.englishUSEToolStripMenuItem.Click += new System.EventHandler(this.EToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.关于AToolStripMenuItem.Text = "关于(F5)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "安装前请先在“适用于 Android™ 的 Windows 子系统设置”中打开“开发人员模\r\n式”并将“子系统资源”中“连续”调为“按需要”，安装完后可以调回来\r" +
    "\n如果安装失败可以试试打开着一个子系统应用再安装";
            this.label1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "adb连接IP（如无特殊需求勿动）";
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "127.0.0.1:58526";
            this.textBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "由ARMrAmzing和PercyDan制作\r\nGithub: ARMrAmzing & PercyDan";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(437, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "打开子系统设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 332);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "一键安装apk";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 安装IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 高级SToolStripMenuItem;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 语言F5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简体中文CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUSEToolStripMenuItem;
    }
}

