using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitImagesFromDisk();
            LoadTextFromDisk();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(m_strFileList[m_imageIndex]);
            this.pictureBox1.Show();
            m_imageIndex++;
            if (m_imageIndex >= m_strFileList.Count())
                m_imageIndex = 0;
        }
        void InitImagesFromDisk()
        {
            m_imageIndex = 0;
            m_strFileList = new List<string>();
            m_strFileList.Clear();
            string[] subFiles = Directory.GetFiles("C:\\Users\\hjl\\Pictures\\精美壁纸\\", "*.*", System.IO.SearchOption.AllDirectories);
            foreach (string subFile in subFiles)
            {
                if (subFile.ToLower().EndsWith("bmp") || subFile.ToLower().EndsWith("jpg") || subFile.ToLower().EndsWith("jpeg") || subFile.ToLower().EndsWith("gif") || subFile.ToLower().EndsWith("png"))
                    m_strFileList.Add(subFile);
            }
        }
        void LoadTextFromDisk()
        {
            listBox1.Items.Clear();
            string strOpenFile = "../小记.txt";
            FileStream textFile = File.Open(strOpenFile, FileMode.OpenOrCreate, FileAccess.Read);
            if (textFile.Length == 0)
            {
                textFile.Close();
                return;
            }
            StreamReader sr = new StreamReader(textFile);
            string strReadLine;
            while ((strReadLine = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(strReadLine);
            }
            sr.Close();
            textFile.Close();
            listBox1.Show();
        }
        List<string> m_strFileList;
        int m_imageIndex;

        private void OnTimerColor(object sender, EventArgs e)
        {
            int randColorR, randColorG, randColorB;
            Random rana = new Random();
            randColorR = rana.Next(0, 255);
            randColorG = rana.Next(0, randColorR);
            randColorB = rana.Next(randColorG, 255);
            rectangleShape1.FillColor = Color.FromArgb(randColorR, randColorG, randColorB);
            rectangleShape1.BorderColor = Color.FromArgb(255 - randColorR, 255 - randColorG, 255 - randColorB);
            rectangleShape1.Show();
        }

        private void OnTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // enter键
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            string strSaveFile = "../小记.txt";
            FileStream textFile = File.Open(strSaveFile, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(textFile);
            foreach (string item in listBox1.Items)
            {
                if (item.Length > 0)
                {
                    sw.WriteLine(item);
                    sw.Flush();
                }
            }
            sw.Close();
            textFile.Close();
        }

        private void OnListKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
