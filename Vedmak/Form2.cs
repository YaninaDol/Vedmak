﻿using System;
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

        public Form2(Personage selected)
        {
            InitializeComponent();
            HashUserControl hashUserControl = new HashUserControl(selected);
            hashUserControl.Location = new Point(50, 5);
            this.Controls.Add(hashUserControl);
        }
    }
}
