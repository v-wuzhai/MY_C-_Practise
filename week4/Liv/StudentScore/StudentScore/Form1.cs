using System.Data;
using System.Windows.Forms;

namespace StudentScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadCsvIntoDataGridView(string filePath, DataGridView dataGridView)
        {
            var dataTable = new DataTable();

            using (var reader = new StreamReader(filePath))
            {
                // Read the header line
                var headers = reader.ReadLine().Split(',');
                foreach (var header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Read the rest of the file
                while (!reader.EndOfStream)
                {
                    var rows = reader.ReadLine().Split(',');
                    dataTable.Rows.Add(rows);
                }
            }

            dataGridView.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = openFileDialog1.FileName;
                LoadCsvIntoDataGridView(filepath.Text, dataGridView1);
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            switch (comboBoxAction.SelectedItem)
            {
                case "Student total score":
                    UpdateDataGridViewWithStudentTotalScores();
                    return;
                case "Student Passes all subjects":
                    UpdateDataGridViewWithPassedStudent();
                    break;
                case "Top 3 student by total score":
                    UpdateDataGridViewWithTop3Student();
                    return;
                default:
                    MessageBox.Show("Please select an action.");
                    return;
            }
        }

        private void UpdateDataGridViewWithStudentTotalScores()
        {
            // Assuming your DataGridView is bound to a DataTable
            LoadCsvIntoDataGridView(filepath.Text, dataGridView1);
            DataTable dataTable = (DataTable)dataGridView1.DataSource;


            if (dataTable != null)
            {
                dataTable.Columns.Add("TotalScore", typeof(double));
                // Use LINQ to calculate the total score for each row
                var rows = dataTable.AsEnumerable();
                foreach (var row in rows)
                {
                    double totalScore = new[] { "MathScore", "EnglishScore", "ProgrammingScore" }
                                        .Sum(column =>
                                        {
                                            double value;
                                            return double.TryParse(row.Field<string>(column), out value) ? value : 0;
                                        });
                    row["TotalScore"] = totalScore;
                }

                dataTable.Columns.Remove("MathScore");
                dataTable.Columns.Remove("EnglishScore");
                dataTable.Columns.Remove("ProgrammingScore");
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("The DataTable is empty.");
            }

        }

        private void UpdateDataGridViewWithPassedStudent()
        {
            LoadCsvIntoDataGridView(filepath.Text, dataGridView1);
            DataTable dataTable = (DataTable)dataGridView1.DataSource;


            if (dataTable != null)
            {
                // Use LINQ to filter the rows where all three scores are greater than 60
                var rows = dataTable.AsEnumerable()
                                    .Where(row =>
                                        double.TryParse(row.Field<string>("MathScore"), out double mathScore) && mathScore > 60 &&
                                        double.TryParse(row.Field<string>("EnglishScore"), out double englishScore) && englishScore > 60 &&
                                        double.TryParse(row.Field<string>("ProgrammingScore"), out double programmingScore) && programmingScore > 60)
                                    .ToList();

                // Create a new DataTable to store the filtered rows
                var filteredDataTable = dataTable.Clone();

                foreach (var row in rows)
                {
                    filteredDataTable.ImportRow(row);
                }

                filteredDataTable.Columns.Remove("MathScore");
                filteredDataTable.Columns.Remove("EnglishScore");
                filteredDataTable.Columns.Remove("ProgrammingScore");
                // Update the DataGridView to reflect the changes
                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {
                MessageBox.Show("The DataTable is empty.");
            }

        }

        private void UpdateDataGridViewWithTop3Student()
        {
            // Assuming your DataGridView is bound to a DataTable
            LoadCsvIntoDataGridView(filepath.Text, dataGridView1);
            DataTable dataTable = (DataTable)dataGridView1.DataSource;


            if (dataTable != null)
            {
                dataTable.Columns.Add("TotalScore", typeof(double));
                // Calculate the total score for each row
                var rows = dataTable.AsEnumerable();
                foreach (var row in rows)
                {
                    double totalScore = new[] { "MathScore", "EnglishScore", "ProgrammingScore" }
                                        .Sum(column =>
                                        {
                                            double value;
                                            return double.TryParse(row.Field<string>(column), out value) ? value : 0;
                                        });
                    row["TotalScore"] = totalScore;
                }

                // Sort the rows by total score in descending order and take the top 3
                var top3Rows = rows.OrderByDescending(row => row.Field<double>("TotalScore")).Take(3).CopyToDataTable();

                // Remove the original columns if needed
                top3Rows.Columns.Remove("MathScore");
                top3Rows.Columns.Remove("EnglishScore");
                top3Rows.Columns.Remove("ProgrammingScore");

                // Update the DataGridView to reflect the changes
                dataGridView1.DataSource = top3Rows;
            }
            else
            {
                MessageBox.Show("The DataTable is empty.");
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            LoadCsvIntoDataGridView(filepath.Text, dataGridView1);
        }
    }
}
