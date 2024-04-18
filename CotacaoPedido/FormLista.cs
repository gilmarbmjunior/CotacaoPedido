using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CotacaoPedido
{
    public partial class FormLista : Form
    {
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
            itens.Add(new Item { Id = 1, Descricao = "placa mãe asus tuf", Valor = 10.50m, Quantidade = 5 });
            itens.Add(new Item { Id = 2, Descricao = "processador intel core i5-11400f", Valor = 7.25m, Quantidade = 3 });
            itens.Add(new Item { Id = 3, Descricao = "memoria ram 32gb", Valor = 15.75m, Quantidade = 2 });
            itens.Add(new Item { Id = 4, Descricao = "ssd 500gb", Valor = 80.0m, Quantidade = 7 });
            itens.Add(new Item { Id = 5, Descricao = "placa de vídeo nvidia rtx 3080", Valor = 1500.0m, Quantidade = 2 });
            itens.Add(new Item { Id = 6, Descricao = "monitor ultrawide 34 polegadas", Valor = 600.0m, Quantidade = 4 });
            itens.Add(new Item { Id = 7, Descricao = "teclado mecânico rgb", Valor = 50.0m, Quantidade = 10 });
            itens.Add(new Item { Id = 8, Descricao = "mouse sem fio", Valor = 30.0m, Quantidade = 6 });
            itens.Add(new Item { Id = 9, Descricao = "headset gamer", Valor = 80.0m, Quantidade = 8 });
            itens.Add(new Item { Id = 10, Descricao = "cadeira gamer", Valor = 200.0m, Quantidade = 3 });
            itens.Add(new Item { Id = 11, Descricao = "processador amd ryzen 9 5900x", Valor = 450.0m, Quantidade = 2 });
            itens.Add(new Item { Id = 12, Descricao = "placa mãe msi b550", Valor = 150.0m, Quantidade = 5 });
            itens.Add(new Item { Id = 13, Descricao = "memória ram ddr4 16gb", Valor = 80.0m, Quantidade = 15 });
            itens.Add(new Item { Id = 14, Descricao = "fonte de alimentação 750w", Valor = 100.0m, Quantidade = 4 });
            itens.Add(new Item { Id = 15, Descricao = "gabinete gamer com rgb", Valor = 120.0m, Quantidade = 7 });
        }

        private void carregarItensGrid(List<Item> itens)
        {
            gridItens.Rows.Clear();
            subtotal = 0.0m;

            foreach (var item in itens)
            {
                decimal valorTotal = item.Quantidade * item.Valor;
                subtotal += valorTotal;
                gridItens.Rows.Add(item.Id, item.Descricao, item.Valor, item.Quantidade, valorTotal);
            }

            txtSubtotal.Text = subtotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, separador decimal (vírgula) e teclas de controle (backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // Impede a entrada do caractere
            }

            // Permite apenas uma ocorrência do separador decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true; // Impede a entrada do caractere
            }
        }

        private void txtValor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Remove todos os caracteres não numéricos
                string valorLimpo = textBox.Text.Replace(".", "").Replace(",", "").Replace("R$", "");

                // Converte o valor para decimal e formata com a máscara desejada
                if (decimal.TryParse(valorLimpo, out decimal valor))
                {
                    // Formata o valor com a máscara desejada
                    textBox.Text = valor.ToString("#,##0.00");
                }
            }
        }
    }
}
