using System;
using System.Windows.Forms;

namespace CotacaoPedido
{
    public partial class CadastroForm : Form
    {
        public Item item { get; set; }

        public CadastroForm(Item item)
        {
            InitializeComponent();

            this.item = item;

            PreencherControles();
        }

        private void PreencherControles()
        {
            if (item != null)
            {
                txtCodigo.Text = item.Id.ToString();
                txtDescricao.Text = item.Descricao;
                txtQuantidade.Text = item.Quantidade.ToString();
                txtValor.Text = item.Valor.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            item = new Item
            {
                Id = Convert.ToInt32(txtCodigo.Text),
                Descricao = txtDescricao.Text,
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                Valor = Convert.ToDecimal(txtValor.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarCampos()
        {
            return true;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            // Adicione o código que deseja executar quando o formulário for carregado aqui
        }
    }
}
