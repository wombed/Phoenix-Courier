﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixApp
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            //
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Yellow600, Primary.Orange500, Primary.Red200, Accent.Yellow700, TextShade.BLACK);
        }
    }
}
