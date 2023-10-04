using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        //LLAMAR A OPERACIONES
        Models.Operaciones operations = new Models.Operaciones();
        public Decimal num1=0;
        public Decimal num2=0;
        public Decimal rest=0;
        public MainPage()
        {
            InitializeComponent();  
        }
        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            if (txtnum.Text != null && txtnum2.Text != null)
            {
                num1 = Convert.ToDecimal(txtnum.Text);
                num2 = Convert.ToDecimal(txtnum2.Text);
                if (num1 <= 0 || num2 <= 0)
                {
                    await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK");
                }
                else
                {
                    rest = operations.addition(num1, num2);

                    await Navigation.PushAsync(new SecondPage(rest));
                }
            }
            else { await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK"); }
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            if (txtnum.Text != null && txtnum2.Text != null)
            {
                num1 = Convert.ToDecimal(txtnum.Text);
                num2 = Convert.ToDecimal(txtnum2.Text);
                if (num1 <= 0 || num2 <= 0)
                {
                    await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK");
                }
                else
                {
                    rest = operations.substraction(num1, num2);
                    if (rest < 0) { rest = 0; }

                    await Navigation.PushAsync(new SecondPage(rest));
                }
            }
            else { await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK"); }
        }

        private async void btnmulti_Clicked(object sender, EventArgs e)
        {
            if (txtnum.Text != null && txtnum2.Text != null)
            {
                num1 = Convert.ToDecimal(txtnum.Text);
                num2 = Convert.ToDecimal(txtnum2.Text);
                if (num1 <= 0 || num2 <= 0)
                {
                    await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK");
                }
                else
                {
                    rest = operations.multiplication(num1, num2);

                    await Navigation.PushAsync(new SecondPage(rest));
                }
            }
            else { await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK"); }
        }

        private async void btndiv_Clicked(object sender, EventArgs e)
        {
            if (txtnum.Text != null && txtnum2.Text != null)
            {
                num1 = Convert.ToDecimal(txtnum.Text);
                num2 = Convert.ToDecimal(txtnum2.Text);
                if (num1 <= 0 || num2 <= 0)
                {
                    await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK");
                }
                else
                {
                    rest = operations.division(num1, num2);

                    await Navigation.PushAsync(new SecondPage(rest));
                }
            }
            else { await DisplayAlert("Alerta", "Te falta ingresar un numero", "OK"); }
        }
    }
}
