using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Presenter
    {
        private readonly Form1 view;
        Model model;

        public Presenter(Form1 form1)
        {
            model = new Model();
            view = form1;

            view.start += View_Start;
            view.stop += View_Stop;
            view.reset += View_Reset;
            view.timer1.Tick += TimerTick;
            view.timer1.Start();
            view.timer1.Enabled = false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.textBox1.Text = model.Time();
        }

        private void View_Reset(object sender, EventArgs e)
        {
            model.s = 0;
            view.timer1.Stop();
            view.textBox1.Text = "0";
        }

        private void View_Stop(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.timer1.Enabled = false;
        }

        private void View_Start(object sender, EventArgs e)
        {
            view.timer1.Start();
            view.timer1.Enabled = true;
        }
    }
}
