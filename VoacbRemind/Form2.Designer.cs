namespace VoacbRemind
{
    partial class Form2
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.wordtxt = new MetroFramework.Controls.MetroTextBox();
            this.meantxt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Word";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Meaninig";
            // 
            // wordtxt
            // 
            // 
            // 
            // 
            this.wordtxt.CustomButton.Image = null;
            this.wordtxt.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.wordtxt.CustomButton.Name = "";
            this.wordtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.wordtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.wordtxt.CustomButton.TabIndex = 1;
            this.wordtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.wordtxt.CustomButton.UseSelectable = true;
            this.wordtxt.CustomButton.Visible = false;
            this.wordtxt.Lines = new string[0];
            this.wordtxt.Location = new System.Drawing.Point(118, 75);
            this.wordtxt.MaxLength = 32767;
            this.wordtxt.Name = "wordtxt";
            this.wordtxt.PasswordChar = '\0';
            this.wordtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wordtxt.SelectedText = "";
            this.wordtxt.SelectionLength = 0;
            this.wordtxt.SelectionStart = 0;
            this.wordtxt.ShortcutsEnabled = true;
            this.wordtxt.Size = new System.Drawing.Size(116, 23);
            this.wordtxt.TabIndex = 2;
            this.wordtxt.UseSelectable = true;
            this.wordtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.wordtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // meantxt
            // 
            // 
            // 
            // 
            this.meantxt.CustomButton.Image = null;
            this.meantxt.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.meantxt.CustomButton.Name = "";
            this.meantxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.meantxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.meantxt.CustomButton.TabIndex = 1;
            this.meantxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.meantxt.CustomButton.UseSelectable = true;
            this.meantxt.CustomButton.Visible = false;
            this.meantxt.Lines = new string[0];
            this.meantxt.Location = new System.Drawing.Point(118, 129);
            this.meantxt.MaxLength = 32767;
            this.meantxt.Name = "meantxt";
            this.meantxt.PasswordChar = '\0';
            this.meantxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meantxt.SelectedText = "";
            this.meantxt.SelectionLength = 0;
            this.meantxt.SelectionStart = 0;
            this.meantxt.ShortcutsEnabled = true;
            this.meantxt.Size = new System.Drawing.Size(116, 23);
            this.meantxt.TabIndex = 3;
            this.meantxt.UseSelectable = true;
            this.meantxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.meantxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(118, 177);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(116, 47);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.meantxt);
            this.Controls.Add(this.wordtxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "New";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox wordtxt;
        private MetroFramework.Controls.MetroTextBox meantxt;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}