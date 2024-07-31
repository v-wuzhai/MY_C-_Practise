namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string OperationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || (isOperationPerformed))
                tbDisplayResult.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else
            {
                tbDisplayResult.Text += button.Text;

            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            OperationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayResult.Text);
            lbCurrentOp.Text = resultValue + " " + OperationPerformed;
            isOperationPerformed = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (OperationPerformed == "+")
            {
                tbDisplayResult.Text = (resultValue + double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (OperationPerformed == "-")
            {
                tbDisplayResult.Text = (resultValue - double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (OperationPerformed == "X")
            {
                tbDisplayResult.Text = (resultValue * double.Parse(tbDisplayResult.Text)).ToString();
            }
            else
            {
                tbDisplayResult.Text = (resultValue / double.Parse(tbDisplayResult.Text)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text.Length > 0)
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);

            if (tbDisplayResult.Text == "")
                tbDisplayResult.Text = "0";
        }
    }
}
