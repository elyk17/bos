namespace BookOfShadows
{
    partial class insideBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insideBook));
            this.tableofcontents = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tableofcontents
            // 
            this.tableofcontents.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tableofcontents.AutoSize = true;
            this.tableofcontents.Enabled = false;
            this.tableofcontents.Font = new System.Drawing.Font("Viner Hand ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tableofcontents.Image = ((System.Drawing.Image)(resources.GetObject("tableofcontents.Image")));
            this.tableofcontents.Location = new System.Drawing.Point(244, 33);
            this.tableofcontents.Name = "tableofcontents";
            this.tableofcontents.Size = new System.Drawing.Size(381, 71);
            this.tableofcontents.TabIndex = 0;
            this.tableofcontents.Tag = "jlajfl;j;lsdkj;flkjsd;lfkjs;dlkjf;lskj;flkjsa;lkjf;lsadkjf;lksdjf;lkjsd;lfkjsd;lk" +
    "jfl;sdk";
            this.tableofcontents.Text = "Table of Contents";
            // 
            // title
            // 
            this.title.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.title.Font = new System.Drawing.Font("Viner Hand ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(790, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(587, 71);
            this.title.TabIndex = 1;
            this.title.Tag = "";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // inputTitle
            // 
            this.inputTitle.BackColor = System.Drawing.Color.NavajoWhite;
            this.inputTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTitle.Font = new System.Drawing.Font("Viner Hand ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.inputTitle.Location = new System.Drawing.Point(790, 39);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTitle.Size = new System.Drawing.Size(580, 72);
            this.inputTitle.TabIndex = 2;
            this.inputTitle.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBox1.Location = new System.Drawing.Point(160, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 555);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // insideBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 934);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tableofcontents);
            this.Name = "insideBook";
            this.Load += new System.EventHandler(this.bookpages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tableofcontents;
        private Label title;
        private TextBox inputTitle;
        private RichTextBox richTextBox1;
    }
}