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
    public partial class PTabControl : TabControl
    {
        public XCommand cmd { get; set; }
        public int tabsCount { get; private set; } = 0;

        public PTabControl()
        {
            InitializeComponent();
            ControlAdded += PTabControl_ControlAdded;
        }

        private void PTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            tabsCount++;
        }
    }
}
