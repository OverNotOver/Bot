using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zu.WebBrowser.AsyncInteractions;
using IJavaScriptExecutor = OpenQA.Selenium.IJavaScriptExecutor;

namespace Bot
{
    public class LogicFarm
    {
        public static int positionY = 0;
        public WebDriver driver;
        public RichTextBox richTextBox1;
       




        public void LikeFb(WebDriver driver, RichTextBox richTextBox1)
        {
            try
            {
                ScrollDown(driver);
                ScrollDown(driver);
                var likes = driver.FindElements(By.XPath("//span[text()='Нравится']"));
                Random random = new Random();
                int likePost = 0;

                if(likes != null && likes.Count > 0)
                {
                    foreach (var like in likes)
                    {
                        ScrollDown(driver);
                        for (int i = 0; i < likes.Count; i++)
                        {
                            Thread.Sleep(2000);
                            if (random.Next(0, 100) >= 30)
                            {
                                likes[i].Click();
                                likePost++;
                                richTextBox1.Text += likePost.ToString();
                                if (likePost >= 10)
                                {
                                    break;
                                }
                                else if (likePost >= 5)
                                {
                                    Thread.Sleep(2000);
                                    driver.Navigate().Refresh();
                                    Thread.Sleep(3500);
                                    ScrollDown(driver);

                                }
                            }

                            ScrollDown(driver);
                            ScrollDown(driver);
                        }
                    }
                }
                else
                {
                    driver.Navigate().Refresh();
                    Thread.Sleep(3500);
                    LikeFb(driver, richTextBox1);
                }

                

            }
            catch(Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }





        }

        public void WatchVideo(WebDriver driver)
        {

            driver.FindElement(By.XPath("//a[@href='/watch/?ref=tab']")).Click();
            ScrollDown(driver);
            ScrollDown(driver);
            Thread.Sleep(5000);
            ScrollDown(driver);
            ScrollDown(driver);
            Thread.Sleep(5000);
            ScrollDown(driver);
            ScrollDown(driver);
        }


        public void ScrollDown(WebDriver driver)
        {
            positionY += new Random().Next(50, 200);
            Thread.Sleep(new Random().Next(50, 200));
            ((IJavaScriptExecutor)driver).ExecuteScript($"window.scroll(0, {positionY});");
        }
    }
}
