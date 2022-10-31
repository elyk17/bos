using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfShadows
{
    public partial class insideBook : Form
    {
        public insideBook()
        {
            InitializeComponent();
        }

        private void bookpages_Load(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            reset.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTitle.Clear();
            textBody.Clear();

        }
    }
}
