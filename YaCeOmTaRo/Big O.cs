using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class Big_O : Form
    {
        public Big_O()
        {
            InitializeComponent();

            label3.Text = "";
            label2.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://shunnarski.github.io/BigO.html");
            var user = driver.FindElement(By.XPath("//*[@id=\"codeInput\"]"));
            user.SendKeys(textBox1.Text);
            var boton = driver.FindElement(By.Id("getBigOBtn"));
            boton.Click();
            var result = driver.FindElement(By.Id("resultShow"));
            label2.Text = result.Text;
            var result2 = driver.FindElement(By.Id("codeAnalysis"));
            label3.Text = result2.Text;
            driver.Quit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkSlateGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MidnightBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
            textBox1.Text = "";
            
        }

        private void Big_O_FormClosed(object sender, FormClosedEventArgs e)
        {
            label3.Text = "";
            label2.Text = "";
            textBox1.Text = "";
        }
    }
}
