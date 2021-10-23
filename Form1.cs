using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCreateEmailWIthoutNumberPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"user-data-dir=C:\Users\Shishi\AppData\Local\Google\Chrome\User Data\");
            Thread.Sleep(5000);

            ChromeDriver chromeDriver = new ChromeDriver(options);
            chromeDriver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=SignUp";
            chromeDriver.Navigate();
        }
    }
}
