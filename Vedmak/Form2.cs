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
    public partial class Form2 : Form
    {
        Model1 controller=new Model1();
       
      
        public Form2(Personage selected)
        {         
            InitializeComponent();
          this.Text= selected.NAME.ToString();
            HashUserControl hashUserControl = new HashUserControl(selected);
            hashUserControl.Location = new Point(330, 5);
            this.Controls.Add(hashUserControl);

            this.label12.Text = selected.NAME.ToString();
            this.label1.Text=selected.Subscribe.ToString();

        
            ListInfo item = controller.ListInfoes.ToList().Where(x => x.PersonageID == selected.ID).FirstOrDefault();

            InfoUserControl infoUserControl1 = new InfoUserControl(item.Title1.ToString(), item.Subscrib1.ToString());
            InfoUserControl infoUserControl2 = new InfoUserControl(item.Title2.ToString(), item.Subscrib2.ToString());
            InfoUserControl infoUserControl3 = new InfoUserControl(item.Title3.ToString(), item.Subscribe3.ToString());
            InfoUserControl infoUserControl4 = new InfoUserControl(item.Title4.ToString(), item.Subscribe4.ToString());

            List<InfoUserControl>list = new List<InfoUserControl>();    
            list.Add(infoUserControl1);
            list.Add(infoUserControl2);
            list.Add(infoUserControl3); 
            list.Add(infoUserControl4);
            int h = 0;
            foreach (var iter in list)
            {

                iter.Location = new Point(0, h);
                this.panel1.Controls.Add(iter);
                h += iter.Size.Height + 15;
            }


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
