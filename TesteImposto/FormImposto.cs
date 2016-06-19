using Imposto.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Core.Domain;
using TesteImposto.Properties;
using CodeX.Windows.Forms;

namespace TesteImposto
{
    public partial class FormImposto : RichForm
    {
        public readonly Pedido Pedido = new Pedido();

        public DataTable DataSource { get; private set; }

        public delegate void DelegateAtulizarProgressBar(string mensagem, int value);
        public delegate void DelegatePropiedadePedidos();
        public event DelegatePropiedadePedidos EventPropiedadePedidos;

        public FormImposto()
        {

            InitializeComponent();
            dataGridViewPedidos.AutoGenerateColumns = true;                       
            CarregarCombos();
            ProcessarNota = new ProcessarNota(this, OnAtulizarProgressBar);
            EventPropiedadePedidos += new DelegatePropiedadePedidos(CarregarPropiedadesPedido);
            GetTablePedidos();
            AutoApplytThemeToControls = true; //Applies theme to all the controls as a Whole
            ApplyThemeFromConfiguration("MetroBlue");
            Title.Text = "Gerador de Notas Fiscais";
        }

        #region Private Events
        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            if (ValidarProcessamento()) return;

            var t = new Thread(new ThreadStart(GerarNotaFiscal));
            t.Start();
        }
        protected virtual void OnAtulizarProgressBar(string mensagem, int value)
        {
            this.Invoke(new DelegateAtulizarProgressBar(OnEventAtualizarStatus), mensagem, value);
        }

        protected virtual void OnEventAtualizarStatus(string mensagem, int value)
        {
            labelMsg.Text = mensagem;
            progressBarCalcular.Value++;
        }
        #endregion

        private void CarregarCombos()
        {
            comboBoxEstadoDestino.DataSource = new Estado().GerarEstado();
            comboBoxEstadoDestino.DisplayMember = "Descricao";
            comboBoxEstadoDestino.ValueMember = "Uf";


            comboBoxEstadoOrigem.DataSource = new Estado().GerarEstado();
            comboBoxEstadoOrigem.DisplayMember = "Descricao";
            comboBoxEstadoOrigem.ValueMember = "Uf";


            comboBoxEstadoOrigem.SelectedIndex = -1;
            comboBoxEstadoDestino.SelectedIndex = -1;
        }

        private void GetTablePedidos()
        {
            var table = new DataTable("pedidos");
            table.Columns.Add(new DataColumn("Nome do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Codigo do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Valor", typeof(decimal)));
            table.Columns.Add(new DataColumn("Brinde", typeof(bool)));

            dataGridViewPedidos.DataSource = table;
        }

        private void GerarNotaFiscal()
        {

            var caminhoxml = TesteImposto.Properties.Settings.Default["caminhoxml"].ToString();

            var service = new NotaFiscalService(caminhoxml);

            this.Invoke(EventPropiedadePedidos);
            ProcessarNota.AdicionarPedidos(DataSource);

            var result = service.GerarNotaFiscal(Pedido);

            MessageBox.Show(result
                ? "Operação efetuada com sucesso"
                : "Não foi possivel realizar esta operação");


            if (result)
            {
                comboBoxEstadoOrigem.SelectedIndex = -1;
                comboBoxEstadoDestino.SelectedIndex = -1;

                textBoxNomeCliente.Text = "";
            }
        }

        private void CarregarPropiedadesPedido()
        {
            DataSource = (DataTable)dataGridViewPedidos.DataSource;
            progressBarCalcular.Maximum = DataSource.Rows.Count;
         //   progressBarCalcular.Value = -1;
            Pedido.EstadoOrigem = comboBoxEstadoDestino.SelectedValue.ToString();
            Pedido.EstadoDestino = comboBoxEstadoDestino.SelectedValue.ToString();
            Pedido.NomeCliente = textBoxNomeCliente.Text;
            
        }

        private bool ValidarProcessamento()
        {
            if (string.IsNullOrEmpty(comboBoxEstadoDestino.SelectedValue.ToString()))
            {
                MessageBox.Show(Resources.FormImposto_buttonGerarNotaFiscal_Click_Informe_o_Origem);
                return true;
            }

            if (string.IsNullOrEmpty(comboBoxEstadoDestino.SelectedValue.ToString()))
            {
                MessageBox.Show(Resources.FormImposto_buttonGerarNotaFiscal_Click_Informe_o_Destino);
                return true;
            }

            if (!string.IsNullOrEmpty(textBoxNomeCliente.Text)) return false;
            MessageBox.Show(Resources.FormImposto_buttonGerarNotaFiscal_Click_Informe_o_Cliente);
            return true;
        }

      
    }
}
