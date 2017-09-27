﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect.ToolBox
{
    public partial class POpen : UserControl
    {
        public XCommand cmd { get; set; }
        public POpen()
        {
            InitializeComponent();
            btnOpen.Click += new EventHandler((s, e) => cmd.openFigures(s, e));
        }
    }
}
