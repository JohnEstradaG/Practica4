using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        public Double Numero1;
        public Double Numero2;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Uno_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "1";
        }

        private void Dos_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "2";
        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "3";
        }

        private void Cuatro_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "4";
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "5";
        }

        private void Seis_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "6";
        }

        private void Siete_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "7";
        }

        private void Ocho_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "8";
        }

        private void Nueve_Clicked(object sender, EventArgs e)
        {
            Display1.Text = Display1.Text + "9";
        }

        private void Cero_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "") {

            }
            else
            {
                Display1.Text = Display1.Text + "0";
            }
        }

        private void Punto_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text.Contains("."))
            {

            }
            else
            {
                Display1.Text = Display1.Text + ".";
            }
        }

        private void LimpiarG_Clicked(object sender, EventArgs e)
        {
            Display1.Text = "";
            Display2.Text = "";
            DisplayOp.Text = "";
        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            Display1.Text = "";
        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "")
            {

            }
            else
            {
                String Cadena = Display1.Text;
                Display1.Text = Cadena.Substring(0, Cadena.Length - 1);
            }
        }

        private void Mas_Clicked(object sender, EventArgs e)
        {
            if (Display2.Text == "")
            {
                Numero1 = Convert.ToDouble(Display1.Text);
                Display2.Text = Convert.ToString(Numero1);
                Display1.Text = "";
                DisplayOp.Text = "+";
            }
            else
            {
                if (Display1.Text == "")
                {

                    if (DisplayOp.Text.Contains("-"))
                    {
                        DisplayOp.Text = "+";
                    }
                    if (DisplayOp.Text.Contains("*"))
                    {
                        DisplayOp.Text = "+";
                    }
                    if (DisplayOp.Text.Contains("/"))
                    {
                        DisplayOp.Text = "+";
                    }
                }
                else
                {
                    if (DisplayOp.Text.Contains("+"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display1.Text = "";
                        Display2.Text = Convert.ToString(Numero2 + Numero1);
                        DisplayOp.Text = "+";
                    }

                }
            }
        }

        private void Resta_Clicked(object sender, EventArgs e)
        {
            if (Display2.Text == "")
            {

                Numero1 = Convert.ToDouble(Display1.Text);
                Display2.Text = Convert.ToString(Numero1);
                DisplayOp.Text = "-";
                Display1.Text = "";
            }
            else
            {
                if (Display1.Text == "")
                {
                    if (DisplayOp.Text.Contains("+"))
                    {
                        DisplayOp.Text = "-";
                    }
                    if (DisplayOp.Text.Contains("*"))
                    {
                        DisplayOp.Text = "-";
                    }
                    if (DisplayOp.Text.Contains("/"))
                    {
                        DisplayOp.Text = "-";
                    }

                }
                else
                {

                    if (DisplayOp.Text.Contains("-"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display1.Text = "";
                        Display2.Text = Convert.ToString(Numero2 - Numero1);
                        DisplayOp.Text = "-";


                    }

                }
            }
        }

        private void Por_Clicked(object sender, EventArgs e)
        {
            if (Display2.Text == "")
            {

                Numero1 = Convert.ToDouble(Display1.Text);
                Display2.Text = Convert.ToString(Numero1);
                DisplayOp.Text = "*";
                Display1.Text = "";
            }
            else
            {
                if (Display1.Text == "")
                {
                    if (DisplayOp.Text.Contains("+"))
                    {
                        DisplayOp.Text = "*";
                    }
                    if (DisplayOp.Text.Contains("-"))
                    {
                        DisplayOp.Text = "*";
                    }
                    if (DisplayOp.Text.Contains("/"))
                    {
                        DisplayOp.Text = "*";
                    }

                }
                else
                {
                    if (DisplayOp.Text.Contains("*"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display1.Text = "";
                        Display2.Text = Convert.ToString(Numero1 * Numero2);
                        DisplayOp.Text = "*";


                    }

                }
            }
        }

        private void Entre_Clicked(object sender, EventArgs e)
        {
            if (Display2.Text == "")
            {

                Numero1 = Convert.ToDouble(Display1.Text);
                Display2.Text = Convert.ToString(Numero1);
                DisplayOp.Text = "/";
                Display1.Text = "";
            }
            else
            {
                if (Display1.Text == "")
                {
                    if (DisplayOp.Text.Contains("+"))
                    {
                        DisplayOp.Text = "/";
                    }
                    if (DisplayOp.Text.Contains("-"))
                    {
                        DisplayOp.Text = "/";
                    }
                    if (DisplayOp.Text.Contains("*"))
                    {
                        DisplayOp.Text = "/";
                    }

                }
                else
                {
                    if (DisplayOp.Text.Contains("/"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display1.Text = "";
                        Display2.Text = Convert.ToString(Numero2 / Numero1);
                        DisplayOp.Text = "/";


                    }

                }
            }
        }

        private void MasMenos_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "")
            {
                Display1.Text = "-";
            }
            else
            {

                if (Display1.Text == "-")
                {
                    Display1.Text = "";
                }
                else
                {
                    Numero1 = Convert.ToDouble(Display1.Text);
                    Numero2 = -1;
                    Display1.Text = Convert.ToString(Numero2 * Numero1);
                }
            }
        }

        private void Igual_Clicked(object sender, EventArgs e)
        {
            if (DisplayOp.Text == "")
            {

            }
            else
            {
                if (Display1.Text == "")
                {


                }
                else
                {
                    if (DisplayOp.Text.Contains("+"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display2.Text = "";
                        Display1.Text = Convert.ToString(Numero2 + Numero1);
                        DisplayOp.Text = "";
                    }

                    if (DisplayOp.Text.Contains("-"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display2.Text = "";
                        Display1.Text = Convert.ToString(Numero2 - Numero1);
                        DisplayOp.Text = "";
                    }
                    if (DisplayOp.Text.Contains("*"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display2.Text = "";
                        Display1.Text = Convert.ToString(Numero1 * Numero2);
                        DisplayOp.Text = "";


                    }
                    if (DisplayOp.Text.Contains("/"))
                    {

                        Numero1 = Convert.ToDouble(Display1.Text);
                        Numero2 = Convert.ToDouble(Display2.Text);
                        Display2.Text = "";
                        Display1.Text = Convert.ToString(Numero2 / Numero1);
                        DisplayOp.Text = "";


                    }
                }
            }
        }

        private void Potencia_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "")
            {
            }
            else
            {
                Numero1 = Convert.ToDouble(Display1.Text);
                Numero2 = Math.Pow(Numero1, 2);
                Display1.Text = Convert.ToString(Numero2);
            }

        }

        private void sobre1_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "")
            {

            }
            else
            {
                Numero1 = Convert.ToDouble(Display1.Text);
                Numero2 = 1;
                Display1.Text = Convert.ToString(Numero2 / Numero1);
            }
        }

        private void Raiz_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "")
            {


            }
            else
            {
                Numero1 = Convert.ToDouble(Display1.Text);
                Numero2 = Math.Sqrt(Numero1);
                Display1.Text = Convert.ToString(Numero2);

            }
        }

        private void Porciento_Clicked(object sender, EventArgs e)
        {
            if (Display1.Text == "")
            {

            }
            else
            {

                if (Display2.Text == "")
                {

                }
                else
                {
                    Numero1 = Convert.ToDouble(Display2.Text);
                    String cadena = Display1.Text;
                    String Punto = "." + cadena.ToString();
                    Numero2 = Convert.ToDouble(Punto);
                    Display1.Text = Convert.ToString(Numero1 * Numero2);
                }
            }
        }

        private void Master_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterDetailPage1());
        }
    }
}