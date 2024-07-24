namespace Calculator;

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
        tableLayoutPanel1 = new TableLayoutPanel();
        button20 = new Button();
        button18 = new Button();
        button16 = new Button();
        button15 = new Button();
        button14 = new Button();
        button13 = new Button();
        button12 = new Button();
        button11 = new Button();
        button10 = new Button();
        button9 = new Button();
        button8 = new Button();
        button7 = new Button();
        button6 = new Button();
        button5 = new Button();
        button4 = new Button();
        button2 = new Button();
        richTextBox1 = new RichTextBox();
        button1 = new Button();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(button20, 3, 5);
        tableLayoutPanel1.Controls.Add(button18, 1, 5);
        tableLayoutPanel1.Controls.Add(button16, 3, 4);
        tableLayoutPanel1.Controls.Add(button15, 2, 4);
        tableLayoutPanel1.Controls.Add(button14, 1, 4);
        tableLayoutPanel1.Controls.Add(button13, 0, 4);
        tableLayoutPanel1.Controls.Add(button12, 3, 3);
        tableLayoutPanel1.Controls.Add(button11, 2, 3);
        tableLayoutPanel1.Controls.Add(button10, 1, 3);
        tableLayoutPanel1.Controls.Add(button9, 0, 3);
        tableLayoutPanel1.Controls.Add(button8, 3, 2);
        tableLayoutPanel1.Controls.Add(button7, 2, 2);
        tableLayoutPanel1.Controls.Add(button6, 1, 2);
        tableLayoutPanel1.Controls.Add(button5, 0, 2);
        tableLayoutPanel1.Controls.Add(button4, 3, 1);
        tableLayoutPanel1.Controls.Add(button2, 1, 1);
        tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(button1, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 6;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.Size = new Size(390, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // button20
        // 
        button20.BackColor = Color.FromArgb(255, 224, 192);
        button20.Dock = DockStyle.Fill;
        button20.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button20.Location = new Point(294, 408);
        button20.Name = "button20";
        button20.Size = new Size(93, 39);
        button20.TabIndex = 20;
        button20.Text = "=";
        button20.UseVisualStyleBackColor = false;
        button20.Click += calculate;
        // 
        // button18
        // 
        button18.Dock = DockStyle.Fill;
        button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button18.Location = new Point(100, 408);
        button18.Name = "button18";
        button18.Size = new Size(91, 39);
        button18.TabIndex = 18;
        button18.Text = "0";
        button18.UseVisualStyleBackColor = true;
        button18.Click += digitClicked;
        // 
        // button16
        // 
        button16.Dock = DockStyle.Fill;
        button16.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button16.Location = new Point(294, 363);
        button16.Name = "button16";
        button16.Size = new Size(93, 39);
        button16.TabIndex = 16;
        button16.Text = "÷";
        button16.UseVisualStyleBackColor = true;
        button16.Click += digitClicked;
        // 
        // button15
        // 
        button15.Dock = DockStyle.Fill;
        button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button15.Location = new Point(197, 363);
        button15.Name = "button15";
        button15.Size = new Size(91, 39);
        button15.TabIndex = 15;
        button15.Text = "3";
        button15.UseVisualStyleBackColor = true;
        button15.Click += digitClicked;
        // 
        // button14
        // 
        button14.Dock = DockStyle.Fill;
        button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button14.Location = new Point(100, 363);
        button14.Name = "button14";
        button14.Size = new Size(91, 39);
        button14.TabIndex = 14;
        button14.Text = "2";
        button14.UseVisualStyleBackColor = true;
        button14.Click += digitClicked;
        // 
        // button13
        // 
        button13.Dock = DockStyle.Fill;
        button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button13.Location = new Point(3, 363);
        button13.Name = "button13";
        button13.Size = new Size(91, 39);
        button13.TabIndex = 13;
        button13.Text = "1";
        button13.UseVisualStyleBackColor = true;
        button13.Click += digitClicked;
        // 
        // button12
        // 
        button12.Dock = DockStyle.Fill;
        button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        button12.Location = new Point(294, 318);
        button12.Name = "button12";
        button12.Size = new Size(93, 39);
        button12.TabIndex = 12;
        button12.Text = "x";
        button12.UseVisualStyleBackColor = true;
        button12.Click += digitClicked;
        // 
        // button11
        // 
        button11.Dock = DockStyle.Fill;
        button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button11.Location = new Point(197, 318);
        button11.Name = "button11";
        button11.Size = new Size(91, 39);
        button11.TabIndex = 11;
        button11.Text = "6";
        button11.UseVisualStyleBackColor = true;
        button11.Click += digitClicked;
        // 
        // button10
        // 
        button10.Dock = DockStyle.Fill;
        button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button10.Location = new Point(100, 318);
        button10.Name = "button10";
        button10.Size = new Size(91, 39);
        button10.TabIndex = 10;
        button10.Text = "5";
        button10.UseVisualStyleBackColor = true;
        button10.Click += digitClicked;
        // 
        // button9
        // 
        button9.Dock = DockStyle.Fill;
        button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button9.Location = new Point(3, 318);
        button9.Name = "button9";
        button9.Size = new Size(91, 39);
        button9.TabIndex = 9;
        button9.Text = "4";
        button9.UseVisualStyleBackColor = true;
        button9.Click += digitClicked;
        // 
        // button8
        // 
        button8.Dock = DockStyle.Fill;
        button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button8.Location = new Point(294, 273);
        button8.Name = "button8";
        button8.Size = new Size(93, 39);
        button8.TabIndex = 8;
        button8.Text = "-";
        button8.UseVisualStyleBackColor = true;
        button8.Click += digitClicked;
        // 
        // button7
        // 
        button7.Dock = DockStyle.Fill;
        button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button7.Location = new Point(197, 273);
        button7.Name = "button7";
        button7.Size = new Size(91, 39);
        button7.TabIndex = 7;
        button7.Text = "9";
        button7.UseVisualStyleBackColor = true;
        button7.Click += digitClicked;
        // 
        // button6
        // 
        button6.Dock = DockStyle.Fill;
        button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button6.Location = new Point(100, 273);
        button6.Name = "button6";
        button6.Size = new Size(91, 39);
        button6.TabIndex = 6;
        button6.Text = "8";
        button6.UseVisualStyleBackColor = true;
        button6.Click += digitClicked;
        // 
        // button5
        // 
        button5.Dock = DockStyle.Fill;
        button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button5.Location = new Point(3, 273);
        button5.Name = "button5";
        button5.Size = new Size(91, 39);
        button5.TabIndex = 5;
        button5.Text = "7";
        button5.UseVisualStyleBackColor = true;
        button5.Click += digitClicked;
        // 
        // button4
        // 
        button4.Dock = DockStyle.Fill;
        button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        button4.Location = new Point(294, 228);
        button4.Name = "button4";
        button4.Size = new Size(93, 39);
        button4.TabIndex = 4;
        button4.Text = "+";
        button4.UseVisualStyleBackColor = true;
        button4.Click += digitClicked;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(255, 255, 192);
        button2.Dock = DockStyle.Fill;
        button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button2.Location = new Point(100, 228);
        button2.Name = "button2";
        button2.Size = new Size(91, 39);
        button2.TabIndex = 2;
        button2.Text = "Delete";
        button2.UseVisualStyleBackColor = false;
        button2.Click += delete;
        // 
        // richTextBox1
        // 
        richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(richTextBox1, 4);
        richTextBox1.Font = new Font("Segoe UI", 20F);
        richTextBox1.Location = new Point(5, 5);
        richTextBox1.Margin = new Padding(5);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.RightToLeft = RightToLeft.No;
        richTextBox1.Size = new Size(380, 215);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(255, 192, 192);
        button1.Dock = DockStyle.Fill;
        button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button1.Location = new Point(3, 228);
        button1.Name = "button1";
        button1.Size = new Size(91, 39);
        button1.TabIndex = 1;
        button1.Text = "Reset";
        button1.UseVisualStyleBackColor = false;
        button1.Click += reset;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(390, 450);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private RichTextBox richTextBox1;
    private Button button20;
    private Button button18;
    private Button button16;
    private Button button15;
    private Button button14;
    private Button button13;
    private Button button12;
    private Button button11;
    private Button button10;
    private Button button9;
    private Button button8;
    private Button button7;
    private Button button6;
    private Button button5;
    private Button button4;
    private Button button2;
    private Button button1;
}
