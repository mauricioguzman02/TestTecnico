using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using Assert = NUnit.Framework.Assert;
using Microsoft.Win32;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAutomation
    {
        IWebDriver driver;
        Registro registro;

        [SetUp]
        public void Inicializar()
        {
            // Inicializar el controlador del navegador
            driver = new ChromeDriver();
            registro = new Registro(driver);
        }

        [Test]
        public void MiPruebaConPOM()
        {
            driver.Navigate().GoToUrl("https://utest.com/");
            Thread.Sleep(3000);
            registro.Registrar.Click();
            Thread.Sleep(3000);
            registro.FirtsName.SendKeys("Mauricio");
            registro.LastName.SendKeys("Guzman");
            registro.Email.SendKeys("MaoGuzman" + new Random().Next(1, 1000) + "@gmail.com");
            registro.DiaSelect.SelectByIndex(1);
            registro.MesSelect.SelectByIndex(1);
            registro.AnioSelect.SelectByIndex(3);
            Thread.Sleep(3000);
            registro.Siguiente1.Click();
            Thread.Sleep(3000);
            registro.Siguiente2.Click();
            Thread.Sleep(3000);
            registro.Siguiente3.Click();
            Thread.Sleep(3000);
            registro.Password.SendKeys("Sistemas2020*");
            Thread.Sleep(3000);
            registro.Password2.SendKeys("Sistemas2020*");
            registro.TerminosUso.Click();
            registro.Aceptar.Click();
            Thread.Sleep(3000);
            registro.Terminar.Click();
            Thread.Sleep(3000);
            Assert.AreEqual(true,true);
        }

        [TearDown]
        public void Limpiar()
        {
            // Cerrar el navegador al finalizar la prueba
            driver.Quit();
        }
    }
}
