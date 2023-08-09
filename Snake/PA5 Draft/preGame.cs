using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class preGame : Form
    {
        
        public int val { get; set; }
        
        public preGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val = (int)numericUpDown1.Value;
        }



    }
}
