using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sikuli4Net.sikuli_REST;
using Sikuli4Net.sikuli_UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikuliDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //To download JAR files for Sikuli
            APILauncher launcher = new APILauncher(true);
            launcher.Start();

            //Driver definition
            IWebDriver driver = new ChromeDriver();

            //Maximize the driver
            driver.Manage().Window.Maximize();

            //Launch the url
            driver.Navigate().GoToUrl("https://demo.econz.co.nz:1000/AdminPortal/Account/Login/exptest");

            //Screen init
            Screen screen = new Screen();

            //Define Patterns - Username
            Pattern Username = new Pattern(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\SikuliDemo\SikuliDemo\Images\Username.JPG");

            //Define Patterns - Username
            Pattern Password = new Pattern(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\SikuliDemo\SikuliDemo\Images\Password.JPG");

            //Define Patterns - Username
            Pattern LoginButton = new Pattern(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\SikuliDemo\SikuliDemo\Images\LoginButton.JPG");

            //Wait for UN
            screen.Wait(Username);
            //Input UN
            screen.Type(Username, "Jiya");

            //Wait for PWD
            screen.Wait(Password);
            //Input PWD
            screen.Type(Password, "Jiya@345");

            //Wait for LB
            screen.Wait(LoginButton);
            //Click LB
            screen.Click(LoginButton);
        }
    }
}
