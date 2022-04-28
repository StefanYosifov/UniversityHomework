using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateNumbers();
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
        }

        List<int> randomNums=new List<int>(); 
        private void generateNumbers()
        {
            Random random = new Random();
            while (randomNums.Count < 5)
            {
                int randomNumber = random.Next(1, 26);
                if (!randomNums.Contains(randomNumber))
                {
                    randomNums.Add(randomNumber);
                }
            }
        }
        int attempts = 0;
        int wins = 0;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int getCurrentCell = 0;
            if (e.ColumnIndex == 0)
            {
                getCurrentCell = 1+e.RowIndex;
            }
            if(e.ColumnIndex == 1)
            {
                getCurrentCell = 6 + e.RowIndex;
            }
            if (e.ColumnIndex == 2)
            {
                getCurrentCell = 11 + e.RowIndex;
            }
            if (e.ColumnIndex == 3)
            {
                getCurrentCell = 16 + e.RowIndex;
            }
            if (e.ColumnIndex == 4)
            {
                getCurrentCell = 21 + e.RowIndex;
            }
            if (randomNums.Contains(getCurrentCell))
            {
                dataGridView1[e.ColumnIndex,e.RowIndex].Value = "X";
                wins++;
                label1.Text = wins.ToString();
                if (wins >= 5)
                {
                    MessageBox.Show($"Congratulations you have won.\nIt took you {attempts} attempts");
                    return;
                }
            }
            else
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = "O";
            }
            attempts++;
            label2.Text =attempts.ToString();
        }

        
    }
}
