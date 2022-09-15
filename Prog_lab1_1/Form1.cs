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

            for (int columnAddCounter = 0; columnAddCounter < column; ++columnAddCounter)
            {
                dataGridViewGeneration.Columns.Add("", "");
            }
            for (int rowAddCounter = 0; rowAddCounter < row - 1; ++rowAddCounter)
            {
                dataGridViewGeneration.Rows.Add();
            }
            
            for (int rowGenCounter = 0; rowGenCounter < dataGridViewGeneration.RowCount; ++rowGenCounter)
            {
                for (int columnGenCounter = 0; columnGenCounter < dataGridViewGeneration.ColumnCount; ++columnGenCounter)
                {
                    matrix[rowGenCounter, columnGenCounter] = random.Next(-100, 100);
                    dataGridViewGeneration.Rows[rowGenCounter].Cells[columnGenCounter].Value = matrix[rowGenCounter, columnGenCounter].ToString();
                }
            }
            buttonChange.Enabled = true;
        }

        static void ChangeRows(int[,] matrix, int firstRow, int rowWithMaxEl)
        {
            int temp;
            int columnCount = matrix.GetLength(1);

            for (int columnCounter = 0; columnCounter < columnCount; ++columnCounter)
            {
                temp = matrix[firstRow, columnCounter];
                matrix[firstRow, columnCounter] = matrix[rowWithMaxEl, columnCounter];
                matrix[rowWithMaxEl, columnCounter] = temp;
            }
        }

        static void ChangeColumns(int[,] matrix, int firstColumn, int columnWithMaxEl)
        {
            int temp;
            int rowCount = matrix.GetLength(0);

            for (int rowCounter = 0; rowCounter < rowCount; ++rowCounter)
            {
                temp = matrix[rowCounter, firstColumn];
                matrix[rowCounter, firstColumn] = matrix[rowCounter, columnWithMaxEl];
                matrix[rowCounter, columnWithMaxEl] = temp;
            }
        }

        static void MaxToOrigin(int[,] matrix)
        {
            int rowIndex = -1;
            int colIndex = -1;
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            int maxVal = matrix[0, 0];
            int firstRow = 0;
            int firstColumn = 0;

            for (int rowCounter = 0; rowCounter < rowCount; ++rowCounter)
            {
                for (int columnCounter = 0; columnCounter < columnCount; ++columnCounter)
                {
                    int thisNum = matrix[rowCounter, columnCounter];
                    if (thisNum > maxVal)
                    {
                        maxVal = thisNum;
                        rowIndex = rowCounter;
                        colIndex = columnCounter;
                    }
                }
            }

            if (rowIndex != firstRow) ChangeRows(matrix, firstRow, rowIndex);
            if (colIndex != firstColumn) ChangeColumns(matrix, firstColumn, colIndex);
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            int column = 5;
            int row = 4;
            int[,] matrix = new int[row, column];

            for (int rowMatrixCounter = 0; rowMatrixCounter < row; ++rowMatrixCounter)
            {
                for (int columnMatrixCounter = 0; columnMatrixCounter < column; ++columnMatrixCounter)
                {
                    matrix[rowMatrixCounter, columnMatrixCounter] = Convert.ToInt32(dataGridViewGeneration.Rows[rowMatrixCounter].Cells[columnMatrixCounter].Value);
                }
            }

            MaxToOrigin(matrix);

            dataGridViewChange.Rows.Clear();
            dataGridViewChange.Columns.Clear();

            for (int columnAddCounter = 0; columnAddCounter < column; ++columnAddCounter)
            {
                dataGridViewChange.Columns.Add("", "");
            }
            for (int rowAddCounter = 0; rowAddCounter < row - 1; ++rowAddCounter)
            {
                dataGridViewChange.Rows.Add();
            }

            for (int rowChangeCounter = 0; rowChangeCounter < dataGridViewChange.RowCount; ++rowChangeCounter)
            {
                for (int colunmChangeCounter = 0; colunmChangeCounter < dataGridViewChange.ColumnCount; ++colunmChangeCounter)
                {
                    dataGridViewChange.Rows[rowChangeCounter].Cells[colunmChangeCounter].Value = matrix[rowChangeCounter, colunmChangeCounter].ToString();
                }
            }
        }
    }
}