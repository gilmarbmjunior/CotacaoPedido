using System.Windows.Forms;

namespace CotacaoPedido
{
    partial class FormLista
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbMoeda = new System.Windows.Forms.Label();
            this.cbxMoeda = new System.Windows.Forms.ComboBox();
            this.lbFrete = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.txtAliquota = new System.Windows.Forms.TextBox();
            this.lbAliquota = new System.Windows.Forms.Label();
            this.lbTotalImposto = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.txtTotalImposto = new System.Windows.Forms.TextBox();
            this.lbTotalGeral = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.lbCotacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridItens
            // 
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Location = new System.Drawing.Point(12, 112);
            this.gridItens.Name = "gridItens";
            this.gridItens.Size = new System.Drawing.Size(776, 291);
            this.gridItens.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(713, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtFiltro);
            this.gbFiltro.Location = new System.Drawing.Point(13, 45);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(775, 53);
            this.gbFiltro.TabIndex = 4;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtrar p/ Descrição";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(6, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(763, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(58, 19);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(142, 20);
            this.txtSubtotal.TabIndex = 5;
            this.txtSubtotal.Text = "R$ 0,00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(265, 19);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(113, 20);
            this.txtDesconto.TabIndex = 6;
            this.txtDesconto.Text = "0,00 %";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Click += new System.EventHandler(this.txtDesconto_Click);
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            this.txtDesconto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyUp);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(577, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(193, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "R$ 0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(6, 22);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lbSubtotal.TabIndex = 8;
            this.lbSubtotal.Text = "Subtotal";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(206, 22);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(53, 13);
            this.lbDesconto.TabIndex = 9;
            this.lbDesconto.Text = "Desconto";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(540, 22);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Total";
            // 
            // lbMoeda
            // 
            this.lbMoeda.AutoSize = true;
            this.lbMoeda.Location = new System.Drawing.Point(9, 22);
            this.lbMoeda.Name = "lbMoeda";
            this.lbMoeda.Size = new System.Drawing.Size(43, 13);
            this.lbMoeda.TabIndex = 11;
            this.lbMoeda.Text = "Moeda ";
            // 
            // cbxMoeda
            // 
            this.cbxMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoeda.FormattingEnabled = true;
            this.cbxMoeda.Location = new System.Drawing.Point(58, 19);
            this.cbxMoeda.Name = "cbxMoeda";
            this.cbxMoeda.Size = new System.Drawing.Size(164, 21);
            this.cbxMoeda.TabIndex = 12;
            this.cbxMoeda.SelectedIndexChanged += new System.EventHandler(this.cbxMoeda_SelectedIndexChanged);
            // 
            // lbFrete
            // 
            this.lbFrete.AutoSize = true;
            this.lbFrete.Location = new System.Drawing.Point(384, 22);
            this.lbFrete.Name = "lbFrete";
            this.lbFrete.Size = new System.Drawing.Size(31, 13);
            this.lbFrete.TabIndex = 13;
            this.lbFrete.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.Location = new System.Drawing.Point(421, 19);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(113, 20);
            this.txtFrete.TabIndex = 14;
            this.txtFrete.Text = "R$ 0,00";
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrete.Click += new System.EventHandler(this.txtFrete_Click);
            this.txtFrete.Enter += new System.EventHandler(this.txtFrete_Enter);
            this.txtFrete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrete_KeyDown);
            this.txtFrete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFrete_KeyUp);
            this.txtFrete.Leave += new System.EventHandler(this.txtFrete_Leave);
            // 
            // txtAliquota
            // 
            this.txtAliquota.Enabled = false;
            this.txtAliquota.Location = new System.Drawing.Point(435, 19);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(99, 20);
            this.txtAliquota.TabIndex = 15;
            this.txtAliquota.Text = "92,00 %";
            this.txtAliquota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbAliquota
            // 
            this.lbAliquota.AutoSize = true;
            this.lbAliquota.Location = new System.Drawing.Point(384, 22);
            this.lbAliquota.Name = "lbAliquota";
            this.lbAliquota.Size = new System.Drawing.Size(45, 13);
            this.lbAliquota.TabIndex = 16;
            this.lbAliquota.Text = "Aliquota";
            // 
            // lbTotalImposto
            // 
            this.lbTotalImposto.AutoSize = true;
            this.lbTotalImposto.Location = new System.Drawing.Point(540, 22);
            this.lbTotalImposto.Name = "lbTotalImposto";
            this.lbTotalImposto.Size = new System.Drawing.Size(31, 13);
            this.lbTotalImposto.TabIndex = 17;
            this.lbTotalImposto.Text = "Total";
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Location = new System.Drawing.Point(577, 19);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(193, 20);
            this.txtImposto.TabIndex = 18;
            this.txtImposto.Text = "R$ 0,00";
            this.txtImposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImposto
            // 
            this.txtTotalImposto.Enabled = false;
            this.txtTotalImposto.Location = new System.Drawing.Point(589, 578);
            this.txtTotalImposto.Name = "txtTotalImposto";
            this.txtTotalImposto.Size = new System.Drawing.Size(199, 20);
            this.txtTotalImposto.TabIndex = 19;
            this.txtTotalImposto.Text = "R$ 0,00";
            this.txtTotalImposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalGeral
            // 
            this.lbTotalGeral.AutoSize = true;
            this.lbTotalGeral.Location = new System.Drawing.Point(516, 581);
            this.lbTotalGeral.Name = "lbTotalGeral";
            this.lbTotalGeral.Size = new System.Drawing.Size(67, 13);
            this.lbTotalGeral.TabIndex = 20;
            this.lbTotalGeral.Text = "Total Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSubtotal);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.lbDesconto);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.lbFrete);
            this.groupBox1.Controls.Add(this.txtFrete);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 55);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCotacao);
            this.groupBox2.Controls.Add(this.cbxMoeda);
            this.groupBox2.Controls.Add(this.txtCotacao);
            this.groupBox2.Controls.Add(this.lbMoeda);
            this.groupBox2.Controls.Add(this.lbAliquota);
            this.groupBox2.Controls.Add(this.txtAliquota);
            this.groupBox2.Controls.Add(this.txtImposto);
            this.groupBox2.Controls.Add(this.lbTotalImposto);
            this.groupBox2.Location = new System.Drawing.Point(12, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 54);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importação";
            // 
            // txtCotacao
            // 
            this.txtCotacao.Enabled = false;
            this.txtCotacao.Location = new System.Drawing.Point(265, 19);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(113, 20);
            this.txtCotacao.TabIndex = 23;
            this.txtCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbCotacao
            // 
            this.lbCotacao.AutoSize = true;
            this.lbCotacao.Location = new System.Drawing.Point(228, 22);
            this.lbCotacao.Name = "lbCotacao";
            this.lbCotacao.Size = new System.Drawing.Size(31, 13);
            this.lbCotacao.TabIndex = 24;
            this.lbCotacao.Text = "Valor";
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTotalGeral);
            this.Controls.Add(this.txtTotalImposto);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridItens);
            this.Name = "FormLista";
            this.Text = "Cotação Produto";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbMoeda;
        private System.Windows.Forms.ComboBox cbxMoeda;
        private System.Windows.Forms.Label lbFrete;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.TextBox txtAliquota;
        private System.Windows.Forms.Label lbAliquota;
        private System.Windows.Forms.Label lbTotalImposto;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.TextBox txtTotalImposto;
        private System.Windows.Forms.Label lbTotalGeral;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCotacao;
        private Label lbCotacao;
    }
}
