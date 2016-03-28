namespace NotasFiscais
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.clProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDsProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGravItens = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtNroNota = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDtaEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtVlrTotal = new System.Windows.Forms.TextBox();
            this.txtQtdTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInclItens = new System.Windows.Forms.Button();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtDsProduto = new System.Windows.Forms.TextBox();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.txtVlrUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridItens
            // 
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProduto,
            this.clDsProduto,
            this.clQtde,
            this.clUnitario,
            this.clTotal});
            this.dataGridItens.Location = new System.Drawing.Point(37, 258);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItens.Size = new System.Drawing.Size(644, 258);
            this.dataGridItens.TabIndex = 0;
            this.dataGridItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItens_CellContentClick);
            this.dataGridItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridItens_KeyDown);
            this.dataGridItens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridItens_MouseClick);
            // 
            // clProduto
            // 
            this.clProduto.HeaderText = "Produto";
            this.clProduto.Name = "clProduto";
            this.clProduto.Width = 75;
            // 
            // clDsProduto
            // 
            this.clDsProduto.HeaderText = "Descrição";
            this.clDsProduto.Name = "clDsProduto";
            this.clDsProduto.Width = 300;
            // 
            // clQtde
            // 
            this.clQtde.HeaderText = "Quantidade";
            this.clQtde.Name = "clQtde";
            this.clQtde.Width = 75;
            // 
            // clUnitario
            // 
            this.clUnitario.HeaderText = "Unitário";
            this.clUnitario.Name = "clUnitario";
            this.clUnitario.Width = 75;
            // 
            // clTotal
            // 
            this.clTotal.HeaderText = "Total";
            this.clTotal.Name = "clTotal";
            this.clTotal.Width = 75;
            // 
            // btnGravItens
            // 
            this.btnGravItens.Location = new System.Drawing.Point(687, 292);
            this.btnGravItens.Name = "btnGravItens";
            this.btnGravItens.Size = new System.Drawing.Size(75, 23);
            this.btnGravItens.TabIndex = 1;
            this.btnGravItens.Text = "Grav. Itens";
            this.btnGravItens.UseVisualStyleBackColor = true;
            this.btnGravItens.Click += new System.EventHandler(this.btnGravItens_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(32, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(113, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(194, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(275, 19);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(356, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(108, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(437, 19);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtNroNota
            // 
            this.txtNroNota.Location = new System.Drawing.Point(136, 88);
            this.txtNroNota.Name = "txtNroNota";
            this.txtNroNota.Size = new System.Drawing.Size(100, 20);
            this.txtNroNota.TabIndex = 8;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(136, 142);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(216, 20);
            this.txtCliente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número da Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data da Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente da Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Para excluir um produto, selecione a linha e pressione Delete.";
            // 
            // txtDtaEmissao
            // 
            this.txtDtaEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtaEmissao.Location = new System.Drawing.Point(136, 115);
            this.txtDtaEmissao.Name = "txtDtaEmissao";
            this.txtDtaEmissao.Size = new System.Drawing.Size(100, 20);
            this.txtDtaEmissao.TabIndex = 15;
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(606, 518);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Size = new System.Drawing.Size(75, 20);
            this.txtVlrTotal.TabIndex = 16;
            this.txtVlrTotal.Text = "0,00";
            this.txtVlrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtdTotal
            // 
            this.txtQtdTotal.Location = new System.Drawing.Point(459, 518);
            this.txtQtdTotal.Name = "txtQtdTotal";
            this.txtQtdTotal.Size = new System.Drawing.Size(75, 20);
            this.txtQtdTotal.TabIndex = 17;
            this.txtQtdTotal.Text = "0,000";
            this.txtQtdTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "QTD. TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "VLR TOTAL";
            // 
            // btnInclItens
            // 
            this.btnInclItens.Location = new System.Drawing.Point(606, 214);
            this.btnInclItens.Name = "btnInclItens";
            this.btnInclItens.Size = new System.Drawing.Size(75, 23);
            this.btnInclItens.TabIndex = 20;
            this.btnInclItens.Text = "Incl. Itens";
            this.btnInclItens.UseVisualStyleBackColor = true;
            this.btnInclItens.Click += new System.EventHandler(this.btnInclItens_Click);
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(77, 216);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(75, 20);
            this.txtCodProd.TabIndex = 21;
            this.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDsProduto
            // 
            this.txtDsProduto.Location = new System.Drawing.Point(153, 216);
            this.txtDsProduto.Name = "txtDsProduto";
            this.txtDsProduto.Size = new System.Drawing.Size(300, 20);
            this.txtDsProduto.TabIndex = 22;
            this.txtDsProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.Location = new System.Drawing.Point(454, 216);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(75, 20);
            this.txtQtdProd.TabIndex = 23;
            this.txtQtdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVlrUnit
            // 
            this.txtVlrUnit.Location = new System.Drawing.Point(530, 216);
            this.txtVlrUnit.Name = "txtVlrUnit";
            this.txtVlrUnit.Size = new System.Drawing.Size(75, 20);
            this.txtVlrUnit.TabIndex = 24;
            this.txtVlrUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "CodProduto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Descrição do Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Vlr Unitário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 547);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVlrUnit);
            this.Controls.Add(this.txtQtdProd);
            this.Controls.Add(this.txtDsProduto);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.btnInclItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtdTotal);
            this.Controls.Add(this.txtVlrTotal);
            this.Controls.Add(this.txtDtaEmissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNroNota);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGravItens);
            this.Controls.Add(this.dataGridItens);
            this.Name = "Form1";
            this.Text = "Prova - Leonardo Fonseca Pontes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridItens;
        private System.Windows.Forms.Button btnGravItens;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtNroNota;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDtaEmissao;
        private System.Windows.Forms.TextBox txtVlrTotal;
        private System.Windows.Forms.TextBox txtQtdTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInclItens;
        private System.Windows.Forms.TextBox txtVlrUnit;
        private System.Windows.Forms.TextBox txtQtdProd;
        private System.Windows.Forms.TextBox txtDsProduto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDsProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

