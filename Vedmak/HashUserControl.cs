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

namespace Vedmak
{
    public partial class HashUserControl : UserControl
    {
        public Personage item { get; set; }
    
        public HashUserControl(Personage selected)
        {
            InitializeComponent();
            item = selected;
            this.label7.Text = item.Sex.ToString();
            this.label8.Text = item.Race.ToString();
            this.label9.Text = item.Occupation.ToString();
            this.label10.Text = item.Affination.ToString();
            this.label11.Text = item.Alive.ToString();
            this.label12.Text = item.NAME.ToString();
            this.pictureBox1.Image=GetImage(item.PictureURL.ToString());

        }
        private Image GetImage(string url)
        {
            var request = WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }
    }
}
