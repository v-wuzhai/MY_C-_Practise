using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[]? TwoSum(int[] numbers, int target)
        {
            int n = numbers.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[i] == 0 || numbers[j] == 0)
                    {
                        continue;
                    }

                    if (numbers[i] + numbers[j] == target)
                    {
                        if (numbers[i] < numbers[j])
                        {
                            return new int[] { numbers[i], numbers[j] };
                        }
                        else
                        {
                            return new int[] { numbers[j], numbers[i] };
                        }
                    }
                }
            }

            MessageBox.Show("Array does not contain have sum for the target value");
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numericUpDown1.Value);
            updateFindButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the numbers from listBox1
            var numbers = listBox1.Items.OfType<decimal>().Select(item => (int)item).ToArray();

            // Get the target number from textBox2
            int target = (int)numericUpDown2.Value;

            // Call the TwoSum function
            var result = TwoSum(numbers, target);

            textBox1.Text = "";
            textBox2.Text = "";

            if (result != null)
            {
                textBox1.Text = result[0].ToString();
                textBox2.Text = result[1].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Remove the selected item
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
            updateFindButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            updateFindButton();
        }

        private void updateFindButton()
        {
            if (listBox1.Items.Count > 0)
            {
                button3.Enabled = true;
                button3.BackColor = Color.LightGreen;
            }
            else
            {
                button3.Enabled = false;
                button3.BackColor = Color.White;
            }
        }
    }
}
