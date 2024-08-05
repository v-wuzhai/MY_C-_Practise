namespace WinFormsApp234
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(117, 94);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(98, 23);
            button1.Name = "button1";
            button1.Size = new Size(41, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(22, 22);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(18, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 184);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numbers";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.Location = new Point(81, 152);
            button4.Name = "button4";
            button4.Size = new Size(58, 23);
            button4.TabIndex = 7;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(22, 152);
            button2.Name = "button2";
            button2.Size = new Size(58, 23);
            button2.TabIndex = 6;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Location = new Point(18, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 67);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Target";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(22, 25);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(116, 23);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(209, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(183, 114);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Result";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 72);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 75);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Index 2 :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 28);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 31);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Index 1 :";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Enabled = false;
            button3.Location = new Point(209, 28);
            button3.Name = "button3";
            button3.Size = new Size(183, 23);
            button3.TabIndex = 0;
            button3.Text = "Find";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 290);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private Button button2;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBox3;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
    }
}
