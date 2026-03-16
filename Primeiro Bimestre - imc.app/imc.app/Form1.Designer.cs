namespace imc.app
{
    partial class Aplicativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicativo));
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btCalcImc = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbCalc = new Label();
            lbClass = new Label();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            SuspendLayout();
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numAltura.Location = new Point(58, 27);
            numAltura.Maximum = new decimal(new int[] { 25, 0, 0, 65536 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(120, 23);
            numAltura.TabIndex = 0;
            numAltura.ValueChanged += numAltura_ValueChanged;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 1;
            numPeso.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numPeso.Location = new Point(58, 69);
            numPeso.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(120, 23);
            numPeso.TabIndex = 1;
            numPeso.ValueChanged += numPeso_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Altura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Peso:";
            // 
            // btCalcImc
            // 
            btCalcImc.Location = new Point(70, 98);
            btCalcImc.Name = "btCalcImc";
            btCalcImc.Size = new Size(75, 23);
            btCalcImc.TabIndex = 4;
            btCalcImc.Text = "Calcular IMC";
            btCalcImc.UseVisualStyleBackColor = true;
            btCalcImc.Click += btCalcImc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 27);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 27);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Cálculo:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 53);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 7;
            label5.Text = "Classificação:";
            // 
            // lbCalc
            // 
            lbCalc.AutoSize = true;
            lbCalc.Location = new Point(385, 29);
            lbCalc.Name = "lbCalc";
            lbCalc.Size = new Size(0, 15);
            lbCalc.TabIndex = 8;
            // 
            // lbClass
            // 
            lbClass.AutoSize = true;
            lbClass.Location = new Point(385, 53);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(0, 15);
            lbClass.TabIndex = 9;
            // 
            // Aplicativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(928, 450);
            Controls.Add(lbClass);
            Controls.Add(lbCalc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btCalcImc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numPeso);
            Controls.Add(numAltura);
            Name = "Aplicativo";
            Text = "IMC app";
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
        private Label label1;
        private Label label2;
        private Button btCalcImc;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbCalc;
        private Label lbClass;
    }
}
