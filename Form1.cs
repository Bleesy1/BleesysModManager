using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ModManager.Properties;

namespace idk
{
    public partial class Form1 : Form
    {
        public string gamePath;
        public Form1()
        {
            InitializeComponent();
            Settings.Default.Reload();
            if (Settings.Default.GamePathValue != "")
            {
                textBox1.Text = Settings.Default.GamePathValue;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                string localPath = gamePath + "\\BepInEx/Plugins/WhoIsThatMonke.dll";
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://raw.githubusercontent.com/Bleesy1/Every-HanSolo1000Falcon-Mod/main/WhoIsThatMonke.dll",
                    @localPath);
            }
            if (checkBox2.Checked)
            {
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                string localPath = gamePath + "\\BepInEx/Plugins/longArms.dll";
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://raw.githubusercontent.com/Bleesy1/Every-hansolo1000falcon-mod/main/LongArms.dll",
                    @localPath);
            }
            if (checkBox3.Checked)
            {
                System.Diagnostics.Debug.WriteLine(gamePath);
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                string localPath = gamePath + "\\BepInEx/Plugins/VelocityPlatforms.dll";
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://raw.githubusercontent.com/Bleesy1/Every-hansolo1000falcon-mod/main/VelocityPlatforms.dll",
                    @localPath);
            }
            if (checkBox5.Checked)
            {
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                string localPath = gamePath + "\\BepInEx/Plugins/Utilla.dll";
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://raw.githubusercontent.com/Bleesy1/Utilla-for-mod-manager/main/Utilla.dll",
                    @localPath);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Application.Exit();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gamePath = textBox1.Text;
            Settings.Default.GamePathValue = gamePath;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = ("https://github.com/The-Graze/WhoIsTalking/releases/latest"), UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = ("https://github.com/HuskyGT/Banana-OS/releases/latest"), UseShellExecute = true });
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
