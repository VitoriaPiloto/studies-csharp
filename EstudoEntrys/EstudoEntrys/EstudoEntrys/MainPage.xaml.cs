using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using EstudoEntrys;

namespace EstudoEntrys
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(Nome.ToString());
            Navigation.PushAsync(new Page2());

        }
    }
}
