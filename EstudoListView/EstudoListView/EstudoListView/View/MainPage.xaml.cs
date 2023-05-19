using Xamarin.Forms;
using EstudoListView.ViewModel;
using EstudoListView.Models;

namespace EstudoListView.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GatosViewModel();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
