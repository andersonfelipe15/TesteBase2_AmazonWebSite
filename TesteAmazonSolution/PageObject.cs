using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestGera
{
    public class PageObject
    {
        public string email = "assibrito1971@gmail.com";
        public string comprarAgora = "buy-now-button";
        public string quantity = "quantity";
        public string btnIphoneList = "//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div[7]/div/span/div/div/div[2]/h2/a/span";
        public string btnLupa = "nav-search-submit-text";
        public string txtIhpone = "twotabsearchtextbox";
        public string valorPesquisa = "iphone 11";
     
        // URL do site
        public string url = "https://www.amazon.com.br/";


      

    }
}
