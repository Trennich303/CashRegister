using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

using System.Windows.Forms;

using System.Threading;
namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double BaseballHatsPrice = 5.50;
        double BeanieHatsPrice = 7.25;
        double TopHatsPrice = 10.75;
        double NumberOfBaseballHats;
        double NumberOfBeanieHats;
        double NumberOfTopHats;
        double SubTotalPrice;
        double TaxPrice = 0.13;
        double TotalAmountPrice;
        double TenderedPrice;
        double ChangePrice;
        
        
        private void Totalbutton_Click(object sender, EventArgs e)
        {

            try
            {
                NumberOfBaseballHats = Convert.ToInt32(Textbox1.Text);
                NumberOfBeanieHats = Convert.ToInt32(Textbox2.Text);
                NumberOfTopHats = Convert.ToInt32(Textbox3.Text);
                SubTotalPrice = NumberOfBaseballHats * BaseballHatsPrice + NumberOfBeanieHats * BeanieHatsPrice + NumberOfTopHats * TopHatsPrice;
                SubTotalsTextBox.Text = $"{SubTotalPrice}";
                SubTotalsTextBox.Text = SubTotalPrice.ToString("c");
                TaxTextBox.Text = $"{TaxPrice}";
                TotalAmountPrice = SubTotalPrice * TaxPrice + SubTotalPrice;
                TotalTextBox.Text = $"{TotalAmountPrice}";
                TotalTextBox.Text = TotalAmountPrice.ToString("C");
            }
            catch
            {
                ReceiptLabel.Text = "please use a number";
            }
            
            }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
            
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                TenderedPrice = Convert.ToInt32(TenderedBox.Text);
                ChangePrice = TenderedPrice - TotalAmountPrice;
                ChangeBox.Text = $"{ChangePrice}";
                ChangeBox.Text = ChangePrice.ToString("C");
            }

            catch
            {
                ReceiptLabel.Text = "Please us a number";
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            ReceiptLabel.Text = $"                             The Hat Store";
            Thread.Sleep(1000);
            this.Refresh();
           
            ReceiptLabel.Text += $"   \n\n Order Number 1067";
            Thread.Sleep(1000);
            this.Refresh();
           
            ReceiptLabel.Text += $"   \n May 5, 2021";
            Thread.Sleep(1000);
            this.Refresh();
          
            ReceiptLabel.Text += $"   \n\n\n BaseBallHats      x{NumberOfBaseballHats}   @   {BaseballHatsPrice}0";
            Thread.Sleep(1000);
            this.Refresh();
           
            ReceiptLabel.Text += $"   \n BaseBallHats      x{NumberOfBeanieHats}   @   {BeanieHatsPrice}";
            Thread.Sleep(1000);
            this.Refresh();
           
            ReceiptLabel.Text += $"   \n BaseBallHats      x{NumberOfTopHats}   @   {TopHatsPrice}";
            Thread.Sleep(1000);
            this.Refresh();
            
            ReceiptLabel.Text += $"   \n\n\n Sub Total Price                {SubTotalPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
           
            ReceiptLabel.Text += $"   \n Tax                                  {TaxPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
          
            ReceiptLabel.Text += $"   \n Total                                {TotalAmountPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
           
            ReceiptLabel.Text += $"   \n\n\n Tendered                         {TenderedPrice.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
          
            ReceiptLabel.Text += $"   \n Change                            {ChangePrice.ToString("C")}";
            Thread.Sleep(500);
            this.Refresh();
            NewOrderButton.Enabled = true;

        }

        private void NewOrderButton_Click(object sender, EventArgs e) {
            ReceiptLabel.Text = "";
            ChangeBox.Text = "";
            Textbox1.Text = "";
            Textbox2.Text = "";
            Textbox3.Text = "";
            SubTotalsTextBox.Text = "";
            TaxTextBox.Text = "";
            TotalTextBox.Text = "";
            TenderedBox.Text = "";


        }
    }
}
