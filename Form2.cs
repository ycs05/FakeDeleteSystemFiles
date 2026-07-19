using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FakeDeleteSystemFiles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            this.Location = Screen.PrimaryScreen.Bounds.Location;
            
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
