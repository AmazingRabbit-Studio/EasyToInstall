using System.Collections.Generic;

namespace EasyToInstall
{
    public class LanguageManager
    {
        public readonly Dictionary<int, string> dic;

        public LanguageManager(Language lang)
        {
            if (lang == Language.CHS)
            {
                dic = new Dictionary<int, string>
                {
                    {0, "一键安装APK"},
                    {1, "点击或拖拽文件来安装"},
                    {2, "打开子系统设置"},
                    {3, "安装前请先在“适用于 Android™ 的 Windows 子系统设置”中打开“开发人员模\r\n式”并将“子系统资源”中“连续”调为“按需要”，安装完后可以调回来\r\n如果安装仍然失败可以试试打开着一个子系统应用再安装"},
                    {4, "adb连接IP（如无特殊需求勿动）"},
                    {5, "由ARMrAmzing和PercyDan制作\r\nGithub: ARMrAmzing PercyDan"},
                    {6, "安装(F1)"},
                    {7, "帮助(F2)"},
                    {8, "关于(F4)"},
                    {9, "高级(F3)"},
                    {10, "语言🌏"},
                    {11, "连接成功，点击“确定”继续"},
                    {12, "连接失败，请查看“帮助”页面或检查“高级”页面中的ip是否被修改或是否正确\n错误："},
                    {13, "安装"},
                    {14, "成功，点击“确定”结束安装"},
                    {15, "安装失败，请重试或检查apk是否有问题或是否是其他原因\n错误：" },
                    {16, "\n返回代码："},
                    {17, "启动adb失败\n"},
                    {18, "错误"},
                };
            }
            if(lang == Language.EN)
            {

                dic = new Dictionary<int, string>
                {
                    {0, "One-click to Install APKs"},
                    {1, "Click or Drag the File(s) to Install"},
                    {2, "Open the Settings of the Subsystem"},
                    {3, "Before installing, please open the \"Developer mode\" in the \"Windows\r\nSubsystem for Android™️ Settings\" and turn the \"Subsystem resources\" from\r\n\"As needed\" to \"Continuous\". After installing, you can turn it back.\r\nIf you fail to install, you can try keeping opening an app of the sub-\r\nsystem before installing."},
                    {4, "The IP of adb to be connected (Don't modify it unless in need):"},
                    {5, "Made by ARMrAmzing and PercyDan\r\nGithub: ARMrAmzing PercyDan"},
                    {6, "Installation(F1)"},
                    {7, "Help(F2)"},
                    {8, "About(F4)"},
                    {9, "Advance(F3)"},
                    {10, "Languages🌏"},
                    {11, "Succeeded to connect, click \"OK\" to continue"},
                    {12, "Failed to connect, please check out the \"Help\" page or check if the IP in the \"Advance\" page has been changed or it is right.\nError："},
                    {13, "Succeeded to install"},
                    {14, ", click \"OK\" to exit the installation"},
                    {15, "Failed to install, please retry , check if the APK goes wrong or find out any other problem.\nError: " },
                    {16, "\nReturned code:"},
                    {17, "Failed to launch adb\n"},
                    {18, "Error"},
                };

            }
        }
    }
}