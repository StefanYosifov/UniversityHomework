using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        List<int> list = new List<int>();
       

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int numFromTextBox = 0;
            int.TryParse(textBox1.Text, out numFromTextBox);
           
            if (numFromTextBox < 3 || numFromTextBox > 30)
            {
                MessageBox.Show("Input number must be between 3 and 30");
                return;
            }

            list.Add(1);
            list.Add(1);
            listBox1.Items.Add(1);
            listBox1.Items.Add(1);
            
            

            for(int i = 2; i < numFromTextBox; i++)
            {
                list.Add(list[i - 1] + list[i - 2]);
                listBox1.Items.Add(list[i]);
            }
            
        }
    }
}
