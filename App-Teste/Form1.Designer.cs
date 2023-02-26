namespace App_Teste
{
    partial class Flanges
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
            Norma1 = new ComboBox();
            Norma2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            classe_pressao1 = new ComboBox();
            classe_pressao2 = new ComboBox();
            Dfuracao1 = new ComboBox();
            label3 = new Label();
            Dfuracao2 = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            Result = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 74);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Norma1";
            // 
            // Norma1
            // 
            Norma1.FormattingEnabled = true;
            Norma1.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA C207" });
            Norma1.Location = new Point(232, 110);
            Norma1.Name = "Norma1";
            Norma1.Size = new Size(136, 23);
            Norma1.TabIndex = 2;
            Norma1.SelectedIndexChanged += StandardOne_SelectedIndexChanged;
            // 
            // Norma2
            // 
            Norma2.FormattingEnabled = true;
            Norma2.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA C207" });
            Norma2.Location = new Point(444, 110);
            Norma2.Name = "Norma2";
            Norma2.Size = new Size(136, 23);
            Norma2.TabIndex = 3;
            Norma2.SelectedIndexChanged += StandardTwo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Norma2";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(321, 240);
            button1.Name = "button1";
            button1.Size = new Size(159, 34);
            button1.TabIndex = 11;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // classe_pressao1
            // 
            classe_pressao1.FormattingEnabled = true;
            classe_pressao1.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA 207 - RESSALTO", "AWWA 207 - LISO" });
            classe_pressao1.Location = new Point(232, 156);
            classe_pressao1.Name = "classe_pressao1";
            classe_pressao1.Size = new Size(136, 23);
            classe_pressao1.TabIndex = 12;
            classe_pressao1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // classe_pressao2
            // 
            classe_pressao2.Enabled = false;
            classe_pressao2.FormattingEnabled = true;
            classe_pressao2.Location = new Point(444, 156);
            classe_pressao2.Name = "classe_pressao2";
            classe_pressao2.Size = new Size(136, 23);
            classe_pressao2.TabIndex = 13;
            classe_pressao2.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // Dfuracao1
            // 
            Dfuracao1.Enabled = false;
            Dfuracao1.FormattingEnabled = true;
            Dfuracao1.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA 207 - RESSALTO", "AWWA 207 - LISO" });
            Dfuracao1.Location = new Point(232, 202);
            Dfuracao1.Name = "Dfuracao1";
            Dfuracao1.Size = new Size(136, 23);
            Dfuracao1.TabIndex = 14;
            Dfuracao1.SelectedIndexChanged += Dfuracao1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 199);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 15;
            label3.Text = "DN";
            // 
            // Dfuracao2
            // 
            Dfuracao2.Enabled = false;
            Dfuracao2.FormattingEnabled = true;
            Dfuracao2.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA 207 - RESSALTO", "AWWA 207 - LISO" });
            Dfuracao2.Location = new Point(444, 202);
            Dfuracao2.Name = "Dfuracao2";
            Dfuracao2.Size = new Size(136, 23);
            Dfuracao2.TabIndex = 17;
            Dfuracao2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 153);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 20;
            label5.Text = "Classe de pressão";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(70, 107);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 22;
            label7.Text = "Norma ";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(89, 343);
            Result.Name = "Result";
            Result.Size = new Size(109, 29);
            Result.TabIndex = 23;
            Result.Text = "Resultado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(400, 295);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Flanges
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Result);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(Dfuracao2);
            Controls.Add(label3);
            Controls.Add(Dfuracao1);
            Controls.Add(classe_pressao2);
            Controls.Add(classe_pressao1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Norma2);
            Controls.Add(Norma1);
            Controls.Add(label1);
            Name = "Flanges";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Norma1;
        private ComboBox Norma2;
        private Label label2;
        private Button button1;
        private ComboBox classe_pressao1;
        private ComboBox classe_pressao2;
        private ComboBox Dfuracao1;
        private Label label3;
        private ComboBox Dfuracao2;
        private Label label5;
        private Label label7;
        private Label Result;
        private PictureBox pictureBox1;
    }
}