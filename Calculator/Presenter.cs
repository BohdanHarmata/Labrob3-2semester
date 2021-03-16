using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Presenter
    {
        private readonly Form1 view;

        Model model;

        

        public Presenter(Form1 form)
        {
            model = new Model();
            view = form;

            view.Plus += View_Plus;
            view.Subtraction += View_Sub;
            view.Multiply += View_Mult;
            view.Divine += View_Div;
        }

        private void View_Plus(object sender, EventArgs e)
        {
            view.Result.Text = Convert.ToString(model.Plus(Convert.ToInt32(view.textBox1.Text), Convert.ToInt32(view.textBox2.Text)));
        }

        private void View_Sub(object sender, EventArgs e)
        {
            view.Result.Text = Convert.ToString(model.Sub(Convert.ToInt32(view.textBox1.Text), Convert.ToInt32(view.textBox2.Text)));
        }

        private void View_Mult(object sender, EventArgs e)
        {
            view.Result.Text = Convert.ToString(model.Mul(Convert.ToInt32(view.textBox1.Text), Convert.ToInt32(view.textBox2.Text)));
        }

        private void View_Div(object sender, EventArgs e)
        {
            view.Result.Text = Convert.ToString(model.Div(Convert.ToInt32(view.textBox1.Text), Convert.ToInt32(view.textBox2.Text)));
        }
    }
}
