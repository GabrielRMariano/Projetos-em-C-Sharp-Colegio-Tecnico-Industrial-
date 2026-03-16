namespace ORastroDoCoelho
{
    partial class rastropt2
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
            numTempCelsius = new NumericUpDown();
            label1 = new Label();
            lblCelpFar = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCelpKelvin = new Label();
            btCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)numTempCelsius).BeginInit();
            SuspendLayout();
            // 
            // numTempCelsius
            // 
            numTempCelsius.Location = new Point(84, 36);
            numTempCelsius.Maximum = new decimal(new int[] { 1600, 0, 0, 0 });
            numTempCelsius.Name = "numTempCelsius";
            numTempCelsius.Size = new Size(120, 23);
            numTempCelsius.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "celsius";
            // 
            // lblCelpFar
            // 
            lblCelpFar.AutoSize = true;
            lblCelpFar.Location = new Point(367, 77);
            lblCelpFar.Name = "lblCelpFar";
            lblCelpFar.Size = new Size(0, 15);
            lblCelpFar.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 38);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 5;
            label4.Text = "resultado em kelvin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 77);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 6;
            label5.Text = "resultado em farenheint: ";
            // 
            // lblCelpKelvin
            // 
            lblCelpKelvin.AutoSize = true;
            lblCelpKelvin.Location = new Point(341, 38);
            lblCelpKelvin.Name = "lblCelpKelvin";
            lblCelpKelvin.Size = new Size(0, 15);
            lblCelpKelvin.TabIndex = 7;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(84, 70);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(75, 29);
            btCalcular.TabIndex = 8;
            btCalcular.Text = "calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // rastropt2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCalcular);
            Controls.Add(lblCelpKelvin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblCelpFar);
            Controls.Add(label1);
            Controls.Add(numTempCelsius);
            Name = "rastropt2";
            Text = "rastropt2";
            ((System.ComponentModel.ISupportInitialize)numTempCelsius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numTempCelsius;
        private NumericUpDown numTempKelvin;
        private Label label1;
        private Label label2;
        private Label lblCelpFar;
        private Label label4;
        private Label label5;
        private Label lblCelpKelvin;
        private Button btCalcular;
    }
}