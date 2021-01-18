using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TestGera;

namespace TestAmazon2
{


    [TestClass]
    public class ClassUnitTest
    {
        public IWebElement TxtIphone { get; set; }

     
        public IWebElement iphoneLista { get; set; }
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]

        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div[7]/div/span/div/div/div[2]/h2/a/span")]

        PageObject pageobject = new PageObject();

        [TestMethod]
        public void TestNavegateAmazonFinish()
        {
            // Abrir navegador
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new EdgeDriver();

            var navigate = driver.Navigate();

            // Acessando o Site da Amazon
            navigate.GoToUrl(pageobject.url); //w
       
            // Maximinizar janela do navegador
            driver.Manage().Window.Maximize();
      

            // Pesquisando IPHONE 
            var radioButton = driver.FindElement(By.Id(pageobject.txtIhpone));
            radioButton.SendKeys(pageobject.valorPesquisa);

            //Clicando na lupa
            driver.FindElement(By.Id(pageobject.btnLupa)).Click();
            Thread.Sleep(1500);


            //Clicando em um IPhone 
            driver.FindElement(By.XPath(pageobject.btnIphoneList)).Click();


            Thread.Sleep(1000);

            // Selecionando a quantidade do produto
            var dropdown = (driver.FindElement(By.Name(pageobject.quantity)));
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByValue("2");


            //Clicando em comprar
            driver.FindElement(By.Id(pageobject.comprarAgora)).Click();
            Thread.Sleep(1000);

            //Logando com usuario cadastrado
            driver.FindElement(By.Id("ap_email")).SendKeys(pageobject.email);

            driver.FindElement(By.XPath("//*[@id='continue']")).Click();

            Thread.Sleep(1000);

            //Colocando senha
            driver.FindElement(By.Id("ap_password")).SendKeys(pageobject.email);

            // Clicandon em Logar
            driver.FindElement(By.XPath("//*[@id='signInSubmit']")).Click();
            Thread.Sleep(1500);

          
            //Clicando em Confirmar o Pedido
            driver.FindElement(By.XPath("//*[@id='placeYourOrder']/span/input")).Click();


            Thread.Sleep(1000);

            // FINALIZA O TESTE
            driver.Quit();
        }
    }
}
