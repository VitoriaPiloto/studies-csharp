using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using EstudoListView.Models;
using Xamarin.Forms;

namespace EstudoListView.ViewModel
{
    public class GatosViewModel : INotifyPropertyChanged
    {
        int cont =0;

        public ObservableCollection<Gatos> Gatinhos { get; private set; }

        //Métodos da classe mãe responsável pela inserção, remoção e etc.

        public ICommand SelectionCommand => new Command<Gatos>(SelectedGato);

        private Gatos _selectedListItem;
        public Gatos SelectedListItem
        {
            get { return _selectedListItem; }
            set
            {
                _selectedListItem = value;
                OnPropertyChanged();
            }
        }

        private void SelectedGato(Gatos obj)
        {
            cont++;
            Console.WriteLine(cont);
        }

        //Construtor
        public GatosViewModel()
        {
            Gatinhos = new ObservableCollection<Gatos>();
            CreateGatoCollection();

        }

        void CreateGatoCollection()
        {
            Gatinhos.Add(new Gatos
            {
                Name = "Persa ",
                Location = "Pérsia",
                Details = "Dóceis e tranquilos, os Persas são ótimos companheiros.",
                ImageUrl = "https://static.wikia.nocookie.net/gatopedia/images/e/e9/Gato-persa.jpg/revision/latest?cb=20140429132842&path-prefix=pt-br"
            });

            Gatinhos.Add(new Gatos
            {
                Name = "Birmanês",
                Location = "-",
                Details = "Sociável, apegado ao dono.",
                ImageUrl = "https://static.wikia.nocookie.net/gatopedia/images/1/13/Gato_birman%C3%AAs.jpg/revision/latest?cb=20140518154314&path-prefix=pt-br"
            });

            Gatinhos.Add(new Gatos
            {
                Name = "Siamês",
                Location = "Tailândia",
                Details = "Um gato Siamês é uma companhia ideal para se ter em casa.",
                ImageUrl = "https://static.wikia.nocookie.net/gatopedia/images/3/3a/Gato_Siam%C3%AAs.png/revision/latest/scale-to-width-down/250?cb=20140429132749&path-prefix=pt-br"
            });

            Gatinhos.Add(new Gatos
            {
                Name = "Tonquinês",
                Location = "Canadá e Estados Unidos",
                Details = "Cruzamento entre o siamês e birmanês",
                ImageUrl = "https://static.wikia.nocookie.net/gatopedia/images/8/81/Tonkinese.gif/revision/latest/scale-to-width-down/180?cb=20160606223312&path-prefix=pt-br"
            });

            Gatinhos.Add(new Gatos
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                Details = "The golden lion",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });


        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
