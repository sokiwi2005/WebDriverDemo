using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriverDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//
            IWebDriver driver = new FirefoxDriver();
            driver.Url ="http://www.google.com";


            //Iwebelement is a object h, hover over findElement and you'll see Iwebelement at the tope 
            //that's the type
            // var is a catchon, it can be replaced by 
            // by is a static class - that's why we don't need to create a new object for it.
            // we can directly call it's methods
            //instantiate an object

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Sonal Keyal");
            var submitSearch = driver.FindElement(By.Name("btnK"));
            submitSearch.Click();

            var imagesLink = driver.FindElement(By.XPath("//a[text()=\"Images\"]"));
            imagesLink.Click();

            var firstImage = driver.FindElements(By.XPath("(//img[@alt=\"Image result for Sonal Keyal\"])[1]"));
            firstImage[0].Click();


          
            /*

			//Calling parametrised constructor

			//Animal kitty = new Animal(1, "cat", "meow", 5);

            Human girl = new Human(23,167,"Rammy",51, kitty, 8);

            Human girl3 = new Human("Sonal");


            Human girl4 = new Human();
 

            // Constructors can be automatically called only during creation of an object

          //  girl.birthdayCheck("my birthday");



           // Human girl2 = new Human(10, 150, "Fairy", 51);


            kitty.scoldIt();
            kitty.whereWillYouPoop();




            Animal tinkerbell = new Animal(12, "cat", "meow", 6);

            Human girl6 = new Human(12, 134, "Mary", 51, tinkerbell, 6);



            */





        }
    }
}
