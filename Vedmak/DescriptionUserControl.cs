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
using System.Xml.Linq;

namespace Vedmak
{
    public partial class DescriptionUserControl : UserControl
    {
        public DescriptionUserControl( string name ,string img)
        {
            InitializeComponent();
            this.pictureBox1.Image = GetImage(img);
            this.label1.Text = name;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
