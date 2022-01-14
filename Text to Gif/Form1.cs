using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
namespace Text_to_Gif
{
    public partial class Form1 : Form
    {
        public string[] words;
        public bool check = true;
        public string sizeX;
        public string sizeY;
        public int x;
        public int y;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(137, 207, 240);
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                Giphy.Hide();
                string link = $"https://api.giphy.com/v1/gifs/search?api_key=EHW8QzWFddimzox00RxDMCx3wzZdjKj4&q={input.Text}&limit=1&offset=0&rating=g&lang=en";
                string json = new WebClient().DownloadString(link);
                JObject o = JObject.Parse(json);

                string gif = (string)o["data"][0]["images"]["original"]["url"];
                sizeX = (string)o["data"][0]["images"]["original"]["height"];
                sizeY = (string)o["data"][0]["images"]["original"]["width"];

                Giphy.ImageLocation = gif;
                x = (this.Width / 2) - (int.Parse(sizeX) / 2);
                y = (this.Height / 2) - (int.Parse(sizeY) / 2);
                Giphy.Location = new Point(x, y);

                Giphy.Show();
                input.Text = "";
            }
            catch
            {
            }
        }
        private void Input_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Generate_Click(this,e);
            }
        }
    }
}
