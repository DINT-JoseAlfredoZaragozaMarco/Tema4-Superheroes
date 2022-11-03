using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema4_Superheroes.Modelo;

namespace Tema4_Superheroes.VistasModelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Superheroe personajeActual;
        private List<Superheroe> superheroes = Superheroe.GetSamples();

        public Superheroe Personaje
        {
            get { return personajeActual; }
            set 
            {
                personajeActual = value;
                this.NotifyPropertyChanged("Personaje");
            }
        }

        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set 
            { 
                posicion = value;
                this.NotifyPropertyChanged("Posicion");
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set 
            { 
                total = value;
                this.NotifyPropertyChanged("Total");
            }
        }

        public MainWindowVM()
        {
            Personaje = superheroes[0];
            Posicion = 1;
            Total = superheroes.Count;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string v)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public void Avanzar()
        {
            if(Posicion < Total)
            Posicion++;
            Personaje = superheroes[Posicion-1];
        }

        public void Retroceder()
        {
            if(Posicion > 0)
            Posicion--;
            Personaje = superheroes[Posicion - 1];
        }

    }
}
