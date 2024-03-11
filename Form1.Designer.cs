namespace zad1
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
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 63);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Czy pesel prawidlowy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 63);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 99);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 3;
            label3.Text = "Wprowadz pesel";
            // 
            // button1
            // 
            button1.Location = new Point(97, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Sprawdz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 63);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "Plec";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 95);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Kobieta";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(317, 120);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Mezczyzna";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 213);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Data urodzenia";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 245);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "Dzien";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 245);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 11;
            label7.Text = "Miesiac";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 245);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 12;
            label8.Text = "Rok";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(317, 266);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}