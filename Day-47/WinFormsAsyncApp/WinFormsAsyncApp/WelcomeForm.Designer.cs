namespace WinFormsAsyncApp
{
    partial class WelcomeForm
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
            btnLogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            UserName = new Label();
            Password = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(545, 191);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(369, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(369, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(293, 122);
            UserName.Name = "UserName";
            UserName.Size = new Size(62, 15);
            UserName.TabIndex = 5;
            UserName.Text = "UserName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(293, 280);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 6;
            Password.Text = "Password";
            Password.Click += label1_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnLogin);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label UserName;
        private Label Password;
    }
}