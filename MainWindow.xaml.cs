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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int n;
        public MainWindow()
        {
            InitializeComponent();
            n = GeneraNumero();
        }
        private void Comprobar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (n == int.Parse(Numero_TextBox.Text))
                Resultado_TextBlock.Text = "Felicidades, has acertado el número " + int.Parse(Numero_TextBox.Text);
            else if (n > int.Parse(Numero_TextBox.Text))
                Resultado_TextBlock.Text = "El número a adivinar es MAYOR a " + int.Parse(Numero_TextBox.Text);
            else if (n < int.Parse(Numero_TextBox.Text))
                Resultado_TextBlock.Text = "El número a adivinar es MENOR a " + int.Parse(Numero_TextBox.Text);
            else
                Resultado_TextBlock.Text = "Entrada no válida";
        }
        private static int GeneraNumero() => (new Random()).Next(0, 101);
        private void Reiniciar_Button_Click(object sender, RoutedEventArgs e)
        {
            Numero_TextBox.Text = Resultado_TextBlock.Text = "";
            n = GeneraNumero();
        }
    }
}
