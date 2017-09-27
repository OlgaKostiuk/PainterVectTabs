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
    public partial class PType : UserControl
    {
        public XCommand cmd { get; set; }

        public PType()
        {
            InitializeComponent();
            Controls.OfType<Button>().ToList().ForEach(x => x.Click += new EventHandler((s,e)=>cmd.setType(s,e,x.Tag.ToString())));
        }
    }
}
