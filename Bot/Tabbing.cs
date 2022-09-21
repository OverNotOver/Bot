using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot
{
    public class Tabbing
    {
        static int page = 0;

    

        public static void GoLeft(FirefoxDriver driverFox)
        {
            if (page > 0)
            {
                page--;
                driverFox.SwitchTo().Window(driverFox.WindowHandles[page]);
          
            }
        }

        public static void GoRigth(FirefoxDriver driverFox)
        {
            if (page < driverFox.WindowHandles.Count - 1)
            {
                page++;
                driverFox.SwitchTo().Window(driverFox.WindowHandles[page]);
            }
        }

        public static void AddWin(FirefoxDriver driverFox)
        {
            page++;
            driverFox.SwitchTo().NewWindow(WindowType.Tab);

        }

        public static void BackWin(FirefoxDriver driverFox)
        {
            driverFox.SwitchTo().Window(driverFox.CurrentWindowHandle).Navigate().Back();
        }
    }
}
