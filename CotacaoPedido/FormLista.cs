using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CotacaoPedido
{
    public partial class FormLista : Form
    {
        private Util util = new Util();
        private List<Item> itens = new List<Item>();
        private decimal subtotal = 0.0m;

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

            btnNovo.Click += btnNovoClick;
            btnEditar.Click += btnEditarClick;
            btnExcluir.Click += btnExcluirClick;
            txtFiltro.TextChanged += filtrarItens;
            gridItens.CellFormatting += gridCellFormatting;
        }

        private void carregarItensLista()
        {
            itens.Add(new Item { Id = 1, Descricao = "placa mãe asus tuf", Valor = 10.00m, Quantidade = 5 });
            itens.Add(new Item { Id = 2, Descricao = "processador intel core i5-11400f", Valor = 7.25m, Quantidade = 3 });
            itens.Add(new Item { Id = 3, Descricao = "memoria ram 32gb", Valor = 15.75m, Quantidade = 2 });
            itens.Add(new Item { Id = 4, Descricao = "ssd 500gb", Valor = 80.0m, Quantidade = 7 });
            itens.Add(new Item { Id = 5, Descricao = "placa de vídeo nvidia rtx 3080", Valor = 1500.0m, Quantidade = 2 });
            itens.Add(new Item { Id = 6, Descricao = "monitor ultrawide 34 polegadas", Valor = 600.0m, Quantidade = 4 });
            itens.Add(new Item { Id = 7, Descricao = "teclado mecânico rgb", Valor = 50.0m, Quantidade = 10 });
            itens.Add(new Item { Id = 8, Descricao = "mouse sem fio", Valor = 30.0m, Quantidade = 6 });
            itens.Add(new Item { Id = 9, Descricao = "headset gamer", Valor = 80.0m, Quantidade = 8 });
            itens.Add(new Item { Id = 10, Descricao = "cadeira gamer", Valor = 200.0m, Quantidade = 3 });
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

            util.limparMoede(txtSubtotal);
            util.formatarMoeda(txtSubtotal);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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

        private void txtTotalCotacao_Click(object sender, EventArgs e)
        {
            util.setCursorEnd(txtTotalCotacao);
        }

        private void txtTotalCotacao_KeyDown(object sender, KeyEventArgs e)
        {
            util.limparMoede(txtTotalCotacao);
        }

        private void txtTotalCotacao_KeyUp(object sender, KeyEventArgs e)
        {
            util.limparMoede(txtTotalCotacao);
        }

        private void TxtTotalCotacao_Enter(object sender, EventArgs e)
        {
            util.limparMoede(txtTotalCotacao);
        }

        private void TxtTotalCotacao_Leave(object sender, EventArgs e)
        {
            util.formatarMoeda(txtTotalCotacao);
        }

        private void txtFrete_Click(object sender, EventArgs e)
        {
            util.setCursorEnd(txtFrete);
        }

        private void txtFrete_KeyDown(object sender, KeyEventArgs e)
        {
            util.limparMoede(txtFrete);
        }

        private void txtFrete_KeyUp(object sender, KeyEventArgs e)
        {
            util.limparMoede(txtFrete);
        }

        private void txtFrete_Enter(object sender, EventArgs e)
        {
            util.limparMoede(txtFrete);
        }

        private void txtFrete_Leave(object sender, EventArgs e)
        {
            util.formatarMoeda(txtFrete);
        }
    }
}
