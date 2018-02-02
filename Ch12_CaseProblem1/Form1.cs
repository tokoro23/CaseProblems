// TK
// Date: 2/1/18
// Chapter 12 Case Problem 1
// General Form layout based on partner's GitHub files.
// Added decorations, dateTimePicker, and some different text/fonts/colors.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_CaseProblem1
{
    public partial class GreenvilleAdForm : Form
    {
        public GreenvilleAdForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string nameEntry = nameTextBox.Text;
            resultLabel.Text = String.Format("Thank you, {0}!" +
                "\nYour form has been submitted.", nameEntry);
            resultLabel.Visible = true;
        }
    }
}
