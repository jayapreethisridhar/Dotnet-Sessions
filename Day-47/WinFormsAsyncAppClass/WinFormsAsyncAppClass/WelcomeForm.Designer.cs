namespace WinFormsAsyncAppClass
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
            button1 = new Button();
            button2 = new Button();
            btnPrintThread = new Button();
            PrintViaTask = new Button();
            PrintViaTaskawaitable = new Button();
            PrintViaTaskAwaitableResult = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "btnPrint";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPrint_ClickHandler;
            // 
            // button2
            // 
            button2.Location = new Point(282, 31);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "btnHello";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPrintThread
            // 
            btnPrintThread.Location = new Point(282, 101);
            btnPrintThread.Name = "btnPrintThread";
            btnPrintThread.Size = new Size(75, 23);
            btnPrintThread.TabIndex = 2;
            btnPrintThread.Text = "PrintViaThread";
            btnPrintThread.UseVisualStyleBackColor = true;
            btnPrintThread.Click += PrintViaThreadClick_Handler;
            // 
            // PrintViaTask
            // 
            PrintViaTask.Location = new Point(230, 130);
            PrintViaTask.Name = "PrintViaTask";
            PrintViaTask.Size = new Size(150, 23);
            PrintViaTask.TabIndex = 3;
            PrintViaTask.Text = "PrintViaTask";
            PrintViaTask.UseVisualStyleBackColor = true;
            PrintViaTask.Click += btnViaTaskClick_Handler;
            // 
            // PrintViaTaskawaitable
            // 
            PrintViaTaskawaitable.Location = new Point(231, 169);
            PrintViaTaskawaitable.Name = "PrintViaTaskawaitable";
            PrintViaTaskawaitable.Size = new Size(149, 23);
            PrintViaTaskawaitable.TabIndex = 4;
            PrintViaTaskawaitable.Text = "PrintViaTaskAwaitable";
            PrintViaTaskawaitable.UseVisualStyleBackColor = true;
            PrintViaTaskawaitable.Click += btnPrintViaTaskWait_Handler;
            // 
            // PrintViaTaskAwaitableResult
            // 
            PrintViaTaskAwaitableResult.Location = new Point(231, 213);
            PrintViaTaskAwaitableResult.Name = "PrintViaTaskAwaitableResult";
            PrintViaTaskAwaitableResult.Size = new Size(149, 23);
            PrintViaTaskAwaitableResult.TabIndex = 5;
            PrintViaTaskAwaitableResult.Text = "PrintViaTaskAwaitableResult";
            PrintViaTaskAwaitableResult.UseVisualStyleBackColor = true;
            PrintViaTaskAwaitableResult.Click += btnViaTaskResultClick_Handler;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrintViaTaskAwaitableResult);
            Controls.Add(PrintViaTaskawaitable);
            Controls.Add(PrintViaTask);
            Controls.Add(btnPrintThread);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
        }

        #endregion


        private Button button1;
        private Button button2;
        private Button btnPrintThread;
        private Button PrintViaTask;
        private Button PrintViaTaskawaitable;
        private Button PrintViaTaskAwaitableResult;
    }
}