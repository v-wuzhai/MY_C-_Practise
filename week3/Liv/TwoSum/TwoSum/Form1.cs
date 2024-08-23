namespace TwoSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<int[]>? TwoSum(int[] numbers, int target)
        {
            int n = numbers.Length;
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //if (numbers[i] == 0 || numbers[j] == 0)
                    //{
                    //    continue;
                    //}

                    if (numbers[i] + numbers[j] == target)
                    {
                        result.Add(new int[] { i + 1, j + 1 });
                        //if (numbers[i] < numbers[j])
                        //{

                        //}
                        //else
                        //{
                        //    result.Add(new int[] { numbers[j], numbers[i] });
                        //}
                    }
                }
            }

            if (result.Count == 0)
            {
                MessageBox.Show("Array does not contain have sum for the target value");
                return null;
            }

            return result;
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
            var results = TwoSum(numbers, target);

            richTextBox1.Text = "";

            if (results != null)
            {
                //update result
                foreach (var result in results)
                {
                    richTextBox1.Text = richTextBox1.Text + $"Index 1 : {result[0]}\nIndex 2 : {result[1]}\n\n";
                }
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

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
