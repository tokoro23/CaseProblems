// TK
// Date: 2/9/18
// Chapter 4 Case Problem 1
// Modified Ch3 case problem with addition of if-else

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_CaseProblem1
{
    public partial class GreenvilleRevGUI2 : Form
    {
        public GreenvilleRevGUI2()
        {
            InitializeComponent();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            int conNum1 = Convert.ToInt32(lastYearTextBox.Text);
            int conNum2 = Convert.ToInt32(thisYearTextBox.Text);
            int lastRev = conNum1 * 25;
            int thisRev = conNum2 * 25;

            string compMes;
            if (conNum2 > (2 * conNum1))
                compMes = "Compared to last year, the competition is over twice as large!";
            else if (conNum2 > conNum1)
                compMes = "The competition is bigger than ever!";
            else if (conNum2 < conNum1)
                compMes = "A tighter race this year! Come out and cast your vote!";
            else
                compMes = "The competition is the same as last year.";

            resultsLabel.Text = String.Format("With an entrance fee of $25..." +
                "\nLast year's revenue was: ${0}" +
                "\nand this year's revenue estimate is: ${1}" +
                "\n{2}", lastRev, thisRev, compMes);
            resultsLabel.Visible = true;
        }
    }
}
