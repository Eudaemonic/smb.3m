namespace smb._3m
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.rbSelfIssue = new System.Windows.Forms.RadioButton();
            this.rbSelfReturns = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFIle = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(39, 128);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process File";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(39, 24);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(216, 20);
            this.txtFile.TabIndex = 2;
            // 
            // rbSelfIssue
            // 
            this.rbSelfIssue.AutoSize = true;
            this.rbSelfIssue.Location = new System.Drawing.Point(39, 50);
            this.rbSelfIssue.Name = "rbSelfIssue";
            this.rbSelfIssue.Size = new System.Drawing.Size(123, 17);
            this.rbSelfIssue.TabIndex = 3;
            this.rbSelfIssue.TabStop = true;
            this.rbSelfIssue.Text = "Self Issue/Renewals";
            this.rbSelfIssue.UseVisualStyleBackColor = true;
            // 
            // rbSelfReturns
            // 
            this.rbSelfReturns.AutoSize = true;
            this.rbSelfReturns.Location = new System.Drawing.Point(39, 73);
            this.rbSelfReturns.Name = "rbSelfReturns";
            this.rbSelfReturns.Size = new System.Drawing.Size(83, 17);
            this.rbSelfReturns.TabIndex = 4;
            this.rbSelfReturns.TabStop = true;
            this.rbSelfReturns.Text = "Self Returns";
            this.rbSelfReturns.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Location";
            // 
            // btnOpenFIle
            // 
            this.btnOpenFIle.Location = new System.Drawing.Point(261, 24);
            this.btnOpenFIle.Name = "btnOpenFIle";
            this.btnOpenFIle.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFIle.TabIndex = 6;
            this.btnOpenFIle.Text = "Open File";
            this.btnOpenFIle.UseVisualStyleBackColor = true;
            this.btnOpenFIle.Click += new System.EventHandler(this.btnOpenFIle_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(36, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(261, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(238, 76);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 240);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnOpenFIle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbSelfReturns);
            this.Controls.Add(this.rbSelfIssue);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnProcess);
            this.Name = "Form1";
            this.Text = "3M Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RadioButton rbSelfIssue;
        private System.Windows.Forms.RadioButton rbSelfReturns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFIle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

