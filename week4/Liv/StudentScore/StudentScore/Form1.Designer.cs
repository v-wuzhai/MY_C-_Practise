namespace StudentScore
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
            dataGridView1 = new DataGridView();
            filepath = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            browse = new Button();
            comboBoxAction = new ComboBox();
            Generate = new Button();
            Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 344);
            dataGridView1.TabIndex = 0;
           
            // 
            // filepath
            // 
            filepath.Location = new Point(11, 33);
            filepath.Name = "filepath";
            filepath.Size = new Size(513, 23);
            filepath.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 2;
            label1.Text = "Data source file (.csv) :";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Excel and CSV Files|*.xls;*.xlsx;*.csv";
            // 
            // browse
            // 
            browse.Location = new Point(530, 33);
            browse.Name = "browse";
            browse.Size = new Size(75, 23);
            browse.TabIndex = 3;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // comboBoxAction
            // 
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Items.AddRange(new object[] { "Student total score", "Student Passes all subjects", "Top 3 student by total score" });
            comboBoxAction.Location = new Point(11, 73);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new Size(436, 23);
            comboBoxAction.TabIndex = 1;
            comboBoxAction.Text = "Select Action";
            // 
            // Generate
            // 
            Generate.BackColor = Color.FromArgb(192, 255, 192);
            Generate.Location = new Point(453, 72);
            Generate.Name = "Generate";
            Generate.Size = new Size(75, 23);
            Generate.TabIndex = 4;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = false;
            Generate.Click += Generate_Click;
            // 
            // Reset
            // 
            Reset.BackColor = Color.FromArgb(255, 192, 192);
            Reset.Location = new Point(530, 73);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 5;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 475);
            Controls.Add(Reset);
            Controls.Add(Generate);
            Controls.Add(comboBoxAction);
            Controls.Add(browse);
            Controls.Add(label1);
            Controls.Add(filepath);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox filepath;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button browse;
        private ComboBox comboBoxAction;
        private Button Generate;
        private Button Reset;
    }
}
