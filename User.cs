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
    public partial class User : Form
    {

        Main pf;

        bool Testing = false;
        String Database = "Trinity";
        long Port = 12345;
        bool DataToggle = true;
        String QuickLinkText = "Full Name";

        //public User UserForm;


        //public String UserName = "thicks";
        //public long Password = 12345;

       





        public User(Main parent)
        {
            InitializeComponent();
            pf = parent;
        }

        public User()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------------------------------
        //---------------------- Dr. Hicks Initializtion Utilities -----------------------
        #region ----User--User_Load--MyRenderer--MyColors--CreateParams ------------------ 
        //--------------------------------------------------------------------------------




        //===========================================================================//
        //== PopulateDeptIDComboBox ==//
        //===========================================================================//
        //== Purpose: Use a Dictionary to populate the cbDeptID ComboBox with ==//
        //== Department Names and IDs. ==//
        //== ==//
        //== Written By: Dr.Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//

        public void PopulateDeptIDComboBox()
        {

            Dictionary<Int32, String> departments = new Dictionary<Int32, String>();
            departments.Add(0, "--- Select Major ---");
            departments.Add(9, "Biology");
            departments.Add(1, "Computer Science");
            departments.Add(20, "Engineering");
            departments.Add(3, "Math");
            departments.Add(4, "Physics");

            cbDeptID.DataSource = new BindingSource(departments, null);
            cbDeptID.DisplayMember = "Value";
            cbDeptID.ValueMember = "Key";
            cbDeptID.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void User_Load(object sender, EventArgs e)
        {


            menuStrip1.Renderer = new MyRenderer();
            PopulateDeptIDComboBox();
            ProcessDataToggle();
            ReloadQuickLinkToolTips();
            ViewMode();
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
        //--------------------------------------------------------------------------------
        #endregion ------------- Dr. Hicks MySQL Initializtion Utilities -----------------
        //--------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------
        //--------------------- Dr. Hicks Functions For lbTrace --------------------------
        #region -----lbTraceLine-lbTraceNote----------------------------------------------
        //--------------------------------------------------------------------------------
        //================================================================================//
        // lbTraceLine //
        //================================================================================//
        // Purpose: Helper function for lbTraceNote. //
        //================================================================================//
        public void lbTraceLine(String Note, String ch = "=")
        {
            int len = Note.Length;
            if (len <= 0)
                return;
            String newStr = ch + ch;
            int Padding = Convert.ToInt16(18 - 0.5 * Note.Length);
            for (int pos = 1; pos <= Padding; pos++)
                newStr = newStr + " ";
            newStr = newStr + Note;
            while (newStr.Length < 38)
                newStr = newStr + " ";
            newStr = newStr + ch + ch;
            lbTrace.Items.Add(newStr);
        }
        //================================================================================//
        // lbTraceNote //
        //================================================================================//
        // Purpose: Dr. Hicks routine for producing boxed output in lbTrace. //
        //================================================================================//

        public void lbTraceNote(String ch, String Note1, String Note2 = "", String Note3 = "",
String Note4 = "", String Note5 = "")
        {
            if (ch == "=")
                lbTrace.Items.Add("========================================");
            else
            {
                lbTrace.Items.Add(" ");
                lbTrace.Items.Add("----------------------------------------");
            }
            lbTraceLine(Note1, ch);
            lbTraceLine(Note2, ch);
            lbTraceLine(Note3, ch);
            lbTraceLine(Note4, ch);
            lbTraceLine(Note5, ch);
            if (ch == "=")
                lbTrace.Items.Add("========================================");
            else
                lbTrace.Items.Add("----------------------------------------");
        }
        //--------------------------------------------------------------------------------
        #endregion ------------ End Dr. Hicks lbTrace Functions ------------------------
        //--------------------------------------------------------------------------------


        // --------------------------------------------------------------------------------
        //---------------------- Dr.Hicks Diagnostic Testing ------------------------------
        #region ----TestingMaster-TestModule1, TestModule2, ... ---------------------------
        // --------------------------------------------------------------------------------
        //===========================================================================//
        //== TestingMaster ==//
        //===========================================================================//
        //== Purpose: Testing Master which evokes TestModule1, TestModule2, ... ==//
        //== ==//
        //== ==//
        //== Written By: Dr.Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        public void TestingMaster()
        {
            int UserClassDiagnosticLevel = 5;
            if ((UserClassDiagnosticLevel <= 1) || (UserClassDiagnosticLevel == -1))
                TestModule1();
            //if ((UserClassDiagnosticLevel <= 2) || (UserClassDiagnosticLevel == -1))
            //TestModule2();
            if ((UserClassDiagnosticLevel <= 3) || (UserClassDiagnosticLevel == -1))
                TestModule3();
            if ((UserClassDiagnosticLevel <= 4) || (UserClassDiagnosticLevel == -1))
                TestModule4();
            if ((UserClassDiagnosticLevel <= 5) || (UserClassDiagnosticLevel == -1))
                TestModule5();
        }
        //===========================================================================//
        //== Test Module 1 - Testing llbTrace Functions ==//
        //===========================================================================//
        //== Purpose: Use the lbTrace Functions to display the contents of all of ==//
        //== the local variables in Users.cs ==//
        //===========================================================================//
        public void TestModule1()
        {
            lbTraceNote("-", "Test Module 1", "Testing lbTrace Functions", "Display User Variables");
            lbTrace.Items.Add("Testing ....... = " + Testing.ToString());
            lbTrace.Items.Add("Database ...... = " + Database);
            lbTrace.Items.Add("Port........... = " + Port.ToString());
            lbTrace.Items.Add("DataToggle .... = " + DataToggle.ToString());
            lbTrace.Items.Add("QuickLinkText.. = " + QuickLinkText);
            lbTrace.Items.Add("");
        }

        //===========================================================================//
        //== Test Module 2 - Testing llbTrace Functions ==//
        //===========================================================================//
        //== Purpose: Use the lbTrace Functions to display the contents of all of ==//
        //== the local variables in Users.cs ==//
        //===========================================================================//

        /*
    public void TestModule2()
    {
        lbTraceNote("-", "Test Module 2", "Testing Parent-Child", "Communication");
        lbTrace.Items.Add("pf.UserName ......... = " + pf.UserName);
        lbTrace.Items.Add("pf.UserName ......... = " + pf.Password.ToString());
        lbTrace.Items.Add("");
    }

*/

        //===========================================================================//
        //== Test Module 3 - Testing ComboBox Controls ==//
        //===========================================================================//
        //== Purpose: Display the selections of all ComboBox Controls ==//
        //===========================================================================//
        public void TestModule3()
        {
            lbTraceNote("-", "Test Module 3", "ComboBox Control", "Settings");
            lbTrace.Items.Add("cbOrderBy.Text ....... = " + cbOrderBy.Text);
            lbTrace.Items.Add("cbSelect.Text ........ = " + cbSelect.Text);
            lbTrace.Items.Add("cbDeptID.DisplayValue .= " + cbDeptID.Text.ToString());
            lbTrace.Items.Add("cbDeptID.SelectedValue = " + cbDeptID.SelectedValue.ToString());
            lbTrace.Items.Add("");
        }

        //===========================================================================//
        //== Test Module 4 - Testing ComboBox Controls ==//
        //===========================================================================//
        //== Purpose: Display the selections of all CheckBox Controls ==//
        //===========================================================================//
        public void TestModule4()
        {
            lbTraceNote("-", "Test Module 4", "CheckBox Control", "Settings");
            lbTrace.Items.Add("chAdministrator.Checked ....... = " + chAdministrator.Checked.ToString());
            lbTrace.Items.Add("");
        }


        //===========================================================================//
        //== Test Module 5 - Testing Radio Button Controls ==//
        //===========================================================================//
        //== Purpose: Display the selections of all Radio Button Controls ==//
        //===========================================================================//
        public void TestModule5()
        {
            lbTraceNote("-", "Test Module 5", "Radio Button Control", "Settings");
            lbTrace.Items.Add("rbFemale.Checked ....... = " + rbFemale.Checked.ToString());
            lbTrace.Items.Add("rbMale.Checked ......... = " + rbMale.Checked.ToString());
            lbTrace.Items.Add("");
        }

        // --------------------------------------------------------------------------------
        #endregion ----Dr. Hicks Diagnostic Testing ---------------------------------------
        // --------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        //---------------------- Aaron Form Processing -----------------------
        #region ----FillFormVariables -- FilFormBlank --ProcessDataToggle ------------------ 
        //--------------------------------------------------------------------------------

        //===========================================================================//
        //==                           FillFormVariables                           ==//
        //==                                                                       ==//
        //==  Purpose:  Fill all of the data entry fields with a realistic sample  ==//
        //==            data record.                                               ==//
        //==                                                                       ==//
        //==  Written By: Aaron Feleke              Operating System: Windows 10  ==//
        //==        Date: 01\28\2020                      Environment: C# VS 2017  ==//
        //===========================================================================//
        private void FillFormVariables()
        {
            txtFirst.Text = "Aaron";
            txtFirst2.Text = txtFirst.Text;
            txtFirst3.Text = txtFirst.Text;
            txtMI.Text = "M";
            txtMI2.Text = txtMI.Text;
            txtMI3.Text = txtMI.Text;
            txtLast.Text = "Feleke";
            txtLast2.Text = txtLast.Text;
            txtLast3.Text = txtLast.Text;
            txtID.Text = "12345";
            txtUserName.Text = "Aaron321321312";
            txtPassword.Text = "ThePassword123";
            txtEmail.Text = "emailme@emails.org";
            txtHomePhone.Text = "1234567890";
            txtCellPhone.Text = "8452186851";
            txtUniversityID.Text = "0815178";
            txtDeptID.Text = "02";
            txtGenderID.Text = "09";
            txtAdministrator.Text = "2";
            txtNotes.Text = "This is a sentence.";
            cbDeptID.Text = "Math";
            chAdministrator.Checked = true;
            rbMale.Checked = true;
            rbFemale.Checked = false;

        }

        //===========================================================================//
        //==                             FillFormBlank                             ==//
        //==                                                                       ==//
        //==  Purpose:  Fill all of the data entry fields with a realistic blank   ==//
        //==            (new user type) data record.                               ==//
        //==                                                                       ==//
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//
        //===========================================================================//


        private void FillFormBlank()
        { txtFirst.Text = "";
            txtFirst2.Text = "";
            txtFirst3.Text = "";
            txtLast.Text = "";
            txtLast2.Text = "";
            txtLast3.Text = "";
            txtMI.Text = "";
            txtMI2.Text = "";
            txtMI3.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtHomePhone.Text = "";
            txtCellPhone.Text = "";
            txtUniversityID.Text = "";
            txtDeptID.Text = "";
            txtGenderID.Text = "";
            txtAdministrator.Text = "";
            txtNotes.Text = "";
            cbDeptID.Text = "--- Select Major ---";
            chAdministrator.Checked = false;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        //===========================================================================//
        //==                           ProcessDataToggle                           ==//
        //==                                                                       ==//
        //==  Purpose:  When the DataToggle = true, set it to false and run        ==//
        //==            FillFormVariables.                                         ==//
        //==                                                                       ==//
        //==            When the DataToggle = false, set it to true and run        ==//
        //==            FillFormBlank.                                             ==//
        //==                                                                       ==//
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//
        //===========================================================================//
        private void ProcessDataToggle()
        {
            if (DataToggle == true)
            { FillFormVariables();
                DataToggle = false;
            }
            else
            { FillFormBlank();
                DataToggle = true;
            }
        }

        //--------------------------------------------------------------------------------
        #endregion ------------- Aaron Form Processing -----------------
        //--------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------
        //---------------------- Aaron Record Set Nev Collection -----------------------
        #region ----LoadNextRecord -- LoadFirstLetterRecord ------------------ 
        //--------------------------------------------------------------------------------


        //===========================================================================//
        // Purpose: Programatically assign tool tips to the quick-link keys.       ==//
        //==                                                                       ==//
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//
        //===========================================================================//
        public void ReloadQuickLinkToolTips()
        {
            toolTip1.SetToolTip(btnA, "Load The First Record Whose " + QuickLinkText + " Begins With An 'A'");
            toolTip1.SetToolTip(btnB, "Load The First Record Whose " + QuickLinkText + " Begins With A 'B'");
            toolTip1.SetToolTip(btnC, "Load The First Record Whose " + QuickLinkText + " Begins With A 'C'");
            toolTip1.SetToolTip(btnD, "Load The First Record Whose " + QuickLinkText + " Begins With A 'D'");
            toolTip1.SetToolTip(btnE, "Load The First Record Whose " + QuickLinkText + " Begins With An 'E'");
            toolTip1.SetToolTip(btnF, "Load The First Record Whose " + QuickLinkText + " Begins With An 'F'");
            toolTip1.SetToolTip(btnG, "Load The First Record Whose " + QuickLinkText + " Begins With A 'G'");
            toolTip1.SetToolTip(btnH, "Load The First Record Whose " + QuickLinkText + " Begins With An 'H'");
            toolTip1.SetToolTip(btnI, "Load The First Record Whose " + QuickLinkText + " Begins With An 'I'");
            toolTip1.SetToolTip(btnJ, "Load The First Record Whose " + QuickLinkText + " Begins With A 'J");
            toolTip1.SetToolTip(btnK, "Load The First Record Whose " + QuickLinkText + " Begins With A 'K'");
            toolTip1.SetToolTip(btnL, "Load The First Record Whose " + QuickLinkText + " Begins With An 'L'");
            toolTip1.SetToolTip(btnM, "Load The First Record Whose " + QuickLinkText + " Begins With An 'M'");
            toolTip1.SetToolTip(btnN, "Load The First Record Whose " + QuickLinkText + " Begins With An 'N'");
            toolTip1.SetToolTip(btnO, "Load The First Record Whose " + QuickLinkText + " Begins With An 'O'");
            toolTip1.SetToolTip(btnP, "Load The First Record Whose " + QuickLinkText + " Begins With A 'P'");
            toolTip1.SetToolTip(btnQ, "Load The First Record Whose " + QuickLinkText + " Begins With A 'Q'");
            toolTip1.SetToolTip(btnR, "Load The First Record Whose " + QuickLinkText + " Begins With An 'R'");
            toolTip1.SetToolTip(btnS, "Load The First Record Whose " + QuickLinkText + " Begins With An 'S'");
            toolTip1.SetToolTip(btnT, "Load The First Record Whose " + QuickLinkText + " Begins With A 'T'");
            toolTip1.SetToolTip(btnU, "Load The First Record Whose " + QuickLinkText + " Begins With A 'U'");
            toolTip1.SetToolTip(btnV, "Load The First Record Whose " + QuickLinkText + " Begins With A 'V'");
            toolTip1.SetToolTip(btnW, "Load The First Record Whose " + QuickLinkText + " Begins With A 'W'");
            toolTip1.SetToolTip(btnX, "Load The First Record Whose " + QuickLinkText + " Begins With An 'X'");
            toolTip1.SetToolTip(btnY, "Load The First Record Whose " + QuickLinkText + " Begins With A 'Y'");
            toolTip1.SetToolTip(btnZ, "Load The First Record Whose " + QuickLinkText + " Begins With A 'Z'");
        }



        //===========================================================================//
        //==                             LoadLastRecord                            ==//
        //===========================================================================//
        //==                                                                       ==//
        //==  Purpose: Load the last logical record into the datatable.            ==//
        //==                                                                       ==//
        //==  Limitation : Problem when all records are deleted or no records in   ==//
        //==               view.                                                   ==//
        //==                                                                       ==//
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//
        //===========================================================================//
        private void LoadLastRecord()
        {


        }


        //===========================================================================// 
        //==                             LoadFirstRecord                           ==//   
        //===========================================================================// 
        //==                                                                       ==//
        //==  Purpose: Load the first logical record into the datatable.           ==//
        //==                                                                       ==//
        //==  Limitation : Problem when all records are deleted or no records in   ==//
        //==               view.                                                   ==//
        //==                                                                       ==//
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//
        //===========================================================================//
        private void LoadFirstRecord()
        {


        }

        //===========================================================================//
        //==                             LoadNextRecord                            ==//
        //===========================================================================//   
        //==                                                                       ==//   
        //==  Purpose: Load the next logical record into the datatable.  Cycle     ==//   
        //==           from the last record to the first.                          ==//    
        //==                                                                       ==//  
        //==  Limitation : Problem when all records are deleted or no records in   ==//  
        //==               view.                                                   ==//   
        //==                                                                       ==//   
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==// 
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//  
        //===========================================================================//  
        private void LoadNextRecord() {


        }

        //===========================================================================// 
        //==                           LoadPreviousRecord                          ==//  
        //===========================================================================//  
        //==                                                                       ==//   
        //==  Purpose: Load the previous logical record into the datatable.  Cycle ==//  
        //==           from the first record to the last.                          ==//  
        //==                                                                       ==//  
        //==  Limitation : Problem when all records are deleted or no records in   ==//   
        //==               view.                                                   ==//    
        //==                                                                       ==//    
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//   
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//    
        //===========================================================================//  
        private void LoadPreviousRecord() {
        }












        //===========================================================================//    
        //==                          LoadFirstLetterRecord                        ==//  
        //===========================================================================//    
        //==   
        //==  Purpose: Load the first logical record, in the current view, whose   ==//
        //==           FullName begins with the Letter into the datatable.         ==// 
        //==                                                                       ==// 
        //==           In the event that there is no name with this letter, you    ==// 
        //==           can choose to (1) bring up a dialog box and tell the user   ==//
        //==           or go to the first record past that letter ==> i.e. if      ==// 
        //==           there is no FullName starting with an 'X' --> maybe         ==// 
        //==           try 'Y'?                                                    ==// 
        //==                                                                       ==// 
        //==            Use MySqlDataAdapter da & DataTable dt to house the        ==// 
        //==            data.                                                      ==// 
        //==                                                                       ==// 
        //==  Limitation : Problem when all records are deleted or no records in   ==//
        //==               view.                                                   ==//  
        //==                                                                       ==//  
        //==  Written By: Dr. Tom Hicks              Operating System: Windows 10  ==//  
        //==        Date: XX\XX\XXXX                      Environment: C# VS 2017  ==//
        //===========================================================================//
        private void LoadFirstLetterRecord(char Letter) {
        }



        //--------------------------------------------------------------------------------
        #endregion ------------- Aaron Record Set Nev Collection  -----------------
        //--------------------------------------------------------------------------------





        //--------------------------------------------------------------------------------
        //------------------ Dr. Hicks View Management Functionality ---------------------
        #region -----ViewMode--EditMode--Add--Deleted-Save--Cancel------------------------
        //--------------------------------------------------------------------------------
        //===========================================================================//
        //== ViewMode ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Protect the form from accidental data change. ==//
        //== (1) Make sure that the user can not change any of the ==//
        //== controls (i.e. --> TextBoxes, RadioButtons, CheckBoxes, ==//
        //== ComboBoxes, Spinners, etc.) that are associat ed with ==//
        //== data entry on any of the tabs. ==//
        //== (2) Make sure that the user cannot change any of those ==//
        //== controls that are meant to display view-only info ==//
        //== such as the ID (auto incrementing primary key). ==//
        //== (3) Make sure that the user can see, and use, to those ==//
        //== MenuStrip buttons for which they have permission; ==//
        //== if the user is not an administrator, you should ==//
        //== hide any administrative buttons. ==//
        //== (4) Buttons Save and Cancel should be hidden. ==//
        //== (5) The EditMode will often change the data control ==//
        //== background to make it obvious, to the user, that they ==//
        //== are in a data entry mode; ViewMode shoud change the ==//
        //== background back to the normal view color (often ==//
        //== white). ==//
        //== (6) Make sure that the user has access to all Navigation ==//
        //== buttons, Select ComboBoxes, Select Order By's, ==//
        //== Quick-Link Buttons, Form Transfer Buttons, Phone/Fax ==//
        //== Call Buttons, etc. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        public void ViewMode()
        {
            pf.UserInViewMode = true;
            pf.UserInEditMode = false;
            pf.UserInAddMode = false;

            // ------------------ Control MenuStrip Buttons ----------------------
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            saveToolStripMenuItem.Visible = false;
            cancelToolStripMenuItem.Visible = false;
            searchToolStripMenuItem.Visible = true;
            reportsToolStripMenuItem.Visible = true;
            administrativeToolStripMenuItem.Visible = true;
            closeToolStripMenuItem.Visible = true;
            dataToolStripMenuItem.Visible = true;
            deleteToolStripMenuItem.Visible = true;
            unDeleteToolStripMenuItem.Visible = true;


            // ----------- Make No TextBoxes Are Available To Edit --------------
            // ---------------- Change Background To EditColor -----------------
            txtFirst.ReadOnly = true;
            txtFirst.BackColor = Color.White;
            txtLast.ReadOnly = true;
            txtLast.BackColor = Color.White;
            txtMI.ReadOnly = true;
            txtMI.BackColor = Color.White;

            txtUserName.ReadOnly = true;
            txtUserName.BackColor = Color.White;
            txtPassword.ReadOnly = true;
            txtPassword.BackColor = Color.White;
            txtEmail.ReadOnly = true;
            txtEmail.BackColor = Color.White;

            txtHomePhone.ReadOnly = true;
            txtHomePhone.BackColor = Color.White;
            txtCellPhone.ReadOnly = true;
            txtCellPhone.BackColor = Color.White;
            txtUniversityID.ReadOnly = true;
            txtUniversityID.BackColor = Color.White;

            txtDeptID.ReadOnly = true;
            txtDeptID.BackColor = Color.White;


            txtNotes.ReadOnly = true;
            txtNotes.BackColor = Color.White;


            // ------ Must Change FlatStyle Property From Standard To Flat -------
            // ------------------------- CoboBoxes -------------------------------
            cbDeptID.BackColor = Color.White;

            // --- Hide, or Get Rid of Inused Textboxes
            txtAdministrator.Hide();
            txtGenderID.Hide();
            txtDeptID.Hide();

            // ----------------- Show The Data Transfer Buttons ------------------
            btnPayFineTransfer.Show();
            btnCheckOutTransfer.Show();

            // ---------------------- Navigation Controls -------------------------
            pnlNavigation.Show();
            btnTest.Show();

            // ------------------------ Check Boxes ------------------------------
            chAdministrator.BackColor = Color.White;


            // --------------------- Show The Phone Buttons ----------------------
            btnHomePhone.Show();
            btnCellPhone.Show();

            rbFemale.BackColor = Color.Transparent;
            rbMale.BackColor = Color.Transparent;
            rbFemale.ForeColor = Color.White;
            rbMale.ForeColor = Color.White;


        }
        //===========================================================================//
        //== EditMode ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Create an enviornment in which the user's only choices ==//
        //== are to (a) alter the data entry controls, (b) Save any ==//
        //== changes, (c) Cancel any changes and revert/return back to ==//
        //== the previous status --> reload the current record. ==//
        //== (1) Make sure that the user can change any of the ==//
        //== controls (i.e. --> TextBoxes, RadioButtons, CheckBoxes, ==//
        //== ComboBoxes, Spinners, etc.) that are associat ed with ==//
        //== data entry on any of the tabs. ==//
        //== (2) Make sure that the user cannot change any of those ==//
        //== controls that are meant to display view-only info ==//
        //== such as the ID (auto incrementing primary key). ==//
        //== (3) Make sure that the only MenuStrip choices are Save and ==//
        //== Cancel. ==//
        //== (4) Buttons Save and Cancel should be hidden. ==//
        //== (5) Alter the background to make it obvious, to the user, ==//
        //== that they are in a data entry mode. Keep it ==//
        //== professional; do not select really wild colors. ==//
        //== (6) Make sure that the user has no access Navigation ==//
        //== buttons, Select ComboBoxes, Select Order By's, ==//
        //== Quick-Link Buttons, Form Transfer Buttons, Phone/Fax ==//
        //== Call Buttons, etc. The idea is to force the user to ==//
        //== complete the Edit/Add process. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//





        public void EditMode()
        {
            pf.UserInViewMode = false;
            pf.UserInEditMode = true;
            pf.UserInAddMode = false;

            // ------------------ Control MenuStrip Buttons ----------------------
            editToolStripMenuItem.Visible = false;
            saveToolStripMenuItem.Visible = true;
            cancelToolStripMenuItem.Visible = true;
            addToolStripMenuItem.Visible = false;
            searchToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
            administrativeToolStripMenuItem.Visible = false;
            closeToolStripMenuItem.Visible = false;
            dataToolStripMenuItem.Visible = false;
            deleteToolStripMenuItem.Visible = false;
            unDeleteToolStripMenuItem.Visible = false;

            // ------------ Make All TextBoxes Available To Edit ----------------
            // ---------------- Change Background To EditColor -----------------
            txtFirst.ReadOnly = false;
            txtFirst.BackColor = Color.LightGoldenrodYellow;
            txtLast.ReadOnly = false;
            txtLast.BackColor = Color.LightGoldenrodYellow;
            txtMI.ReadOnly = false;
            txtMI.BackColor = Color.LightGoldenrodYellow;

            txtUserName.ReadOnly = false;
            txtUserName.BackColor = Color.LightGoldenrodYellow;
            txtPassword.ReadOnly = false;
            txtPassword.BackColor = Color.LightGoldenrodYellow;
            txtEmail.ReadOnly = false;
            txtEmail.BackColor = Color.LightGoldenrodYellow;

            txtHomePhone.ReadOnly = false;
            txtHomePhone.BackColor = Color.LightGoldenrodYellow;
            txtCellPhone.ReadOnly = false;
            txtCellPhone.BackColor = Color.LightGoldenrodYellow;
            txtUniversityID.ReadOnly = false;
            txtUniversityID.BackColor = Color.LightGoldenrodYellow;

            txtDeptID.ReadOnly = false;
            txtDeptID.BackColor = Color.LightGoldenrodYellow;


            txtNotes.ReadOnly = false;
            txtNotes.BackColor = Color.LightGoldenrodYellow;


            //  !!!!!!!!!!!!!!!! Add the code necessary to include all of your TextBoxes.

            // ------------------------- CoboBoxes -------------------------------
            cbDeptID.BackColor = Color.LightGoldenrodYellow;

            // ------ Must Change FlatStyle Property From Standard To Flat -------
            // ------------------------- CoboBoxes -------------------------------
            cbDeptID.BackColor = Color.LightGoldenrodYellow;

            // ----------------------- Radio Buttons -----------------------------
            rbFemale.BackColor = Color.LightGoldenrodYellow;
            rbMale.BackColor = Color.LightGoldenrodYellow;
            rbFemale.ForeColor = Color.LightGoldenrodYellow;
            rbMale.ForeColor = Color.LightGoldenrodYellow;

            // ----------------------- Radio Buttons -----------------------------
            rbFemale.BackColor = Color.LightGoldenrodYellow;
            rbMale.BackColor = Color.LightGoldenrodYellow;
            rbFemale.ForeColor = Color.Black;
            rbMale.ForeColor = Color.Black;

            // ------------------------ Check Boxes ------------------------------
            chAdministrator.BackColor = Color.LightGoldenrodYellow;



            // --- Hide, or Get Rid Of, Unused TextBoxes
            txtAdministrator.Hide();
            txtGenderID.Hide();
            txtDeptID.Hide();

        
                // --------------------- Hide The Phone Buttons ----------------------
            btnHomePhone.Hide();
            btnCellPhone.Hide();

            // ----------------- Hide The Data Transfer Buttons ------------------
            btnPayFineTransfer.Hide();
            btnCheckOutTransfer.Hide();



            // ---------------------- Navigation Controls -------------------------
            pnlNavigation.Hide();
            btnTest.Hide();




            Testing = false;
            // ------------------------ Testing Controls --------------------------
            if (Testing == false)
            {
                lbTrace.Hide();
                btnTest.Hide();
                this.Width = 969;
                this.Height = 534;
            }
            if (Testing == true)
            {
                lbTrace.Show();
                btnTest.Show();
                this.Width = 1335;
                this.Height = 534;
            }
        }
        //===========================================================================//
        //== AddMode ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Set the InAddMode to true and call EditMode. The NoLogRec ==//
        //== must increase if the user chooses to save this new record; ==//

        //== re-calibrate it. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        private void AddMode()
        {
            pf.UserInAddMode = true;
            pf.UserInEditMode = false;
            pf.UserInViewMode = false;

            FillFormBlank();
            EditMode();
        }
        //===========================================================================//
        //== Delete ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Tag the Current record for deletion; set Deleted = 'F'. ==//
        //== The NoLogRec must decrease; re-calibrate it. Since we do ==//
        //== waant to be looking at a deleted record, I would suggest ==//
        //== that you LoadPreviousRecord then LoadNextRecord. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        private void Delete()
        {
            // String Query = "UPDATE User SET Deleted = 'T' WHERE ID = '" + CurrentID.ToString() + "';";
        }
        //===========================================================================//
        //== Save ==//
        //===========================================================================//
        //== ==//
        //== Purpose: If InAddMode: ==//
        //== (1) INSERT the record into the database ==//
        //== (2) If this new record is part of the current view : ==//
        //== (a) Reset the CurrentID ==//
        //== (b) Make this new record the Current Record in dt ==//
        //== (3) If this new record is not part of the current view ==//
        //== (a) Reload the last record in the current view ==//
        //== (4) Re-Calibrate the NoLogRec ==//
        //== ==//
        //== If Not In InAddMode: ==//
        //== (1) UPDATE the record into the database ==//
        //== (a) Reset the CurrentID ==//
        //== (b) Make this new record the Current Record in dt ==//
        //== (2) Re-Calibrate the NoLogRec ==//
        //== ==//
        //== Update the FullName & Reset the modes. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        public void Save()
        {
            ViewMode();
        }
        //===========================================================================//
        //== Cancel ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Discard any changes and reload the current record. ==//
        //== ==//

        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        private void Cancel()
        {
            ViewMode();
        }
        //--------------------------------------------------------------------------------
        #endregion --------- Dr. Hicks View Management Functionality ---------------------
        //--------------------------------------------------------------------------------












        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ToolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHomePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TestingMaster();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dialing Cell Phone \n Hello Computer Scientist!");

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Dialing Home Phone \n Hello Computer Scientist!");
        }

        private void PersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessDataToggle();
        }

        private void TxtAdministrator_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Notes_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LoadNextRecord();
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            LoadFirstRecord();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LoadLastRecord();
        }

        private void Button1_Click_4(object sender, EventArgs e)
        {
        }

        private void Button1_Click_5(object sender, EventArgs e)
        {

        }

        private void Button1_Click_6(object sender, EventArgs e)
        {

        }

        private void Button23_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {

        }

        private void BtnPreviousLeft_Click(object sender, EventArgs e)
        {
            LoadPreviousRecord();
        }

        private void BtnNextRight_Click(object sender, EventArgs e)
        {

        }

        private void BtnCellPhone_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LbTrace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CbDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChAdministrator_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Checkout_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMode();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void User_VisibleChanged(object sender, EventArgs e)
        {
            if (pf.UserInEditMode)
                EditMode();
            else
                ViewMode();
        }

        private void CbDeptID_Enter(object sender, EventArgs e)
        {
            if (pf.UserInEditMode == false)
            {
                MessageBox.Show("You must edit - if you want to change this.");
                btnNextLeft.Focus();
            }
        }


        private void rbFemale_Enter(object sender, EventArgs e)
        {
            if (pf.UserInEditMode == false)
            {
                MessageBox.Show("You Must Edit - If You Want To Change This");
                btnNextLeft.Focus();
            }
        }

        private void rbMale_Enter(object sender, EventArgs e)
        {
            if (pf.UserInEditMode == false)
            {
                MessageBox.Show("You Must Edit - If You Want To Change This");
                btnNextLeft.Focus();
            }
        }

        private void chAdministrator_Enter(object sender, EventArgs e)
        {
            if (pf.UserInEditMode == false)
            {
                MessageBox.Show("You Must Edit - If You Want To Change This");
                btnNextLeft.Focus();
            }
        }

        private void BtnCellPhone_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dialing Home Phone \n Hello Computer Scientist!");
        }

        private void Button1_Click_7(object sender, EventArgs e)
        {

        }

        private void txtFirst_Leave(object sender, EventArgs e)
        {
            txtFirst2.Text = txtFirst.Text;
            txtFirst3.Text = txtFirst.Text;
        }

        private void txtMI_Leave(object sender, EventArgs e)
        {
            txtMI2.Text = txtMI.Text;
            txtMI.Text = txtMI.Text;
        }

        private void txtLast_Leave(object sender, EventArgs e)
        {
            txtLast.Text = txtLast.Text;
            txtLast.Text = txtLast.Text;
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            tb4.Visible = true;
            tb5.Visible = true;
            tb6.Visible = true;
            tb7.Visible = true;
            tb8.Visible = true;
            tb9.Visible = true;
            tb10.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView2.Visible = false;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            tb4.Visible = false;
            tb5.Visible = false;
            tb6.Visible = false;
            tb7.Visible = false;
            tb8.Visible = false;
            tb9.Visible = false;
            tb10.Visible = false;
        }

        private void DepartmentsAddEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSupportingClassWindow("Add - Edit - Delete Departments", "Department Name", "Biology",
                "Chemistry", "Computer Science", "Math", "Physics");
        }

        private void UserTypesAddEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSupportingClassWindow("Add - Edit Delete User Types", "User Type", "Faculty",
                "Guest", "Librarian", "Parent", "Student");
        }

        private void UnDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSupportingClassWindow("Undelete Users", "User Name", "adams, Joe", "Caloway, Sandy",
                "Danielson, Roger", "Fairway, Ann", "Hicks, Tom");
        }

        private void ByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Search User By Name", "Enter name", "Hicks, T");
        }
    }


}