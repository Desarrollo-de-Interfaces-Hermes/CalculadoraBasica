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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Boolean Operadores()
        {
            if (SignoTextBox.Text == "+" || SignoTextBox.Text == "-" || SignoTextBox.Text == "*" || SignoTextBox.Text == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CalculaBoton_Click(object sender, RoutedEventArgs e)
        {
            if (Operadores())
            {
                CalculaBoton.IsEnabled = true;
                Operacion();
            }
        }

        private void Operacion()
        {
            try
            {
                int numero1 = int.Parse
                (Numero1TextBox.Text);

                int numero2 = int.Parse
                (Numero1TextBox.Text);

                int resultado = 0;

                if (SignoTextBox.Text == "+")
                {
                    resultado = numero1 + numero2;
                }
                else if (SignoTextBox.Text == "-")
                {
                    resultado = numero1 - numero2;
                }
                else if (SignoTextBox.Text == "*")
                {
                    resultado = numero1 * numero2;
                }
                else if (SignoTextBox.Text == "/")
                {
                    resultado = numero1 / numero2;
                }
                ResultadoTextBox.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Se ha producido un error, revise los operandos");
            }
        }

        private void LimpiaBoton_Click(object sender, RoutedEventArgs e)
        {
            Numero1TextBox.Text = "";
            Numero2TextBox.Text = "";
            SignoTextBox.Text = "";
            ResultadoTextBox.Text = "";
        }
    }
}
