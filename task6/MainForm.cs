using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task6_15
{
    public partial class MainForm : Form
    {
        BindingList<DrawingNotebook> notebooksSource = new BindingList<DrawingNotebook>();

        public MainForm()
        {
            InitializeComponent();
            notebooks.AutoGenerateColumns = true;
            notebooks.DataSource = notebooksSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notebook = new DrawingNotebook { 
                Colour = colourBox.Text,
                Quality = qualityBox.Text, 
                CoverColour = coverColourBox.Text, 
                Type = typeBox.Text, 
                Orientation = orientationBox.Text,
                HasExamples = yesChoice.Checked
            };

            notebooksSource.Add(notebook);

            colourBox.Text = qualityBox.Text = coverColourBox.Text = typeBox.Text = orientationBox.Text = "";

            yesChoice.Checked = false;
            noChoice.Checked = true;
        }
    }
}
