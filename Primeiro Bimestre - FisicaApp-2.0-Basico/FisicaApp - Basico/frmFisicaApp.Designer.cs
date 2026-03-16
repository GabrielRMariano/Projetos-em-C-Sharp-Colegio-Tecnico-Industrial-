namespace FisicaApp___Basico
{
    partial class frmFisicaApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFisicaApp));
            lblEntrada1 = new Label();
            lblEntrada2 = new Label();
            lblEntrada3 = new Label();
            lblTxtResultado = new Label();
            btVelMedia = new Button();
            btAcel = new Button();
            btMovUniforme = new Button();
            btTorricelli = new Button();
            numEntrada1 = new NumericUpDown();
            numEntrada3 = new NumericUpDown();
            numEntrada2 = new NumericUpDown();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)numEntrada1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada2).BeginInit();
            SuspendLayout();
            // 
            // lblEntrada1
            // 
            lblEntrada1.AutoSize = true;
            lblEntrada1.Location = new Point(24, 28);
            lblEntrada1.Name = "lblEntrada1";
            lblEntrada1.Size = new Size(69, 17);
            lblEntrada1.TabIndex = 0;
            lblEntrada1.Text = "Entrada 1: ";
            // 
            // lblEntrada2
            // 
            lblEntrada2.AutoSize = true;
            lblEntrada2.Location = new Point(24, 88);
            lblEntrada2.Name = "lblEntrada2";
            lblEntrada2.Size = new Size(67, 17);
            lblEntrada2.TabIndex = 1;
            lblEntrada2.Text = "Entrada 2:";
            // 
            // lblEntrada3
            // 
            lblEntrada3.AutoSize = true;
            lblEntrada3.Location = new Point(24, 148);
            lblEntrada3.Name = "lblEntrada3";
            lblEntrada3.Size = new Size(67, 17);
            lblEntrada3.TabIndex = 2;
            lblEntrada3.Text = "Entrada 3:";
            // 
            // lblTxtResultado
            // 
            lblTxtResultado.AutoSize = true;
            lblTxtResultado.Location = new Point(27, 288);
            lblTxtResultado.Name = "lblTxtResultado";
            lblTxtResultado.Size = new Size(65, 17);
            lblTxtResultado.TabIndex = 3;
            lblTxtResultado.Text = "Resultado:";
            // 
            // btVelMedia
            // 
            btVelMedia.Location = new Point(27, 204);
            btVelMedia.Name = "btVelMedia";
            btVelMedia.Size = new Size(75, 53);
            btVelMedia.TabIndex = 4;
            btVelMedia.Text = "Velocidade Média";
            btVelMedia.UseVisualStyleBackColor = true;
            btVelMedia.Click += btVelMedia_Click;
            // 
            // btAcel
            // 
            btAcel.Location = new Point(127, 204);
            btAcel.Name = "btAcel";
            btAcel.Size = new Size(78, 53);
            btAcel.TabIndex = 5;
            btAcel.Text = "Aceleração";
            btAcel.UseVisualStyleBackColor = true;
            btAcel.Click += btAcel_Click;
            // 
            // btMovUniforme
            // 
            btMovUniforme.Location = new Point(227, 204);
            btMovUniforme.Name = "btMovUniforme";
            btMovUniforme.Size = new Size(82, 53);
            btMovUniforme.TabIndex = 6;
            btMovUniforme.Text = "Movimento Uniforme";
            btMovUniforme.UseVisualStyleBackColor = true;
            btMovUniforme.Click += btMovUniforme_Click;
            // 
            // btTorricelli
            // 
            btTorricelli.Location = new Point(327, 204);
            btTorricelli.Name = "btTorricelli";
            btTorricelli.Size = new Size(75, 53);
            btTorricelli.TabIndex = 7;
            btTorricelli.Text = "Torricelli";
            btTorricelli.UseVisualStyleBackColor = true;
            btTorricelli.Click += btTorricelli_Click;
            // 
            // numEntrada1
            // 
            numEntrada1.DecimalPlaces = 2;
            numEntrada1.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numEntrada1.Location = new Point(102, 26);
            numEntrada1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntrada1.Name = "numEntrada1";
            numEntrada1.Size = new Size(120, 24);
            numEntrada1.TabIndex = 8;
            // 
            // numEntrada3
            // 
            numEntrada3.DecimalPlaces = 2;
            numEntrada3.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numEntrada3.Location = new Point(102, 146);
            numEntrada3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntrada3.Name = "numEntrada3";
            numEntrada3.Size = new Size(120, 24);
            numEntrada3.TabIndex = 10;
            numEntrada3.ValueChanged += numEntrada3_ValueChanged;
            // 
            // numEntrada2
            // 
            numEntrada2.DecimalPlaces = 2;
            numEntrada2.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numEntrada2.Location = new Point(102, 86);
            numEntrada2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntrada2.Name = "numEntrada2";
            numEntrada2.Size = new Size(120, 24);
            numEntrada2.TabIndex = 9;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(128, 288);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 17);
            lblResultado.TabIndex = 11;
            // 
            // frmFisicaApp
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 326);
            Controls.Add(lblResultado);
            Controls.Add(numEntrada2);
            Controls.Add(numEntrada3);
            Controls.Add(numEntrada1);
            Controls.Add(btTorricelli);
            Controls.Add(btMovUniforme);
            Controls.Add(btAcel);
            Controls.Add(btVelMedia);
            Controls.Add(lblTxtResultado);
            Controls.Add(lblEntrada3);
            Controls.Add(lblEntrada2);
            Controls.Add(lblEntrada1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFisicaApp";
            Text = "FisicaApp 2.0 - Básico";
            ((System.ComponentModel.ISupportInitialize)numEntrada1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntrada1;
        private Label lblEntrada2;
        private Label lblEntrada3;
        private Label lblTxtResultado;
        private Button btVelMedia;
        private Button btAcel;
        private Button btMovUniforme;
        private Button btTorricelli;
        private NumericUpDown numEntrada1;
        private NumericUpDown numEntrada3;
        private NumericUpDown numEntrada2;
        private Label lblResultado;
    }
}
