using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler start;
        public event EventHandler stop;
        public event EventHandler reset;

        private void Start_Click(object sender, EventArgs e)
        {
            start(sender, e);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stop(sender, e);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
