namespace ecomm1_2A
{
    partial class frmEditarCompra
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
            label1 = new Label();
            label2 = new Label();
            numAcrescimo = new NumericUpDown();
            btSalvar = new Button();
            cboStatus = new ComboBox();
            txtTotal = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAcrescimo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Acréscimo total:";
            // 
            // numAcrescimo
            // 
            numAcrescimo.Location = new Point(143, 74);
            numAcrescimo.Margin = new Padding(3, 2, 3, 2);
            numAcrescimo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAcrescimo.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numAcrescimo.Name = "numAcrescimo";
            numAcrescimo.Size = new Size(131, 23);
            numAcrescimo.TabIndex = 3;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(107, 159);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(82, 22);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(143, 35);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(132, 23);
            cboStatus.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(143, 112);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(132, 23);
            txtTotal.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 115);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "Total:";
            // 
            // frmEditarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 204);
            Controls.Add(label3);
            Controls.Add(cboStatus);
            Controls.Add(btSalvar);
            Controls.Add(numAcrescimo);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmEditarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Compra";
            ((System.ComponentModel.ISupportInitialize)numAcrescimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numAcrescimo;
        private Button btSalvar;
        private ComboBox cboStatus;
        private TextBox txtTotal;
        private Label label3;
    }
}