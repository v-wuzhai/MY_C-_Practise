using System.Linq.Expressions;

namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void digitClicked(object sender, EventArgs e)
    {
        richTextBox1.Text += ((Button)sender).Text;
    }

    private void calculate(object sender, EventArgs e)
    {
        //FILTER 
        string expression = richTextBox1.Text.Replace('x', '*');
        expression = expression.Replace('÷', '/');
        var result = new System.Data.DataTable().Compute(expression, null);
        richTextBox1.Text += "\n= " + result.ToString();
    }

    private void delete(object sender, EventArgs e)
    {
        if (richTextBox1.Text.Length > 0)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
        }
    }

    private void reset(object sender, EventArgs e)
    {
        richTextBox1.Text = "";
    }
}
