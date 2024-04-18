using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoPedido
{
    public partial class FormLista : Form
    {
        private Util util = new Util();
        private List<Item> itens = new List<Item>();
        private decimal subtotal = 0.0m;
        private CotacaoMoedas cotacaoMoedas = new CotacaoMoedas();
        private JObject cotacaoObject = null;
        private double cotacaoBid = 0;

        public FormLista()
        {
            InitializeComponent();

            gridItens.Columns.Add("Id", "ID");
            gridItens.Columns.Add("Descricao", "Descrição");
            gridItens.Columns.Add("ValorU", "Valor Unidade");
            gridItens.Columns.Add("Quantidade", "Quantidade");
            gridItens.Columns.Add("ValorT", "Valor Total");

            gridItens.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridItens.AllowUserToAddRows = false;
            gridItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridItens.MultiSelect = false;

            foreach (DataGridViewColumn column in gridItens.Columns)
            {
                column.ReadOnly = true;
            }

            carregarItensLista();

            inicializarAsync();

            btnNovo.Click += btnNovoClick;
            btnEditar.Click += btnEditarClick;
            btnExcluir.Click += btnExcluirClick;
            txtFiltro.TextChanged += filtrarItens;
            gridItens.CellFormatting += gridCellFormatting;
        }

        private async Task inicializarAsync()
        {
            await carregarCotacaoObject();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int posX = (screenWidth - formWidth) / 2;
            int posY = (screenHeight - formHeight) / 2;

            this.SetBounds(posX, posY, formWidth, formHeight);

            carregarItensGrid(itens);
        }

        private void btnNovoClick(object sender, EventArgs e)
        {
            FormCadastro addEditForm = new FormCadastro(null);

            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                itens.Add(addEditForm.item);
                carregarItensGrid(itens);
            }
        }

        private void btnEditarClick(object sender, EventArgs e)
        {
            if (gridItens.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(gridItens.SelectedRows[0].Cells["Id"].Value);

                Item itemSelecionado = itens.FirstOrDefault(item => item.Id == idSelecionado);

                if (itemSelecionado != null)
                {
                    FormCadastro addEditForm = new FormCadastro(itemSelecionado);

                    if (addEditForm.ShowDialog() == DialogResult.OK)
                    {
                        itens[itens.FindIndex(item => item.Id == idSelecionado)] = addEditForm.item;
                        carregarItensGrid(itens);
                    }
                }
            }
        }

        private void btnExcluirClick(object sender, EventArgs e)
        {
            if (gridItens.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(gridItens.SelectedRows[0].Cells["Id"].Value);
                int indiceSelecionado = itens.FindIndex(item => item.Id == idSelecionado);

                if (indiceSelecionado != -1)
                {
                    itens.RemoveAt(indiceSelecionado);
                    carregarItensGrid(itens);
                }
            }
        }

        private void filtrarItens(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.ToLower();

            List<Item> itensFiltrados = itens.Where(item => item.Descricao.ToLower().Contains(filtro)).ToList();

            carregarItensGrid(itensFiltrados);
        }

        private void gridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridItens.Columns["ValorU"].DefaultCellStyle.Format = "N2";
            gridItens.Columns["ValorT"].DefaultCellStyle.Format = "N2";

            gridItens.Columns["ValorU"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridItens.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridItens.Columns["ValorT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (gridItens.Columns[e.ColumnIndex].Name == "ValorU" || gridItens.Columns[e.ColumnIndex].Name == "ValorT")
            {
                if (e.Value != null && e.Value != DBNull.Value && Decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                }
            }
        }

        private void carregarItensLista()
        {
            itens.Add(new Item { Id = 954168, Descricao = "placa mãe asus tuf", Valor = 10.00m, Quantidade = 5 });
            itens.Add(new Item { Id = 651681, Descricao = "processador intel core i5-11400f", Valor = 7.25m, Quantidade = 3 });
            itens.Add(new Item { Id = 356138, Descricao = "memoria ram 32gb", Valor = 15.75m, Quantidade = 2 });
            itens.Add(new Item { Id = 412541, Descricao = "ssd 500gb", Valor = 80.0m, Quantidade = 7 });
            itens.Add(new Item { Id = 568413, Descricao = "placa de vídeo nvidia rtx 3080", Valor = 1500.0m, Quantidade = 2 });
            itens.Add(new Item { Id = 158656, Descricao = "monitor ultrawide 34 polegadas", Valor = 600.0m, Quantidade = 4 });
            itens.Add(new Item { Id = 681587, Descricao = "teclado mecânico rgb", Valor = 50.0m, Quantidade = 10 });
            itens.Add(new Item { Id = 548652, Descricao = "mouse sem fio", Valor = 30.0m, Quantidade = 6 });
            itens.Add(new Item { Id = 895429, Descricao = "headset gamer", Valor = 80.0m, Quantidade = 8 });
            itens.Add(new Item { Id = 548664, Descricao = "cadeira gamer", Valor = 200.0m, Quantidade = 3 });
        }

        private void carregarItensGrid(List<Item> itens)
        {
            gridItens.Rows.Clear();
            subtotal = 0.0m;

            foreach (var item in itens)
            {
                decimal valorTotal = item.Quantidade * item.Valor;
                subtotal += valorTotal;
                gridItens.Rows.Add(item.Id, item.Descricao, item.Valor.ToString("N2"), item.Quantidade, valorTotal.ToString("N2"));
            }

            txtSubtotal.Text = subtotal.ToString("N2");

            util.txtLimparFormatacao(txtSubtotal);
            util.txtFormatarMoeda(txtSubtotal);

            calcular();
        }

        private async Task carregarCotacaoObject()
        {
            try
            {
                cotacaoObject = await cotacaoMoedas.getAll();
                await carregarCbxMoedas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as cotações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task carregarCbxMoedas()
        {
            try
            {
                foreach (var moeda in cotacaoObject)
                {
                    string nomeMoedaCompleto = (string)moeda.Value["name"];
                    string[] partes = nomeMoedaCompleto.Split('/');
                    string nomeMoeda = partes[0];

                    cbxMoeda.Items.Add(nomeMoeda);
                }

                if (cbxMoeda.Items.Count > 0)
                {
                    cbxMoeda.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as cotações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcular()
        {
            double subtotal = util.normalizeDouble(txtSubtotal.Text);
            double frete = util.normalizeDouble(txtFrete.Text);
            double desconto = util.normalizeDouble(txtDesconto.Text);
            double aliquota = util.normalizeDouble(txtAliquota.Text);

            double total = (subtotal - (subtotal * (desconto / 100)) + frete);
            double imposto = (total * (aliquota / 100));
            double totalImposto = ((total + imposto) * cotacaoBid);

            txtTotal.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            txtImposto.Text = imposto.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            txtTotalImposto.Text = totalImposto.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void txtFrete_Click(object sender, EventArgs e)
        {
            util.setCursorEnd(txtFrete);
        }

        private void txtFrete_KeyDown(object sender, KeyEventArgs e)
        {
            util.txtLimparFormatacao(txtFrete);
        }

        private void txtFrete_KeyUp(object sender, KeyEventArgs e)
        {
            util.txtLimparFormatacao(txtFrete);
        }

        private void txtFrete_Enter(object sender, EventArgs e)
        {
            util.txtLimparFormatacao(txtFrete);
        }

        private void txtFrete_Leave(object sender, EventArgs e)
        {
            util.txtFormatarMoeda(txtFrete);
            calcular();
        }

        private void txtDesconto_Click(object sender, EventArgs e)
        {
            util.setCursorEnd(txtDesconto);
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            util.txtLimparFormatacao(txtDesconto);
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            util.txtLimparFormatacao(txtDesconto);
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            util.txtLimparFormatacao(txtDesconto);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            util.txtFormatarPorcentagem(txtDesconto);
            calcular();
        }

        private void cbxMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cotacaoList = cotacaoObject.Properties().ToList();

            if (cbxMoeda.SelectedIndex >= 0 && cbxMoeda.SelectedIndex < cotacaoList.Count)
            {
                var moeda = cotacaoList[cbxMoeda.SelectedIndex];

                cotacaoBid = (double)moeda.Value["bid"];
                txtCotacao.Text = cotacaoBid.ToString("C3", CultureInfo.GetCultureInfo("pt-BR"));

                calcular();
            }
        }
    }
}
