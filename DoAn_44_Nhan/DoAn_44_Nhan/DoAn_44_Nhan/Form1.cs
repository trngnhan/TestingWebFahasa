using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace DoAn_44_Nhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeOptions options_44_Nhan = new ChromeOptions();

            // Tắt thông báo, popup và thanh thông tin
            options_44_Nhan.AddArgument("--disable-notifications");
            options_44_Nhan.AddArgument("--disable-popup-blocking");
            options_44_Nhan.AddArgument("--disable-infobars");

            // Khởi tạo dịch vụ ChromeDriver
            ChromeDriverService chrome_44_Nhan = ChromeDriverService.CreateDefaultService();
            chrome_44_Nhan.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_44_Nhan = new ChromeDriver(chrome_44_Nhan, options_44_Nhan);
            driver_44_Nhan.Navigate().GoToUrl("https://www.fahasa.com/");
            Thread.Sleep(1000);
        }
    }
}
