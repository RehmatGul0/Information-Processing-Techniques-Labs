using System;
using System.Windows.Forms;

namespace k163680_Q5
{
    public partial class CurrencyConversionForm : Form
    {
        private CurrencyConversion currencyConversion;
        private CurrencyRate[] currencyRates;
        public CurrencyConversionForm()
        {
            InitializeComponent();
            currencyConversion = new CurrencyConversion();
            currencyRates = currencyConversion.GetCurrencyRates();
            for (int i = 0; i < currencyRates.Length; i++)
            {
                SourceCurrencyBox.Items.Add(currencyRates[i].currencyName);
                DestinationCurrencyBox.Items.Add(currencyRates[i].currencyName);
            }
        }

        private void SourceCurrencyLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void DestinationCurrencyLabel_Click(object sender, EventArgs e)
        {

        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SourceCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestinationCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string sourceCurrencyName = SourceCurrencyBox.Text;
            string destinationCurrencyName = DestinationCurrencyBox.Text;
            double amount = 0;
            double.TryParse(AmountBox.Text,out amount);
                
            string sourceCurrencyCode = "";
            string destinationCurrencyCode = "";

            if (sourceCurrencyName!="" && destinationCurrencyName!="" && amount!=0)
            {
                for(int i=0;i<currencyRates.Length; i++)
                {
                    if (sourceCurrencyName == currencyRates[i].currencyName)
                        sourceCurrencyCode = currencyRates[i].currencyCode;

                    if (destinationCurrencyName == currencyRates[i].currencyName)
                        destinationCurrencyCode = currencyRates[i].currencyCode;


                }
                double result = currencyConversion.GetCurrencyConversion(sourceCurrencyCode, amount, destinationCurrencyCode);
                ResultBox.Text = $"{amount} {sourceCurrencyName} = {result} {destinationCurrencyName} ";
            }
        }
    }
}
