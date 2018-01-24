// TK
// Date: 1/23/18
// Chapter 3 Case Problem 1
/* Working with partner WIP; to do: maybe align results better
   and use currency string formatting on revenue dollar amounts. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_CaseProblem1
{
    public partial class GreenvilleRevGUI : Form
    {
        public GreenvilleRevGUI()
        {
            InitializeComponent();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            int conNum1 = Convert.ToInt32(lastYearTextBox.Text);
            int conNum2 = Convert.ToInt32(thisYearTextBox.Text);
            int lastRev = conNum1 * 25;
            int thisRev = conNum2 * 25;
            resultsLabel.Text = String.Format("With an entrance fee of $25..." +
                "\nLast year's revenue was: ${0}" +
                "\nand this year's revenue estimate is: ${1}", lastRev, thisRev);
            resultsLabel.Visible = true;
        }
    }
}
