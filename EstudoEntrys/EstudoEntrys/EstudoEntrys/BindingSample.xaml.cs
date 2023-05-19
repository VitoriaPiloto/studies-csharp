using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoEntrys
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingSample : ContentPage
    {
        private Usuario user;

        public BindingSample(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            
            user = new Usuario
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Telephone = user.Telephone,
                Address = user.Address,
                ColorText = "#ff0000"
            };

            BindingContext = user;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}