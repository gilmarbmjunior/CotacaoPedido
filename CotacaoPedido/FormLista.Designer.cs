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
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCotacao = new System.Windows.Forms.Label();
            this.cbxMoeda = new System.Windows.Forms.ComboBox();
            this.lbFrete = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.txtAliquota = new System.Windows.Forms.TextBox();
            this.lbAliquota = new System.Windows.Forms.Label();
            this.lbTotalImposto = new System.Windows.Forms.Label();
            this.txtTotalImposto = new System.Windows.Forms.TextBox();
            this.txtTotalCotacao = new System.Windows.Forms.TextBox();
            this.lbTotalGeral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.gbFiltro.SuspendLayout();
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
            this.gbFiltro.Controls.Add(this.lblFiltro);
            this.gbFiltro.Location = new System.Drawing.Point(13, 41);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(775, 65);
            this.gbFiltro.TabIndex = 4;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(9, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(760, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(6, 16);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 13);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Descrição";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(61, 424);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(153, 20);
            this.txtSubtotal.TabIndex = 5;
            this.txtSubtotal.Text = "R$ 0,00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 424);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0,00 %";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(635, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "R$ 0,00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(9, 427);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lbSubtotal.TabIndex = 8;
            this.lbSubtotal.Text = "Subtotal";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(408, 427);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(53, 13);
            this.lbDesconto.TabIndex = 9;
            this.lbDesconto.Text = "Desconto";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(598, 427);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Total";
            // 
            // lbCotacao
            // 
            this.lbCotacao.AutoSize = true;
            this.lbCotacao.Location = new System.Drawing.Point(9, 455);
            this.lbCotacao.Name = "lbCotacao";
            this.lbCotacao.Size = new System.Drawing.Size(43, 13);
            this.lbCotacao.TabIndex = 11;
            this.lbCotacao.Text = "Moeda ";
            // 
            // cbxMoeda
            // 
            this.cbxMoeda.FormattingEnabled = true;
            this.cbxMoeda.Location = new System.Drawing.Point(58, 452);
            this.cbxMoeda.Name = "cbxMoeda";
            this.cbxMoeda.Size = new System.Drawing.Size(284, 21);
            this.cbxMoeda.TabIndex = 12;
            // 
            // lbFrete
            // 
            this.lbFrete.AutoSize = true;
            this.lbFrete.Location = new System.Drawing.Point(235, 427);
            this.lbFrete.Name = "lbFrete";
            this.lbFrete.Size = new System.Drawing.Size(31, 13);
            this.lbFrete.TabIndex = 13;
            this.lbFrete.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.Location = new System.Drawing.Point(272, 424);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(112, 20);
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
            this.txtAliquota.Location = new System.Drawing.Point(415, 452);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(153, 20);
            this.txtAliquota.TabIndex = 15;
            this.txtAliquota.Text = "92,00 %";
            this.txtAliquota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbAliquota
            // 
            this.lbAliquota.AutoSize = true;
            this.lbAliquota.Location = new System.Drawing.Point(364, 455);
            this.lbAliquota.Name = "lbAliquota";
            this.lbAliquota.Size = new System.Drawing.Size(45, 13);
            this.lbAliquota.TabIndex = 16;
            this.lbAliquota.Text = "Aliquota";
            // 
            // lbTotalImposto
            // 
            this.lbTotalImposto.AutoSize = true;
            this.lbTotalImposto.Location = new System.Drawing.Point(585, 455);
            this.lbTotalImposto.Name = "lbTotalImposto";
            this.lbTotalImposto.Size = new System.Drawing.Size(44, 13);
            this.lbTotalImposto.TabIndex = 17;
            this.lbTotalImposto.Text = "Imposto";
            // 
            // txtTotalImposto
            // 
            this.txtTotalImposto.Enabled = false;
            this.txtTotalImposto.Location = new System.Drawing.Point(635, 452);
            this.txtTotalImposto.Name = "txtTotalImposto";
            this.txtTotalImposto.Size = new System.Drawing.Size(153, 20);
            this.txtTotalImposto.TabIndex = 18;
            this.txtTotalImposto.Text = "R$ 0,00";
            this.txtTotalImposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalCotacao
            // 
            this.txtTotalCotacao.Location = new System.Drawing.Point(635, 497);
            this.txtTotalCotacao.Name = "txtTotalCotacao";
            this.txtTotalCotacao.Size = new System.Drawing.Size(153, 20);
            this.txtTotalCotacao.TabIndex = 19;
            this.txtTotalCotacao.Text = "R$ 0,00";
            this.txtTotalCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCotacao.Click += new System.EventHandler(this.txtTotalCotacao_Click);
            this.txtTotalCotacao.Enter += new System.EventHandler(this.TxtTotalCotacao_Enter);
            this.txtTotalCotacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalCotacao_KeyDown);
            this.txtTotalCotacao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalCotacao_KeyUp);
            this.txtTotalCotacao.Leave += new System.EventHandler(this.TxtTotalCotacao_Leave);
            // 
            // lbTotalGeral
            // 
            this.lbTotalGeral.AutoSize = true;
            this.lbTotalGeral.Location = new System.Drawing.Point(555, 500);
            this.lbTotalGeral.Name = "lbTotalGeral";
            this.lbTotalGeral.Size = new System.Drawing.Size(80, 13);
            this.lbTotalGeral.TabIndex = 20;
            this.lbTotalGeral.Text = "Total + Imposto";
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.lbTotalGeral);
            this.Controls.Add(this.txtTotalCotacao);
            this.Controls.Add(this.txtTotalImposto);
            this.Controls.Add(this.lbTotalImposto);
            this.Controls.Add(this.lbAliquota);
            this.Controls.Add(this.txtAliquota);
            this.Controls.Add(this.txtFrete);
            this.Controls.Add(this.lbFrete);
            this.Controls.Add(this.cbxMoeda);
            this.Controls.Add(this.lbCotacao);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDesconto);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridItens);
            this.Name = "FormLista";
            this.Text = "Cotação Produto";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCotacao;
        private System.Windows.Forms.ComboBox cbxMoeda;
        private System.Windows.Forms.Label lbFrete;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.TextBox txtAliquota;
        private System.Windows.Forms.Label lbAliquota;
        private System.Windows.Forms.Label lbTotalImposto;
        private System.Windows.Forms.TextBox txtTotalImposto;
        private System.Windows.Forms.TextBox txtTotalCotacao;
        private System.Windows.Forms.Label lbTotalGeral;
    }
}
