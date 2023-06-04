namespace задание_24_бл_схемы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int n = 0, m = 0, a = 0, b = 0;
            try
            {
                n = int.Parse(RowCounts.Text);
                if (n <= 0) throw new Exception("Недостаточное количество строк.");
                m = int.Parse(ColumnCounts.Text);
                if (m <= 0) throw new Exception("Недостаточное количество столбцов.");
                a = int.Parse(FirstDiap.Text);
                b=int.Parse(LastDiap.Text);
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Ошибка",ex.Message);
                return;
            }
              dataGridView1.RowCount = n;
               dataGridView2.RowCount = n;
               dataGridView1.ColumnCount = m;
               dataGridView2.ColumnCount = m;
           /*Для определения/понимания того, что программа все-таки работает
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 4;
            dataGridView1.Rows[0].Cells[0].Value = 7;
            dataGridView1.Rows[0].Cells[1].Value = 1;
            dataGridView1.Rows[0].Cells[2].Value = 5;
            dataGridView1.Rows[0].Cells[3].Value = 3;

            dataGridView1.Rows[1].Cells[0].Value = 3;
            dataGridView1.Rows[1].Cells[1].Value = 2;
            dataGridView1.Rows[1].Cells[2].Value = 6;
            dataGridView1.Rows[1].Cells[3].Value = 4;

            dataGridView1.Rows[2].Cells[0].Value = 5;
            dataGridView1.Rows[2].Cells[1].Value = 2;
            dataGridView1.Rows[2].Cells[2].Value = 8;
            dataGridView1.Rows[2].Cells[3].Value = 6;*/

            for (int i = 0; i < n; i++)
            {
                for(int j=0; j < m; j++)
                {
                  dataGridView1.Rows[i].Cells[j].Value = rand.Next(a, b);
                    dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

        }

        private void FindSPoint_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //Поиск минимального значения в строке
                int minVal = (int)dataGridView1.Rows[i].Cells[0].Value;
                int minIndex = 0;
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    if ((int)dataGridView1.Rows[i].Cells[j].Value < minVal)
                    {
                        minVal = (int)dataGridView1.Rows[i].Cells[j].Value;
                        minIndex = j;
                    }
                }

                //Проверка того, что минимальное значение не повторяется в строке
                bool isSadlPoint = true;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j != minIndex && (int)dataGridView1.Rows[i].Cells[j].Value== minVal)
                    {
                        isSadlPoint = false;
                        break;
                    }
                }

                // Если минимальное значение не повторяется в строке, то проверяем, что оно максимально в столбце
                if (isSadlPoint)
                {
                    int maxVal = (int)dataGridView1.Rows[0].Cells[minIndex].Value;
                    for (int j = 1; j < dataGridView1.RowCount; j++)
                    {
                        if ((int)dataGridView1.Rows[j].Cells[minIndex].Value > maxVal)
                        {
                            maxVal = (int)dataGridView1.Rows[j].Cells[minIndex].Value;
                        }
                    }

                    // Если минимальное значение является максимальным в столбце, то это седловая точка
                    if (maxVal == minVal)
                    {
                        dataGridView2.Rows[i].Cells[minIndex].Style.BackColor = Color.Yellow;
                        count++;
                    }
                }

            }
            if (count == 0) MessageBox.Show("Седловых точек нет");
          
        }
    }
}