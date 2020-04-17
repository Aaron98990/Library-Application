namespace LibraryApp
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.Label();
            this.lbExample = new System.Windows.Forms.Label();
            this.btnSearchNow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(138, 85);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 24);
            this.txtValue.TabIndex = 2;
            // 
            // txtPrompt
            // 
            this.txtPrompt.AutoSize = true;
            this.txtPrompt.Location = new System.Drawing.Point(70, 92);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(63, 13);
            this.txtPrompt.TabIndex = 3;
            this.txtPrompt.Text = "Enter Name";
            this.txtPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbExample
            // 
            this.lbExample.AutoSize = true;
            this.lbExample.Location = new System.Drawing.Point(144, 112);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(35, 13);
            this.lbExample.TabIndex = 4;
            this.lbExample.Text = "label2";
            // 
            // btnSearchNow
            // 
            this.btnSearchNow.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSearchNow.Location = new System.Drawing.Point(41, 159);
            this.btnSearchNow.Name = "btnSearchNow";
            this.btnSearchNow.Size = new System.Drawing.Size(370, 23);
            this.btnSearchNow.TabIndex = 5;
            this.btnSearchNow.Text = "button1";
            this.btnSearchNow.UseVisualStyleBackColor = false;
            this.btnSearchNow.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchNow);
            this.Controls.Add(this.lbExample);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Search";
            this.Text = "SupportingClassAddEdit";
            this.Load += new System.EventHandler(this.SupportingClassAddEdit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label txtPrompt;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.Button btnSearchNow;
    }
}