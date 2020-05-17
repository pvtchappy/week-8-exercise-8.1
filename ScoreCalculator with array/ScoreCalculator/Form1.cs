using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] scores = new int[20];
        int total = 0;
        int count = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(txtScore.Text);
            scores[count] = score;
            total += score;
            count += 1;
            int average = total / count;
            txtScoreTotal.Text = total.ToString();
            txtScoreCount.Text = count.ToString();
            txtAverage.Text = average.ToString();
            txtScore.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Focus();
            int[] scores = new int[20];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(scores);

            string message = "";
            foreach (int number in scores)
            {
                if (number != 0)
                    message += number + "\n";
            }
            MessageBox.Show(message + "\n", "Sorted Scores");

            txtScore.Focus();

            this.Close();
        }
    }
}