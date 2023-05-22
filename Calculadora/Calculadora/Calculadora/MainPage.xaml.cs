using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        int contClick = 0;
        int number1 = 0;
        int number2 = 0;
        string op = "";
        public Calculadora opera;
      
        public MainPage()
        {
            InitializeComponent();
            loadContext();
        }

        private void loadContext()
        {
           if (number1 != 0 || number2 != 0) { 
           result.Text = number1.ToString() + op + number2.ToString();

            }
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            contClick++;
            Button btn = (Button)sender;
            if (contClick % 2 != 0)
            {
                number1 = Convert.ToInt32(btn.Text);
            } else
            {
                number2 = Convert.ToInt32(btn.Text);
            }
        }

        private void btn_ClickedSum(object sender, EventArgs e)
        {
            op = "+";
        }

        private void btn_ClickedDiv(object sender, EventArgs e)
        {
            op = "/";
        }

        private void btn_ClickedMult(object sender, EventArgs e)
        {
            op = "*";
        }

        private void btn_ClickedSub(object sender, EventArgs e)
        {
            op = "-";
        }

        private void btn_ClickedEq(object sender, EventArgs e)
        {
            contClick = 0;
            opera = new Calculadora
            {
                Num1 = number1,
                Num2 = number2,
                Operation = op
            };
            switch (op)
            {
                case "+":
                    result.Text = opera.Sum(number1, number2).ToString();
                    break;
                case "-":
                    result.Text = opera.Sub(number1, number2).ToString();
                    break;
                case "*":
                    result.Text = opera.Multi(number1, number2).ToString();
                    break;
                case "/":
                    result.Text = opera.Div(number1, number2).ToString();
                    break;
            }
        }

        private void btnDel_Clicked(object sender, EventArgs e)
        {
            try
            {
                result.Text = result.Text.Remove(0, 1);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("ja apagaou tudo o que tinha");
            }
        }
    }
}
