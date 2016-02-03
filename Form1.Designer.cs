namespace SqlToUtf8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConvertButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 33);
            this.panel1.TabIndex = 0;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConvertButton.Location = new System.Drawing.Point(656, 0);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 33);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert all *.sql files in application\'s directory from Unicode to UTF-8";
            // 
            // LogBox
            // 
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Location = new System.Drawing.Point(0, 33);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(731, 415);
            this.LogBox.TabIndex = 1;
            this.LogBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 448);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Batch *.sql files converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox LogBox;
    }
}

