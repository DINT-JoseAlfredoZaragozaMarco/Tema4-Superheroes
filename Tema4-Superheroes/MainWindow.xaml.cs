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
            contador = 0;
            superheroes = Superheroe.GetSamples();
            countTextBlock.Text = (contador + 1) + "/" + superheroes.Count;
            ContenedorPrincipal_DockPanel.DataContext = superheroes[contador];
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as Image).Tag.Equals("Right"))
            {
                if (contador >= superheroes.Count-1) contador = contador;
                else contador++;
                countTextBlock.Text = (contador + 1) + "/" + superheroes.Count;
                ContenedorPrincipal_DockPanel.DataContext = superheroes[contador];
            }
            else
            {
                if (contador <= 0) contador = contador;
                else contador--;
                countTextBlock.Text = (contador + 1) + "/" + superheroes.Count;
                ContenedorPrincipal_DockPanel.DataContext = superheroes[contador];
            }
        }
    }
}
