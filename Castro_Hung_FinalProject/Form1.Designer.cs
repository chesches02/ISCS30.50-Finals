namespace Castro_Hung_FinalProject
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Website";
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Location = new Point(29, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 26);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(29, 113);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(29, 165);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(844, 179);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 25);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.Location = new Point(207, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 25);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.Location = new Point(385, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(207, 113);
            button3.Name = "button3";
            button3.Size = new Size(150, 34);
            button3.TabIndex = 18;
            button3.Text = "Delecte Selected";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
    }
}
