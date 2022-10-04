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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;



namespace Bot
{

    public partial class Form1 : Form
    {

        public FirefoxDriver firefox;
        public LogicFarm logicFarm; 
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = true;



        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter file = File.CreateText(@"d:\tesx.json");
                var text = JsonConvert.SerializeObject(firefox.Manage().Cookies.AllCookies, Newtonsoft.Json.Formatting.None);
                file.Write(text);
                file.Close();
                if (firefox != null) firefox.Quit();
            }
            catch
            {

            }
          


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
                string name = item.name;
                string value = item.value;
                Cookie ck = new Cookie(name, value);
                firefox.Manage().Cookies.AddCookie(ck);
            }
            firefox.Navigate().Refresh();

   
        }

        public void InitFirefox()
        {
            FirefoxDriverService servise = FirefoxDriverService.CreateDefaultService();
            servise.HideCommandPromptWindow = true;

            FirefoxOptions options = new FirefoxOptions();
            firefox = new FirefoxDriver(servise, options);

         
        }

     





































        private void enter_Click(object sender, EventArgs e)
        {
            //string textPoisk = richTextBox_search.Text;
            //firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(textPoisk);
            //firefox.FindElement(By.XPath("//input[@class = 'gLFyf gsfi']")).SendKeys(Keys.Enter);
            //Thread.Sleep(2000);
         
         

        }
        private void LeftWindow_Click(object sender, EventArgs e)
        {
            Tabbing.GoLeft(firefox);

        }
        private void RigthWindow_Click(object sender, EventArgs e)
        {
            Tabbing.GoRigth(firefox);

        }
        private void AddWindow_Click(object sender, EventArgs e)
        {
            Tabbing.AddWin(firefox);
        }
        private void BackWebBrowser_Click(object sender, EventArgs e)
        {
            Tabbing.BackWin(firefox);
        }

        private void Fa1_Click(object sender, EventArgs e)
        {
            logicFarm = new LogicFarm();
            Thread.Sleep(2000);
            logicFarm.LikeFb(firefox, richTextBox1);
            Thread.Sleep(1000);
            logicFarm.WatchVideo(firefox);
        }
    }
}
