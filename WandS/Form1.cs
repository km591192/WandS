using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WandS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Solution solution = new Solution();
        private void btncalc_Click(object sender, EventArgs e)
        {
            string [] input = tbdata.Text.Trim().Split(',', ' ', '.', ';',':');
            int [] t = new int [input.Length];
            int j = 0;
            for(int i = 0; i < input.Length;i++)
            {
                bool IsDigit = input[i].Length == input[i].Where(c => char.IsLetter(c)).Count();
                if (IsDigit == false)
                {
                    t[j] = Convert.ToInt32(input[i]);
                    j++;
                }
                else 
                {
                    t[j] = 1000000;
                    j++;
                }
            }

            label_answer.Text = "Answer = ";
            t = t.Where(x => x != 1000000).ToArray();
            label_answer.Text = solution.solution(t).ToString();
        }
    }
}
