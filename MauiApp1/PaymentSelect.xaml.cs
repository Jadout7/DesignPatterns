using System.Text;
namespace MauiApp1;

public partial class PaymentSelect : ContentPage
{
    private bool isCreditCard = true;
    public PaymentSelect()
	{
		InitializeComponent();

    }

    private async void Button_Clicked(object sender, EventArgs e)
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
                await PaymentRedirect();
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
                await PaymentRedirect();
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

    public static async Task PaymentRedirect()
    {
        Order.Instance.Pay();
        await Application.Current.MainPage.DisplayAlert("Payment Success", "Your payment has been processed successfully.", "OK");
        await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Current total", Order.Instance.GetTotalPrice().ToString(),"OK"); 
        await Navigation.PopAsync();
    }
}