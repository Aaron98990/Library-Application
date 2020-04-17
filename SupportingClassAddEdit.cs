using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class SupportingClassAddEdit : Form
    {


        SupportingClass sc;
        String MyOption;
        public SupportingClassAddEdit()
        {
            InitializeComponent();
        }

        public SupportingClassAddEdit(SupportingClass parent, String NewDescription,
 String Option, String NewValue)
        {
            InitializeComponent();
            sc = parent;
            this.Height = 170;
            this.Width = 400;
            this.Location = new Point(980, 380);
            Text = Option + " " + NewDescription;
            lbDescription.Text = NewDescription;
            txtValue.Text = NewValue;
            MyOption = Option;
        }

        private void SupportingClassAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sc.Update(txtValue.Text, MyOption);
            this.Close();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
