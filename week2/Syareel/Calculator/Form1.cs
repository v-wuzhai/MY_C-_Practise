namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private double _currentValue = 0;
        private string _currentOperation = "";
        private bool _isOperationPerformed = false;
        private Button[] _digitButtons;

        public Form1()
        {
            InitializeComponent();
            _digitButtons = new Button[10];
            InitializeDigitButtons();
        }

        private void InitializeDigitButtons()
        {
            for (int i = 0; i < 10; i++)
            {
                _digitButtons[i] = new Button();
                _digitButtons[i].Text = i.ToString();
                _digitButtons[i].Size = new System.Drawing.Size(40, 40);
                _digitButtons[i].Location = new System.Drawing.Point(12 + (i % 3) * 50, 50 + (i / 3) * 50);
                _digitButtons[i].Click += new System.EventHandler(this.button_Click);
                this.Controls.Add(_digitButtons[i]);
            }
        }

        private void button_Click(object? sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || _isOperationPerformed)
                textBox_Result.Clear();

            _isOperationPerformed = false;
            Button button = (Button)sender!;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            _currentOperation = button.Text;
            _currentValue = double.Parse(textBox_Result.Text);
            _isOperationPerformed = true;
        }

        private void buttonEquals_Click(object? sender, EventArgs e)
        {
            switch (_currentOperation)
            {
                case "+":
                    textBox_Result.Text = (_currentValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (_currentValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (_currentValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (_currentValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            _currentValue = double.Parse(textBox_Result.Text);
            _currentOperation = "";
        }

        private void buttonClear_Click(object? sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            _currentValue = 0;
            _currentOperation = "";
        }
    }
}
