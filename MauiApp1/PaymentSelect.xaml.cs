using System.Text;

namespace MauiApp1;

public partial class PaymentSelect : ContentPage
{
    private bool isCreditCard = true;

    public PaymentSelect()
	{
		InitializeComponent();
	}

    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage(); // Replace with your actual exit logic
    }

    private void PayButton_Clicked(object sender, EventArgs e)
    {
        // Handle payment logic here (e.g., check selected bank in idealDropdown)
        Application.Current.MainPage = new MainPage(); // Replace with your success page
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (isCreditCard)
        {
            long tempCardNumber = long.Parse(CardNumber.Text);
            int tempCVC = int.Parse(CVC.Text);
            int tempMonth  = int.Parse(ExpirationDate.Text.Substring(0, 2));
            int tempYear  = int.Parse(ExpirationDate.Text.Substring(3, 4)); //+1 position because of the "/"
            DateTime  tempExpirationDate = new DateTime(tempYear, tempMonth, 01);
            CreditCard tempCard = new CreditCard(tempCardNumber,tempCVC,CardHolderName.Text, tempExpirationDate);

            if (tempCard.ProcessPayment())
            {
                Application.Current.MainPage = new MainPage();
            }
            else
            {
                DisplayAlert("PaymentError", "One or more entries incorrect", "OK");
            }
        } 
        else 
        { 
            string tempBankName = IdealBank.SelectedItem.ToString();
            IDeal tempIdeal = new IDeal(Iban.Text, tempBankName, AccountHolderName.Text);
            GatewayAdapter tempAdapter = new GatewayAdapter(tempIdeal);

            if (tempAdapter.ProcessPayment())
            {
                Application.Current.MainPage = new MainPage();
            } 
            else
            {
                DisplayAlert("PaymentError", "One or more entries incorrect", "OK");
            }
        }
    }

    private void CreditCardButton(object sender, EventArgs e)
    {
        CreditCard.BackgroundColor = Color.FromArgb("FF5959");
        Ideal.BackgroundColor = Color.FromArgb("#ADDFFF");

        CardNumber.IsVisible = true;
        CardInformation.IsVisible = true;
        CardHolderName.IsVisible = true;

        IdealBank.IsVisible = false;
        Iban.IsVisible = false;
        //AccountName.IsVisible = false;
        AccountHolderName.IsVisible = false;

        isCreditCard = true;
    }

    private void IdealButton(object sender, EventArgs e)
    {
        Ideal.BackgroundColor = Color.FromArgb("FF5959");
        CreditCard.BackgroundColor = Color.FromArgb("#ADDFFF");

        CardNumber.IsVisible = false;
        CardInformation.IsVisible = false;
        CardHolderName.IsVisible = false;

        IdealBank.IsVisible = true;
        Iban.IsVisible = true;
        //AccountName.IsVisible = true;
        AccountHolderName.IsVisible = true;

        isCreditCard = false;
    }

    private void ExpirationDate_TextChanged(object sender, TextChangedEventArgs e)
    {

        string currentText = e.NewTextValue;

        // Check if the length is 2 and the last character is not already "/"
        if (currentText.Length == 3 && currentText[currentText.Length - 1] != '/')
        {

            StringBuilder modifiedString = new StringBuilder(currentText);

            modifiedString.Insert(2, "/");

            ExpirationDate.Text = modifiedString.ToString(); 
        }

        if (currentText.Length > 7)
        {
            ExpirationDate.Text = currentText.Substring(0, 7);
        }
    }

    private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
    {
        string currentText = e.NewTextValue;

        if (currentText.Length > 14)
        {
            CardNumber.Text = currentText.Substring(0, 14);
        }
    }

    private void CVC_TextChanged(object sender, TextChangedEventArgs e)
    {
        string currentText = e.NewTextValue;

        if (currentText.Length > 3)
        {
            CVC.Text = currentText.Substring(0, 3);
        }
    }
}