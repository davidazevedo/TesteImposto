namespace TesteImposto
{
    partial class FormImposto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private readonly  ProcessarNota ProcessarNota;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.buttonGerarNotaFiscal = new System.Windows.Forms.Button();
            this.progressBarCalcular = new System.Windows.Forms.ProgressBar();
            this.comboBoxEstadoOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoDestino = new System.Windows.Forms.ComboBox();
            this.labelMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Destino:";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeCliente.Location = new System.Drawing.Point(10, 80);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(736, 25);
            this.textBoxNomeCliente.TabIndex = 3;
            this.textBoxNomeCliente.Text = "DAVID PEREIRA DE AZEVEDO";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(7, 209);
            this.dataGridViewPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(747, 342);
            this.dataGridViewPedidos.TabIndex = 7;
            // 
            // buttonGerarNotaFiscal
            // 
            this.buttonGerarNotaFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGerarNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerarNotaFiscal.Location = new System.Drawing.Point(364, 109);
            this.buttonGerarNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGerarNotaFiscal.Name = "buttonGerarNotaFiscal";
            this.buttonGerarNotaFiscal.Size = new System.Drawing.Size(382, 55);
            this.buttonGerarNotaFiscal.TabIndex = 8;
            this.buttonGerarNotaFiscal.Text = "Gerar Nota Fiscal";
            this.buttonGerarNotaFiscal.UseVisualStyleBackColor = true;
            this.buttonGerarNotaFiscal.Click += new System.EventHandler(this.buttonGerarNotaFiscal_Click);
            // 
            // progressBarCalcular
            // 
            this.progressBarCalcular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarCalcular.Location = new System.Drawing.Point(0, 582);
            this.progressBarCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarCalcular.Name = "progressBarCalcular";
            this.progressBarCalcular.Size = new System.Drawing.Size(766, 30);
            this.progressBarCalcular.TabIndex = 9;
            // 
            // comboBoxEstadoOrigem
            // 
            this.comboBoxEstadoOrigem.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEstadoOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstadoOrigem.FormattingEnabled = true;
            this.comboBoxEstadoOrigem.Location = new System.Drawing.Point(131, 109);
            this.comboBoxEstadoOrigem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEstadoOrigem.Name = "comboBoxEstadoOrigem";
            this.comboBoxEstadoOrigem.Size = new System.Drawing.Size(227, 25);
            this.comboBoxEstadoOrigem.TabIndex = 10;
            // 
            // comboBoxEstadoDestino
            // 
            this.comboBoxEstadoDestino.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEstadoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstadoDestino.FormattingEnabled = true;
            this.comboBoxEstadoDestino.Location = new System.Drawing.Point(131, 139);
            this.comboBoxEstadoDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEstadoDestino.Name = "comboBoxEstadoDestino";
            this.comboBoxEstadoDestino.Size = new System.Drawing.Size(227, 25);
            this.comboBoxEstadoDestino.TabIndex = 11;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.Location = new System.Drawing.Point(3, 554);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(2, 18);
            this.labelMsg.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Informe abaixo os Pedidos";
            // 
            // FormImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(766, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.comboBoxEstadoDestino);
            this.Controls.Add(this.comboBoxEstadoOrigem);
            this.Controls.Add(this.progressBarCalcular);
            this.Controls.Add(this.buttonGerarNotaFiscal);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImposto";
            this.ShowIcon = false;
            this.Text = "[-] CALCULADOR DE IMPOSTOS";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxNomeCliente, 0);
            this.Controls.SetChildIndex(this.dataGridViewPedidos, 0);
            this.Controls.SetChildIndex(this.buttonGerarNotaFiscal, 0);
            this.Controls.SetChildIndex(this.progressBarCalcular, 0);
            this.Controls.SetChildIndex(this.comboBoxEstadoOrigem, 0);
            this.Controls.SetChildIndex(this.comboBoxEstadoDestino, 0);
            this.Controls.SetChildIndex(this.labelMsg, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonGerarNotaFiscal;
        public System.Windows.Forms.ProgressBar progressBarCalcular;
        private System.Windows.Forms.ComboBox comboBoxEstadoOrigem;
        private System.Windows.Forms.ComboBox comboBoxEstadoDestino;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Label label4;
    }
}

