
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyToInstall
{
    class DialogOperate
    {

        public static string strFileName = "";
        public static string sPath = "";

        //打开文件对话框
        public static string OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "安卓应用安装包(*.apk)|*.apk|所有文件|*.*";
            ofd.ValidateNames = true; // 验证用户输入是否是一个有效的Windows文件名
            ofd.CheckFileExists = true; //验证路径的有效性
            ofd.CheckPathExists = true;//验证路径的有效性
            if (ofd.ShowDialog() == DialogResult.OK) //用户点击确认按钮，发送确认消息
            {
                strFileName = ofd.FileName;//获取在文件对话框中选定的路径或者字符串

            }
            return strFileName;
        }

        public string OpenFolder()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件所在文件夹目录";  //定义在对话框上显示的文本

            if (folder.ShowDialog() == DialogResult.OK)
            {
                sPath = folder.SelectedPath;
            }
            return sPath;
        }
    }
}
