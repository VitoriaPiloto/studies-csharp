using Xamarin.Forms;
using EstudoListView.ViewModel;
using EstudoListView.Models;
using System;

namespace EstudoListView.View
{
    public partial class MainPage : ContentPage
    {
            int tapCount = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GatosViewModel();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Console.WriteLine(tapCount++);
        }
    }
}
