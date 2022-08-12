using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace Bot
{
   
    public partial class Form1 : Form
    {
        public FirefoxDriver firefox;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = true;
        }

        private void button_google_Click(object sender, EventArgs e)
        {
            firefox.Navigate().GoToUrl("https://www.google.com/");
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string textPoisk = textBox1.Text;
            firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(textPoisk);
            firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(Keys.Enter);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firefox != null) firefox.Quit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitFirefox();
        }

        public void InitFirefox()
        {
            FirefoxDriverService servise = FirefoxDriverService.CreateDefaultService();
            servise.HideCommandPromptWindow = true;

            FirefoxOptions options = new FirefoxOptions();
            firefox = new FirefoxDriver(servise, options);
        }
    }
}
