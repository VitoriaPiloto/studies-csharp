using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EstudoEntrys;

namespace EstudoEntrys
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private Usuario user;

        public Page2(Usuario user)
        {
            InitializeComponent();

            this.user = user;
            LoadContent();
        }

        private void LoadContent()
        {
            name.Text = user.Name;
            lastName.Text = user.LastName;
            telephone.Text = user.Telephone;
            email.Text = user.Email;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingSample(user));
        }
    }
}