namespace ORastroDoCoelho
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtOriginal = new TextBox();
            btProcessar = new Button();
            txtFinal = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto Criptografado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 96);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Resultado:";
            // 
            // txtOriginal
            // 
            txtOriginal.Location = new Point(145, 30);
            txtOriginal.Name = "txtOriginal";
            txtOriginal.Size = new Size(194, 23);
            txtOriginal.TabIndex = 1;
            txtOriginal.TextChanged += txtOriginal_TextChanged;
            // 
            // btProcessar
            // 
            btProcessar.Enabled = false;
            btProcessar.Location = new Point(145, 67);
            btProcessar.Name = "btProcessar";
            btProcessar.Size = new Size(75, 23);
            btProcessar.TabIndex = 2;
            btProcessar.Text = "Processar";
            btProcessar.UseVisualStyleBackColor = true;
            btProcessar.Click += btProcessar_Click;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(145, 93);
            txtFinal.Name = "txtFinal";
            txtFinal.ReadOnly = true;
            txtFinal.Size = new Size(194, 163);
            txtFinal.TabIndex = 3;
            txtFinal.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 279);
            Controls.Add(txtFinal);
            Controls.Add(btProcessar);
            Controls.Add(txtOriginal);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rastro do Coelho";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOriginal;
        private Button btProcessar;
        private RichTextBox txtFinal;
    }
}
