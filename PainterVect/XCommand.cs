﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterVect
{
    public class XCommand
    {
        public XData data { get; private set; } = new XData();
        public XText text { get; private set; } = new XText();
        public PTabControl tabControl;


        public void setType(object sender, EventArgs e, string type)
        {
            switch (type)
            {
                case "Rectangle": { data.type = FigureDrawing.Rectangle; break; }
                case "Ellipse": { data.type = FigureDrawing.Ellipse; break; }
                case "RoundRectangle": { data.type = FigureDrawing.RoundRectangle; break; }
                case "Line": { data.type = FigureDrawing.Line; break; }
                case "Pencil": { data.type = FigureDrawing.Pencil; break; }
                default: break;
            }
        }

        public void setWidth(object sender, EventArgs e, string lineWidth)
        {
            data.lineWidth = int.Parse(lineWidth);
        }

        public void setColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                data.color = dlgColor.Color;
            }
        }

        public void saveFigures(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml", "BIN (*.bin)|*.bin", "CSV (*.csv)|*.csv" };
            dlgSave.Filter = String.Join("|", ext);
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                PTabPage activeTab = tabControl.SelectedTab as PTabPage;
                SOFactory.GetInstance(dlgSave.FileName).Save(activeTab.pdraw.Figures);
                activeTab.path = dlgSave.FileName;
                activeTab.Name = Path.GetFileName(activeTab.path);
                activeTab.Text = Path.GetFileName(activeTab.path);
            }
        }

        public void openFigures(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            string ext = "SO (*.json; *.xml; *.yaml; *.bin; *.csv)| *.json; *.xml; *.yaml; *.bin; *.csv";
            dlgOpen.Filter = ext;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                PTabPage activeTab = tabControl.SelectedTab as PTabPage;
                activeTab.pdraw.Figures = SOFactory.GetInstance(dlgOpen.FileName).Open();
                activeTab.pdraw.Redraw();
                activeTab.Name = Path.GetFileName(dlgOpen.FileName);
                activeTab.Text = Path.GetFileName(dlgOpen.FileName);
            }
        }


        public void setTextColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                text.textColor = dlgColor.Color;
            }
        }

        public void setTextFont(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                text.textFont = dlg.Font;
            }
        }

        public void setTextAngle(object sender, EventArgs e, int angle)
        {
            text.textAngle = angle;
        }

        public void setText(object sender, EventArgs e, string text)
        {
            this.text.textString = text;
        }

        public void setVerticalAlign(object sender, EventArgs e, string align)
        {
            switch (align)
            {
                case "Center": { text.verticalAlign = StringAlignment.Center; break; }
                case "Near": { text.verticalAlign = StringAlignment.Near; break; }
                case "Far": { text.verticalAlign = StringAlignment.Far; break; }
                default: break;
            }
        }

        public void setHorizontalAlign(object sender, EventArgs e, string align)
        {
            switch (align)
            {
                case "Center": { text.horizontalAlign = StringAlignment.Center; break; }
                case "Near": { text.horizontalAlign = StringAlignment.Near; break; }
                case "Far": { text.horizontalAlign = StringAlignment.Far; break; }
                default: break;
            }
        }

        public delegate void setCoords(Point p);
        public event setCoords onCoordsChanged;

        public void coordsChangedHandler(Point p)
        {
            onCoordsChanged(p);
        }


        public delegate void createTab(string tabName);
        public event createTab onCreateTab;

        public void createNewTab(object sender, EventArgs e)
        {
            PTabPage tab = new PTabPage(this);
            tab.Name = "New " + tabControl.tabsCount;
            tab.Text = "New " + tabControl.tabsCount;

            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tab);

            onCreateTab(tab.Name);
        }

        public void menuTabsItem_Selected(object sender, EventArgs e)
        {
            tabControl.SelectTab(sender.ToString());
        }

        public void closeTab(object sender, EventArgs e)
        {
            (sender as MainMenu).tabsToolStripMenuItem.DropDownItems.RemoveByKey(tabControl.SelectedTab.Name);
            tabControl.SelectedTab.Dispose();
        }
    }
}
