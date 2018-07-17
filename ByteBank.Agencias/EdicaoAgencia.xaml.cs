using ByteBank.Agencias.DAL;
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
using System.Windows.Shapes;

namespace ByteBank.Agencias
{
    /// <summary>
    /// Interaction logic for EdicaoAgencia.xaml
    /// </summary>
    public partial class EdicaoAgencia : Window
    {
        private readonly Agencia _agencia;

        public EdicaoAgencia(Agencia agencia)
        {
            InitializeComponent();

            _agencia = agencia ?? throw new ArgumentNullException(nameof(agencia));

            AtualizarCamposDeTexto();
            AtualizarControles();
        }

        private void AtualizarControles()
        {
            var okEventHandler = (RoutedEventHandler)btnOK_Click + Fechar;
            var cancelarEventHandler = (RoutedEventHandler)btnCancelar_Click + Fechar;

            btnOk.Click += okEventHandler;
            btnCancelar.Click += cancelarEventHandler;

            btnOk.Click += new RoutedEventHandler(Fechar);
            btnCancelar.Click += new RoutedEventHandler(Fechar);

        }

        private void btnOK_Click(object sender, RoutedEventArgs e) =>
            DialogResult = true;

        private void btnCancelar_Click(object sender, RoutedEventArgs e) =>
            DialogResult = false;

        private void AtualizarCamposDeTexto()
        {
            txtNumero.Text = _agencia.Numero;
            txtNome.Text = _agencia.Nome;
            txtTelefone.Text = _agencia.Telefone;
            txtEndereco.Text = _agencia.Endereco;
            txtDescricao.Text = _agencia.Descricao;
        }

        private void Fechar(object sender, RoutedEventArgs e) =>
            Close();
    }
}
