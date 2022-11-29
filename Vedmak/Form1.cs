using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedmak
{
    public partial class Form1 : Form
    {
        Model1 Vedmak_dbo = new Model1();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int x = 81;
            foreach (var item in Vedmak_dbo.Chapters)
            {
                Button button1 = new Button();
                button1.Text = item.NAME.ToString();
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Maroon;
                button1.Click += Button1_Click;
                button1.Size = new Size(179, 34);
                button1.Font = new Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                button1.Location = new Point(65, x);
                this.panel1.Controls.Add(button1);

                x += button1.Size.Height + 5;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int INDX = Vedmak_dbo.Chapters.ToList().Where(x => x.NAME == (sender as Button).Text).FirstOrDefault().ID;
            int h = 0;

            var list = Vedmak_dbo.Personages.Where(x => x.ChapterID == INDX);
            this.panel2.Controls.Clear();




            foreach (var item in list)
            {
                DescriptionUserControl temp = new DescriptionUserControl(item.NAME.ToString(), item.PictureURL.ToString());
                temp.Name = INDX.ToString();
                temp.pictureBox1.Click += Temp_Click;
                temp.pictureBox1.Name= item.ID.ToString();
                temp.Location = new Point(0, h);
                this.panel2.Controls.Add(temp);
                h += temp.Size.Height + 15;
            }
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            int INDX = Convert.ToInt32((sender as PictureBox).Name.ToString());
            Personage clicked = Vedmak_dbo.Personages.Where(x => x.ID == INDX).FirstOrDefault();
            Form2 form2 = new Form2(clicked);
            form2.Show();
        }
    }
    }
