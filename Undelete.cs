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
    public partial class Undelete : Form
    {
        Main pf;
        public String Description;
        public Undelete()
        {
            InitializeComponent();
        }

        public Undelete(Main parent, String NewText, String NewDescription, String NewRec1, String NewRec2, String NewRec3, String NewRec4, String NewRec5)
        {
            InitializeComponent();
            pf = parent;
            this.Height = 370;
            this.Width = 400;
            txtRec1.Text = NewRec1;
            txtRec2.Text = NewRec2;
            txtRec3.Text = NewRec3;
            txtRec4.Text = NewRec4;
            txtRec5.Text = NewRec5;
            lbDescription.Text = NewDescription;
        }

        public void Update(string Value, string Option)
        {
            if (Option == "Add")
            {
                if (txtRec5.Text == "")
                    txtRec5.Text = Value;
                else
                    txtRec6.Text = Value;
            }
            if (Option == "Edit")
                txtRec5.Text = Value;
        }


        private void SupportingClass_Load(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        //---------------------- Dr. Hicks Initializtion Utilities -----------------------
        #region ----SupportingClass--SupportingClass_Load--MyRenderer--CreateParams ------
        //--------------------------------------------------------------------------------


        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.Black : Color.FromArgb(146, 164, 211);
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);

            }
        }

        public const int CS_NOCLOSE = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete5_Click(object sender, EventArgs e)
        {
            txtRec5.Text = "";
        }


        //--------------------------------------------------------------------------------
        #endregion ------------- Dr. Hicks Initializtion Utilities -----------------------
        //--------------------------------------------------------------------------------

    }
}
