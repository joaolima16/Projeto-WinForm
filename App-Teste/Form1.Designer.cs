namespace App_Teste
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
            StandardOne = new ComboBox();
            StandardTwo = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Norma1";
            // 
            // StandardOne
            // 
            StandardOne.FormattingEnabled = true;
            StandardOne.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA C207" });
            StandardOne.Location = new Point(226, 65);
            StandardOne.Name = "StandardOne";
            StandardOne.Size = new Size(136, 23);
            StandardOne.TabIndex = 2;
            StandardOne.SelectedIndexChanged += StandardOne_SelectedIndexChanged;
            // 
            // StandardTwo
            // 
            StandardTwo.FormattingEnabled = true;
            StandardTwo.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA C207" });
            StandardTwo.Location = new Point(438, 65);
            StandardTwo.Name = "StandardTwo";
            StandardTwo.Size = new Size(136, 23);
            StandardTwo.TabIndex = 3;
            StandardTwo.SelectedIndexChanged += StandardTwo_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(438, 154);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 26);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(226, 202);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(438, 202);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 26);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(345, 246);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 26);
            textBox5.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 29);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Norma2";
            // 
            // button1
            // 
            button1.Location = new Point(333, 306);
            button1.Name = "button1";
            button1.Size = new Size(159, 34);
            button1.TabIndex = 11;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA 207 - RESSALTO", "AWWA 207 - LISO" });
            comboBox3.Location = new Point(226, 111);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(136, 23);
            comboBox3.TabIndex = 12;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(438, 111);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(136, 23);
            comboBox4.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DIN", "ISO2531", "AWWA 207 - RESSALTO", "AWWA 207 - LISO" });
            comboBox1.Location = new Point(226, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(StandardTwo);
            Controls.Add(StandardOne);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox StandardOne;
        private ComboBox StandardTwo;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
    }
}