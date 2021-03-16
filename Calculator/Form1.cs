using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Plus;

        public event EventHandler Subtraction;

        public event EventHandler Multiply;

        public event EventHandler Divine;

        private void button10_Click(object sender, EventArgs e)
        {
            Plus(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Subtraction(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Multiply(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Divine(sender, e);
        }

    }
}
