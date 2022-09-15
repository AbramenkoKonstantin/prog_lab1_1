using System.Drawing;
using System.Windows.Forms;

namespace Prog_lab1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonChange.Enabled = false;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonGeneration_Click(object sender, EventArgs e)
        {
            int column = 5;
            int row = 4;
            int[,] matrix = new int[row, column];
            Random random = new Random();

            dataGridViewGeneration.Rows.Clear();
            dataGridViewGeneration.Columns.Clear();

            for (int columnCounter = 0; columnCounter < column; ++columnCounter)
            {
                dataGridViewGeneration.Columns.Add("", "");
            }
            for (int rowCounter = 0; rowCounter < row - 1; ++rowCounter)
            {
                dataGridViewGeneration.Rows.Add();
            }
            
            for (int rowCounter = 0; rowCounter < dataGridViewGeneration.RowCount; ++rowCounter)
            {
                for (int columnCounter = 0; columnCounter < dataGridViewGeneration.ColumnCount; ++columnCounter)
                {
                    matrix[rowCounter, columnCounter] = random.Next(-100, 100);
                    dataGridViewGeneration.Rows[rowCounter].Cells[columnCounter].Value = matrix[rowCounter, columnCounter].ToString();
                }
            }
            buttonChange.Enabled = true;
        }

        static void ChangeRows(int[,] matrix, int firstRow, int rowWithMaxEl)
        {
            int temp;
            int columnCount = matrix.GetLength(1);
            for (int counter = 0; counter < columnCount; ++counter)
            {
                temp = matrix[firstRow, counter];
                matrix[firstRow, counter] = matrix[rowWithMaxEl, counter];
                matrix[rowWithMaxEl, counter] = temp;
            }
        }

        static void ChangeColumns(int[,] matrix, int firstColumn, int columnWithMaxEl)
        {
            int temp;
            int rowCount = matrix.GetLength(0);

            for (int counter = 0; counter < rowCount; ++counter)
            {
                temp = matrix[counter, firstColumn];
                matrix[counter, firstColumn] = matrix[counter, columnWithMaxEl];
                matrix[counter, columnWithMaxEl] = temp;
            }
        }

        static void MaxToOrigin(int[,] matrix)
        {
            int rowIndex = -1;
            int colIndex = -1;
            int? maxVal = null;
            for (int rowCounter = 0; rowCounter < matrix.GetLength(0); ++rowCounter)
            {
                for (int columnCounter = 0; columnCounter < matrix.GetLength(1); ++columnCounter)
                {
                    int thisNum = matrix[rowCounter, columnCounter];
                    if (!maxVal.HasValue || thisNum > maxVal.Value)
                    {
                        maxVal = thisNum;
                        rowIndex = rowCounter;
                        colIndex = columnCounter;
                    }
                }
            }

            if (rowIndex != 0) ChangeRows(matrix, 0, rowIndex);
            if (colIndex != 0) ChangeColumns(matrix, 0, colIndex);
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            int column = 5;
            int row = 4;
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridViewGeneration.Rows[i].Cells[j].Value);
                }
            }

            MaxToOrigin(matrix);

            dataGridViewChange.Rows.Clear();
            dataGridViewChange.Columns.Clear();

            for (int i = 0; i < column; ++i)
            {
                dataGridViewChange.Columns.Add("", "");
            }
            for (int j = 0; j < row - 1; ++j)
            {
                dataGridViewChange.Rows.Add();
            }

            for (int i = 0; i < dataGridViewChange.RowCount; ++i)
            {
                for (int j = 0; j < dataGridViewChange.ColumnCount; ++j)
                {
                    dataGridViewChange.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }
    }
}