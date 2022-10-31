using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tema4_Superheroes.Modelo;

namespace Tema4_Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int contador;
        List<Superheroe> superheroes;
        public MainWindow()
        {
            InitializeComponent();
            contador = 1;
            superheroes = Superheroe.GetSamples();
            countTextBlock.Text = contador+"/"+superheroes.Count;
        }
    }
}
