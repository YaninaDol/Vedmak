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
    public partial class InfoUserControl : UserControl
    {
        public InfoUserControl(string Title,string info)
        {
            InitializeComponent();
            this.label12.Text = Title;
            this.label1.Text = info;

        }
    }
}
