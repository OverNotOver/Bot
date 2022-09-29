using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;
using System.Xml;
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
            StreamWriter file = File.CreateText(@"d:\tesx.json");
            var text = JsonConvert.SerializeObject(firefox.Manage().Cookies.AllCookies, Newtonsoft.Json.Formatting.None);
            file.Write(text);
            file.Close();

            if (firefox != null) firefox.Quit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitFirefox();
            firefox.Navigate().GoToUrl("https://www.facebook.com/");
            string path = @"d:\cook.json";
            StreamReader stream = File.OpenText(path);
            JsonTextReader reader = new JsonTextReader(stream);
            JsonSerializer serializer = new JsonSerializer();
            dynamic load = serializer.Deserialize(reader);
            stream.Close();

            foreach (dynamic item in load)
            {
                //firefox.Manage().Cookies.AddCookie(item);
                //richTextBox_text.Text = item.name;
                string name = item.name;
                string value = item.value;
                Cookie ck = new Cookie(name, value);
                firefox.Manage().Cookies.AddCookie(ck);
            }

            firefox.Navigate().Refresh();

            //StreamReader reader = new StreamReader(path);
            //string data = reader.ReadToEnd();
            //reader.Close();           
            //dynamic cook = JsonConvert.DeserializeObject(File.ReadAllText(data));






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
            firefox.Navigate().GoToUrl("https://www.facebook.com/");






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

        private void button4_Click(object sender, EventArgs e)
        {

            

            //DateTime time = new DateTime(2017, 03, 22, 23, 02, 03);
            
            //Browser.Manage().Cookies.AddCookie(ck);

            //Cookie cookie = new Cookie(item.name, item.value);
            



        }
    }
}
