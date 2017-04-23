namespace maxscriptReferenceParser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mxsCategoriesListbox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.mxsPathTextbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(260, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(463, 277);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Parse everything";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.parseWholeReferenceBtn);
            // 
            // mxsCategoriesListbox
            // 
            this.mxsCategoriesListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mxsCategoriesListbox.Enabled = false;
            this.mxsCategoriesListbox.FormattingEnabled = true;
            this.mxsCategoriesListbox.Location = new System.Drawing.Point(13, 42);
            this.mxsCategoriesListbox.Name = "mxsCategoriesListbox";
            this.mxsCategoriesListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.mxsCategoriesListbox.Size = new System.Drawing.Size(241, 277);
            this.mxsCategoriesListbox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(127, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Parse selected only";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.parseSelectedCategories);
            // 
            // mxsPathTextbox
            // 
            this.mxsPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mxsPathTextbox.Location = new System.Drawing.Point(260, 14);
            this.mxsPathTextbox.Name = "mxsPathTextbox";
            this.mxsPathTextbox.Size = new System.Drawing.Size(463, 20);
            this.mxsPathTextbox.TabIndex = 5;
            this.mxsPathTextbox.Text = "path to html MAXScript reference folder";
            this.mxsPathTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mxsPathTextbox.TextChanged += new System.EventHandler(this.mxsPathTextbox_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(134, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "fatbbc@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(23, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "by Panteleev Sergey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.mxsPathTextbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mxsCategoriesListbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "MAXScript reference parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox mxsCategoriesListbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox mxsPathTextbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

