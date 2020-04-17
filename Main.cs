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
    public partial class Main : Form
    {
        public User UserForm;
        public bool UserInViewMode = true;
        public bool UerInEditMode = false;
        public bool UserInAddMode = false;
        public SupportingClass SupportingClassForm;
        public Undelete UndeleteForm;
        public Search SearchForm;

        public String UserName = "thicks";
        public long Password = 12345;

        public void LaunchSupportingClassWindow(String NewText, String NewDescription, 
                    String NewRec1, String NewRec2, String NewRe3, String NewRec4, String NewRec5)
            { SupportingClassForm = new SupportingClass(this, NewText, NewDescription, 
                NewRec1, NewRec2, NewRe3, NewRec4, NewRec5);
                SupportingClassForm.MdiParent = this;
                SupportingClassForm.Show();
                SupportingClassForm.Location = new Point(980, 0);
                SupportingClassForm.Text = NewText;
        }

        public void LaunchUndeleteWindow(String NewText, String NewDescription,
 String NewRec1, String NewRec2, String NewRe3, String NewRec4, String NewRec5)
        {
            UndeleteForm = new Undelete(this, NewText, NewDescription,
            NewRec1, NewRec2, NewRe3, NewRec4, NewRec5);
            UndeleteForm.MdiParent = this;
            UndeleteForm.Show();
            UndeleteForm.Location = new Point(980, 0);
            UndeleteForm.Text = NewText;
        }

        public void LaunchSearchWindow(String NewText, String Prompt, String Example)
        {
            SearchForm = new Search(NewText, Prompt, Example); 
            SearchForm.MdiParent = this;
            SearchForm.Show();
            SearchForm.Location = new Point(300, 200);
        }

        //--------------------------------------------------------------------------------
        //---------------------- Aaron's Initializtion Utilities -----------------------
        #region ----Main--Main_Load--MyRenderer--MyColors--CreateParams ------------------
        //--------------------------------------------------------------------------------


        public Main()
        {
            InitializeComponent();
            UserForm = new User(this);
            UserForm.MdiParent = this;
            menuStrip1.Renderer = new MyRenderer();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();
        }

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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //===========================================================================//
        //==                                CreateParams                           ==//
        //===========================================================================//
        //== Purpose: Block of code to disable the close box on a form and yet     ==//
        //== control minimize and maximize functionality.                          ==//
        //==                                                                       ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10                ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017                              ==//
        //===========================================================================//
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

        public bool UserInEditMode { get; internal set; }

        private void UserSubSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Main(SearchSelect v)
        {
            throw new NotImplementedException();
        }




        //--------------------------------------------------------------------------------
        #endregion ------------- Aaron's Initializtion Utilities -----------------------
        //--------------------------------------------------------------------------------

    }
}
