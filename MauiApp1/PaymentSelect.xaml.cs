namespace MauiApp1;

public partial class PaymentSelect : ContentPage
{
    string selectedColour = "FF5959";

    public PaymentSelect()
	{
		InitializeComponent();
	}

    private void RadioButtonIdeal(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton radioButton && radioButton.IsChecked)
        {
            //idealPicker.IsVisible = true;
        }
    }

    private void RadioButtonCreditCard(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton radioButton && radioButton.IsChecked)
        {
            //idealPicker.IsVisible = false;
        }
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
        CardNumber.IsVisible = false;
        ExpirationDate.IsVisible = false;
        CVC.IsVisible = false;
        CardHolderName.IsVisible = false;

        Iban.IsVisible = true;
        AccountName.IsVisible = true;
        AccountNumber.IsVisible = true;

        Pay.BackgroundColor = Color.FromArgb("ADDFFF");
    }

    private void CreditCardButton(object sender, EventArgs e)
    {
        CreditCard.BackgroundColor = Color.FromArgb("FF5959");
        Ideal.BackgroundColor = Color.FromArgb("#ADDFFF");

        CardNumber.IsVisible = true;
        ExpirationDate.IsVisible = true;
        CVC.IsVisible = true;
        CardHolderName.IsVisible = true;

        Iban.IsVisible = false;
        AccountName.IsVisible = false;
        AccountNumber.IsVisible = false;

    }

    private void IdealButton(object sender, EventArgs e)
    {
        Ideal.BackgroundColor = Color.FromArgb("FF5959");
        CreditCard.BackgroundColor = Color.FromArgb("#ADDFFF");

        CardNumber.IsVisible = false;
        ExpirationDate.IsVisible = false;
        CVC.IsVisible = false;
        CardHolderName.IsVisible = false;

        Iban.IsVisible = true;
        AccountName.IsVisible = true;
        AccountNumber.IsVisible = true;

    }
}