using System;
using System.Globalization;
using System.Windows.Forms;

namespace CotacaoPedido
{
    public partial class FormCadastro : Form
    {
        public Item item { get; set; }
        private Util util = new Util();

        public FormCadastro(Item item)
        {
            InitializeComponent();

            this.item = item;

            PreencherControles();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int posX = (screenWidth - formWidth) / 2;
            int posY = (screenHeight - formHeight) / 2;

            this.SetBounds(posX, posY, formWidth, formHeight);

        }

        private void PreencherControles()
        {
            if (item != null)
            {
                txtCodigo.Text = item.Id.ToString();
                txtDescricao.Text = item.Descricao;
                txtQuantidade.Text = item.Quantidade.ToString();
                txtValor.Text = item.Valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
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

            string id = txtCodigo.Text;


            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                id = util.gerarId(6);
            } 

            item = new Item
            {
                Id = Convert.ToInt32(id),
                Descricao = txtDescricao.Text,
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                Valor = Convert.ToDecimal(util.normalizeDouble(txtValor.Text))
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidarCampos()
        {
            return true;
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            util.setCursorEnd(txtValor);
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            util.txtLimparFormatacao(txtValor);
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            util.txtLimparFormatacao(txtValor);
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            util.txtLimparFormatacao(txtValor);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            util.txtFormatarMoeda(txtValor);
        }

    }
}
