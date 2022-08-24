using System;
using System.IO;
using System.Windows.Forms;

namespace EasyToInstall
{
    internal class EnvironmentTest
    {
        public EnvironmentTest() {

            var ver = Environment.OSVersion.Version;
            if (!(ver.Major == 10 && ver.Build >= 22000))
            {
                TopMostMessageBox.Show("您的操作系统不是Windows 11，可能无法使用安卓子系统\nYour operating system isn't Windows 11, so you can't perhaps use the Android Subsystem", String.Empty , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*if (!File.Exists("C:\\Program Files\\WindowsApps\\MicrosoftCorporationII.WindowsSubsystemForAndroid_2205.40000.21.0_x64__8wekyb3d8bbwe\\WsaClient\\WsaClient.exe")) { 
                TopMostMessageBox.Show("您未安装安卓子系统！\nYou haven't installed the Android Subsytem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
