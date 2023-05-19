using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using EstudoEntrys;
using System.Xml.Linq;

namespace EstudoEntrys
{
    public partial class MainPage : ContentPage
    {

        private Usuario user;
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            user = new Usuario 
            { 
                Name = "John Doe",
                LastName = lastName.Text,
                Email = email.Text,
                Telephone  = telephone.Text,
                Address = address.Text           
            };
         

            Navigation.PushAsync(new Page2(user));
        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine(e.NewTextValue);
        }
    }
}
