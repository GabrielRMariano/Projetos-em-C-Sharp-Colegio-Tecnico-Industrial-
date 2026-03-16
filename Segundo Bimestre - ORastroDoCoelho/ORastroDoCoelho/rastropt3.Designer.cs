namespace ORastroDoCoelho
{
    partial class rastropt3
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
            numMFINAL = new NumericUpDown();
            tbConc = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            btCalc = new Button();
            label3 = new Label();
            lblRes = new Label();
            lblConcVal = new Label();
            ((System.ComponentModel.ISupportInitialize)numMFINAL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbConc).BeginInit();
            SuspendLayout();
            // 
            // numMFINAL
            // 
            numMFINAL.Location = new Point(101, 47);
            numMFINAL.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMFINAL.Name = "numMFINAL";
            numMFINAL.Size = new Size(120, 23);
            numMFINAL.TabIndex = 0;
            // 
            // tbConc
            // 
            tbConc.Location = new Point(101, 86);
            tbConc.Maximum = 100;
            tbConc.Name = "tbConc";
            tbConc.Size = new Size(104, 45);
            tbConc.TabIndex = 1;
            tbConc.ValueChanged += tbConc_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 49);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "m final do choco";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "conc cacau";
            // 
            // btCalc
            // 
            btCalc.Location = new Point(32, 127);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(75, 23);
            btCalc.TabIndex = 4;
            btCalc.Text = "calcular";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += btCalc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 75);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "resultado: ";
            label3.Click += label3_Click;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(326, 75);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 15);
            lblRes.TabIndex = 6;
            // 
            // lblConcVal
            // 
            lblConcVal.AutoSize = true;
            lblConcVal.Location = new Point(143, 131);
            lblConcVal.Name = "lblConcVal";
            lblConcVal.Size = new Size(0, 15);
            lblConcVal.TabIndex = 7;
            // 
            // rastropt3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConcVal);
            Controls.Add(lblRes);
            Controls.Add(label3);
            Controls.Add(btCalc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbConc);
            Controls.Add(numMFINAL);
            Name = "rastropt3";
            Text = "rastropt3";
            ((System.ComponentModel.ISupportInitialize)numMFINAL).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbConc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMFINAL;
        private TrackBar tbConc;
        private Label label1;
        private Label label2;
        private Button btCalc;
        private Label label3;
        private Label lblRes;
        private Label lblConcVal;
    }
}