using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect
{
    public partial class PTabPage : TabPage
    {
        public PDraw pdraw;
        public string path = null;
        public PTabPage(XCommand cmd)
        {
            InitializeComponent();
            pdraw = new PDraw();
            pdraw.cmd = cmd;
            Controls.Add(pdraw);
        }
    }
}
