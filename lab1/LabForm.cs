using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SequenceLibrary;

namespace LabFormApplication
{
    public partial class LabForm : Form
    {
        public LabForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] str_numbers = textBox1.Text.Split(' ');
            var numbers = new List<int>();

            int parsedNum;
            foreach (string str_num in str_numbers)
            {              
                if (int.TryParse(str_num, out parsedNum)) {
                    numbers.Add(parsedNum);
                } else
                {
                    label1.Text = "Недопустимый формат данных";
                    return;
                }
            }

            if (numbers.Count < 2)
            {
                label1.Text = "Последовательность должна содержать хотя бы 2 числовых эл-та";
                return;
            }

            var SequenceWorker = new NumberSequence();

            if (SequenceWorker.СheckIfSequenceIncreasing(numbers.ToArray()))
            {
                label1.Text = "Последовательность чисел являетсся строго возрастающей";
            } else
            {
                label1.Text = "Последовательность чисел не является строго возрастающей";
            }

        }
    }
}
