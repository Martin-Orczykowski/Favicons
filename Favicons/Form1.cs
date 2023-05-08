using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Favicons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader(@"D:\web-sites.txt"))
            {
                while(sr.EndOfStream == false)
                {
                    tbxUrl.Text = sr.ReadToEnd();
                }
            }
        }

        private async void btnDownloadIcons_Click(object sender, EventArgs e)
        {
            string[] websites = tbxUrl.Lines;

            WebClient webClient = new WebClient();

            foreach(string site in websites)
            {
                byte[] bytes = await webClient.DownloadDataTaskAsync(new Uri(site + "/favicon.ico"));
                MemoryStream ms = new MemoryStream(bytes);
                PictureBox pictureBox = new PictureBox();
                flpIcons.Controls.Add(pictureBox);
                pictureBox.Size = new System.Drawing.Size(50, 50);
                pictureBox.Image = Image.FromStream(ms);

            }
        }
    }
}
