using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        //public void PotokWeather()
        //{
        //    Weather weather = new Weather();
        //    weather.KnowWeatherNow(firefox);
        //}

        private void button_google_Click_1(object sender, EventArgs e)
        {
            firefox.Navigate().GoToUrl("https://www.google.com/");
        }
        private void button_enter_Click_1(object sender, EventArgs e)
        {
            string textPoisk = richTextBox_search.Text;
            firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(textPoisk);
            firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);          
        }



        string path = "https://sinoptik.ua/";
        private void weather_button_Click(object sender, EventArgs e)
        {
            
            string name = "погода";
      
            Thread.Sleep(1000);
            firefox.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(1000);
            firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(name);
            Thread.Sleep(1000);
            firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            firefox.FindElement(By.XPath("//*[@id=\"rso\"]/div[2]/div/div/div[1]/div")).Click();


            //var result = firefox.FindElements(By.XPath("//div[@class='yuRUbf']"));
            //foreach (var element in result)
            //{
            //    if (element.Text.IndexOf(path) != -1)
            //    {
            //        richTextBox_text.Text += element.Text + "\n";
                    
            //        break;
            //    }
            //}
        }



       
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Tabbing.GoLeft(firefox);
           
        }
        private void buttonAddWin_Click(object sender, EventArgs e)
        {
            Tabbing.AddWin(firefox);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Tabbing.BackWin(firefox);
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            Tabbing.GoRigth(firefox);
            
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            firefox.Navigate().GoToUrl("https://lfyou.com.ua/");
            Thread.Sleep(2000);
            firefox.FindElement(By.XPath("//*[@id=\"chat-ctrl\"]/section[2]/section[2]/div[1]/div/div[2]/div/button[1]")).Click();
      
            Thread.Sleep(500);
            firefox.FindElement(By.XPath("//*[@id=\"chat-ctrl\"]/section[2]/section[2]/div[2]/div/div[2]/div/button[2]")).Click();

            Thread.Sleep(1000);
            firefox.FindElement(By.XPath("//*[@id=\"chat-ctrl\"]/section[2]/section[3]/div[1]/div/div[2]/div/button[4]")).Click();
            firefox.FindElement(By.XPath("//*[@id=\"chat-ctrl\"]/section[2]/section[3]/div[2]/div/div[2]/div/button[4]")).Click();

            Thread.Sleep(1500);
            firefox.FindElement(By.XPath("//*[@id=\"chat-ctrl\"]/section[2]/section[4]/div/div/div[2]/div/div[1]/button")).Click();

            Thread.Sleep(2000);
            firefox.FindElement(By.XPath("//*[@id=\"chat-ctrl\"]/section[2]/section[6]/div/button")).Click();
           


            Thread.Sleep(20000);
            firefox.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/button[2]")).Click();

            Thread.Sleep(9000);
            firefox.FindElement(By.XPath("//*[@id=\"recaptcha-anchor\"]/div[4]")).Click();

        }
    }
}
