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
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Presionar_Clicked(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Nombre.Text))
            {
                DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
            }
            else
            {
                if (String.IsNullOrEmpty(Ape_pat.Text)) {

                    DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                }
                else {
                    if (String.IsNullOrEmpty(Ape_mat.Text)) {
                        DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                    }
                    else {
                        if (String.IsNullOrEmpty(Direccion.Text)) {
                            DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                        }
                        else {
                            if (String.IsNullOrEmpty(Telefono.Text)) {
                                DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                            }
                            else {
                                if (String.IsNullOrEmpty(Carrera.Text))
                                {
                                    DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                                }
                                else {
                                    if (String.IsNullOrEmpty(Semestre.Text))
                                    {
                                        DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                                    }
                                    else {
                                        if (String.IsNullOrEmpty(Matricula.Text)) {
                                            DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                                        }
                                        else {
                                            if (String.IsNullOrEmpty(Correo.Text))
                                            {
                                                DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                                            }
                                            else {
                                                if (String.IsNullOrEmpty(Github.Text))
                                                {
                                                    DisplayAlert("IMPORTANTE", "Debe de llenar todos los campos", "ok");
                                                }
                                                else {
                                                    DisplayAlert(" " + titulo1.Text, "Hola" + "\n" + "Nombre´s: " + Nombre.Text + "\n" + "Apellido Paterno: " + Ape_pat.Text + "\n" + "Apellido Materno: " + Ape_mat.Text + "\n" + "Fecha de Nacimiento: " + Fecha.Date + "\n" + "Direccion: " + Direccion.Text + "\n" + "Telefono: " + Telefono.Text + "\n" + "\n" + titulo2.Text + "\n" + "Carrera: " + Carrera.Text + "\n" + "Semestre: " + Semestre.Text + "\n" + "Matricula: " + Matricula.Text + "\n" + "\n" + titulo3.Text + "\n" + "Correo: " + Correo.Text + "\n" + "Github: " + Github.Text, "ok");
                                                    Navigation.PushAsync(new Calculadora());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}