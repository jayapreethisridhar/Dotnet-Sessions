
namespace WinFormsAsyncApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            password = new TextBox();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(328, 201);
            username.Name = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 0;
            username.Text = "username";
            username.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(436, 244);
            password.Name = "password";
            password.ScrollBars = ScrollBars.Both;
            password.Size = new Size(100, 23);
            password.TabIndex = 1;
            password.Text = "password";
            password.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
    }
}
