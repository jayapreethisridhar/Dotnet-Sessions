using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncAppClass.Service;

namespace WinFormsAsyncAppClass
{
    public partial class WelcomeForm : Form
    {
        private PrintService _printService;
        public WelcomeForm()
        {
            _printService = new PrintService();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event handler1");
        }

        private void btnPrint_ClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Event handler2");
            _printService.Print();
        }

        private void PrintViaThreadClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaThread();
            MessageBox.Show("thread method completed");
        }

        private void btnViaTaskClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaTask();
            MessageBox.Show("task completed");
        }

        private async void btnPrintViaTaskWait_Handler(object sender, EventArgs e)
        {
            await _printService.PrintViaTaskAwaitable();
            MessageBox.Show("Task completed after 10 second awaitable");

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnViaTaskResultClick_Handler(object sender, EventArgs e)
        {
             string result = await _printService.PrintViaTaskAwaitableResult();
            MessageBox.Show($"Task completed after 10 seconds" + result);
        }
    }
}
