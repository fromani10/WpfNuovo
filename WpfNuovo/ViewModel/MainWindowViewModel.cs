using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WpfNuovo.Controller;

namespace WpfNuovo.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void PropChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        private int _risultato;

        public int Risultato
        {
            get { return _risultato; }
            set { _risultato = value; PropChanged("Risultato"); }
        }
        public async Task Calcola()
        {


            Risultato = await NumeriPrimiController.CalcoloAsincrono(10000000);
            



        }



    }
}
