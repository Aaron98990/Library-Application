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
    public partial class Search : Form
    {
        SearchSelect SearchSelectForm;
        Main pf;
        SearchSelect sc;
        String MyOption;
        private string newText;
        private string prompt;
        private string example;

        public Search()
        {
            InitializeComponent();
        }
        public Search(Main parent, String NewText,
String Prompt, String Example)
        {
            InitializeComponent();
            pf = parent;
            menuStrip1.Renderer = new MyRenderer();
            this.Height = 220;
            this.Width = 595;
            this.Location = new Point(980, 380);
            txtPrompt.Text = Prompt;
            lbExample.Text = "Example --> " + Prompt + ": " + Example;
            this.Text = NewText;
           
        }

        public Search(string newText, string prompt, string example)
        {
            this.newText = newText;
            this.prompt = prompt;
            this.example = example;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "Lewis, Makr")
                MessageBox.Show("Value not in database.");
            else
            {
                if (txtValue.Text == "Hicks,")
                {
                    SearchSelectForm = new SearchSelect();
                    SearchSelectForm.Show();
                    SearchSelectForm.MdiParent = pf;
                }
            }
        }
    }
}
