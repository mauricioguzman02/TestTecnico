using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Registro
    {
        private IWebDriver driver;

        // Elementos de la página
        public IWebElement Registrar => driver.FindElement(By.XPath("//unauthenticated-header/div[1]/div[3]/ul[2]/li[2]/a[1]"));
        public IWebElement FirtsName => driver.FindElement(By.Id("firstName"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement TerminosUso => driver.FindElement(By.Id("termOfUse"));
        public IWebElement Aceptar => driver.FindElement(By.Id("privacySetting"));
        public IWebElement Terminar => driver.FindElement(By.Id("laddaBtn"));
        

        public IWebElement Password2 => driver.FindElement(By.CssSelector("#confirmPassword"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Siguiente1 => driver.FindElement(By.XPath("//span[contains(text(),'Next: Location')]"));
        public IWebElement Siguiente2 => driver.FindElement(By.XPath("//span[contains(text(),'Next: Devices')]"));
        public IWebElement Siguiente3 => driver.FindElement(By.XPath("//span[contains(text(),'Next: Last Step')]"));
        
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Dia => driver.FindElement(By.XPath("//select[@id='birthDay']"));
        public SelectElement DiaSelect =>  new SelectElement(Dia);

        public IWebElement Mes => driver.FindElement(By.XPath("//select[@id='birthMonth']"));
        public SelectElement MesSelect => new SelectElement(Mes);

        public IWebElement Anio => driver.FindElement(By.XPath("//select[@id='birthYear']"));
        public SelectElement AnioSelect => new SelectElement(Anio);
        // Constructor
        public Registro(IWebDriver driver)
        {
            this.driver = driver;
        }
   }
}
