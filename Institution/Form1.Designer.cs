namespace Institution
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 2;
            label1.Text = "Поиск студента";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Введите запрос";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(228, 15);
            label3.TabIndex = 1;
            label3.Text = "Введите запрос по учебному заведению";
            label3.Click += label3_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 71);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(228, 184);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 3;
            label4.Text = "Информация по запросу";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(87, 261);
            button2.Name = "button2";
            button2.Size = new Size(81, 32);
            button2.TabIndex = 4;
            button2.Text = "ПОИСК";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 296);
            label5.Name = "label5";
            label5.Size = new Size(172, 15);
            label5.TabIndex = 5;
            label5.Text = "Нет информации для поиска?";
            label5.Click += label5_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(246, 122);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(109, 19);
            radioButton3.TabIndex = 21;
            radioButton3.TabStop = true;
            radioButton3.Text = "Преподаватель";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(246, 147);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(192, 19);
            radioButton4.TabIndex = 20;
            radioButton4.TabStop = true;
            radioButton4.Text = "Младший научный сотрудник";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(246, 97);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 19);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Специалист";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(246, 72);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Студент";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(438, 320);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Institution";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        public RichTextBox richTextBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}