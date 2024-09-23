using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.labelFinal.Content = this.txbInicial.Text;
            string textoInvertido = new string(this.txbInicial.Text.Reverse().ToArray());
            this.labelFinal.Content = textoInvertido;
            this.txbInicial.Text = "";
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("¿Estás seguro que quieres resetearlo? No lo podrás volver a recuperar...", "Seguro???????????????????????", MessageBoxButton.YesNo);
            if (message == MessageBoxResult.Yes)
            {
                var respuestaSi1 = MessageBox.Show("¿Seguro pero seguro seguro?", "No sé yo eh...", MessageBoxButton.YesNo);
                if (respuestaSi1 == MessageBoxResult.Yes)
                {
                    var respuestaSi2 = MessageBox.Show("¿Deberías estar más seguro de tus acciones no?", "Pfffff...", MessageBoxButton.YesNo);
                    if (respuestaSi2 == MessageBoxResult.Yes)
                    {
                        var respuestaSiFinal = MessageBox.Show("Bueno vale, pero que sepas que la has cagado...");
                        this.labelFinal.Content = "";
                        this.txbInicial.Text = "";
                    }
                    else
                    {
                        var RespuestaNo = MessageBox.Show("Me da igual, lo voy a resetear igual.");
                        this.labelFinal.Content = "";
                        this.txbInicial.Text = "";
                    }
                }
                else
                {
                    var respuestaNo2 = MessageBox.Show("Me da igual, lo voy a resetear igual.");
                    this.labelFinal.Content = "";
                    this.txbInicial.Text = "";
                }
            }
            else
            {
                var respuestaNo1 = MessageBox.Show("Me da igual, lo voy a resetear igual.");
                this.labelFinal.Content = "";
                this.txbInicial.Text = "";
            }

        }
    }
}
