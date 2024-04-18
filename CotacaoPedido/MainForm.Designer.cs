namespace CotacaoPedido
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(635, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(635, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(635, 461);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 7;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(538, 412);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(91, 13);
            this.lbSubtotal.TabIndex = 8;
            this.lbSubtotal.Text = "Subtotal Produtos";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(520, 438);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(109, 13);
            this.lbDesconto.TabIndex = 9;
            this.lbDesconto.Text = "Desconto Produtos %";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(553, 464);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(76, 13);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Total Produtos";
            // 
            // lbCotacao
            // 
            this.lbCotacao.AutoSize = true;
            this.lbCotacao.Location = new System.Drawing.Point(10, 412);
            this.lbCotacao.Name = "lbCotacao";
            this.lbCotacao.Size = new System.Drawing.Size(84, 13);
            this.lbCotacao.TabIndex = 11;
            this.lbCotacao.Text = "Cotar preços em";
            // 
            // cbxMoeda
            // 
            this.cbxMoeda.FormattingEnabled = true;
            this.cbxMoeda.Location = new System.Drawing.Point(100, 409);
            this.cbxMoeda.Name = "cbxMoeda";
            this.cbxMoeda.Size = new System.Drawing.Size(138, 21);
            this.cbxMoeda.TabIndex = 12;
            // 
            // lbFrete
            // 
            this.lbFrete.AutoSize = true;
            this.lbFrete.Location = new System.Drawing.Point(306, 412);
            this.lbFrete.Name = "lbFrete";
            this.lbFrete.Size = new System.Drawing.Size(31, 13);
            this.lbFrete.TabIndex = 13;
            this.lbFrete.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.Location = new System.Drawing.Point(343, 409);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(163, 20);
            this.txtFrete.TabIndex = 14;
            // 
            // txtAliquota
            // 
            this.txtAliquota.Location = new System.Drawing.Point(343, 435);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(163, 20);
            this.txtAliquota.TabIndex = 15;
            // 
            // lbAliquota
            // 
            this.lbAliquota.AutoSize = true;
            this.lbAliquota.Location = new System.Drawing.Point(281, 438);
            this.lbAliquota.Name = "lbAliquota";
            this.lbAliquota.Size = new System.Drawing.Size(56, 13);
            this.lbAliquota.TabIndex = 16;
            this.lbAliquota.Text = "Aliquota %";
            // 
            // lbTotalImposto
            // 
            this.lbTotalImposto.AutoSize = true;
            this.lbTotalImposto.Location = new System.Drawing.Point(266, 468);
            this.lbTotalImposto.Name = "lbTotalImposto";
            this.lbTotalImposto.Size = new System.Drawing.Size(71, 13);
            this.lbTotalImposto.TabIndex = 17;
            this.lbTotalImposto.Text = "Total Imposto";
            // 
            // txtTotalImposto
            // 
            this.txtTotalImposto.Location = new System.Drawing.Point(343, 464);
            this.txtTotalImposto.Name = "txtTotalImposto";
            this.txtTotalImposto.Size = new System.Drawing.Size(163, 20);
            this.txtTotalImposto.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(635, 517);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 19;
            // 
            // lbTotalGeral
            // 
            this.lbTotalGeral.AutoSize = true;
            this.lbTotalGeral.Location = new System.Drawing.Point(555, 520);
            this.lbTotalGeral.Name = "lbTotalGeral";
            this.lbTotalGeral.Size = new System.Drawing.Size(74, 13);
            this.lbTotalGeral.TabIndex = 20;
            this.lbTotalGeral.Text = "Total Cotação";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.lbTotalGeral);
            this.Controls.Add(this.textBox4);
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridItens);
            this.Name = "MainForm";
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbTotalGeral;
    }
}
