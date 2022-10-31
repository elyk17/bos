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
            this.resetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tableofcontents
            // 
            this.tableofcontents.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tableofcontents.AutoSize = true;
            this.tableofcontents.BackColor = System.Drawing.SystemColors.Window;
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
            this.inputTitle.BackColor = System.Drawing.Color.BlanchedAlmond;
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
            this.richTextBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(160, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 555);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.Location = new System.Drawing.Point(280, 808);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(310, 50);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset Password";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(803, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBody
            // 
            this.textBody.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBody.Location = new System.Drawing.Point(808, 167);
            this.textBody.Name = "textBody";
            this.textBody.Size = new System.Drawing.Size(562, 621);
            this.textBody.TabIndex = 6;
            this.textBody.Text = "";
            // 
            // insideBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 934);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetButton);
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
        private Button resetButton;
        private Button button1;
        private RichTextBox textBody;
    }
}