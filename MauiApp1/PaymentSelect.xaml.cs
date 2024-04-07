using System.Text;
namespace MauiApp1;

public partial class PaymentSelect : ContentPage
{
    private bool isCreditCard = true;

    private string notSelected = "#870903";
    private string selected = "#1A4734";

    public PaymentSelect()
	{
		InitializeComponent();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (isCreditCard)
        {
            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(CardNumber.Text) || string.IsNullOrWhiteSpace(CVC.Text) ||
                string.IsNullOrWhiteSpace(ExpirationDate.Text) || string.IsNullOrWhiteSpace(CardHolderName.Text))
            {
                DisplayAlert("PaymentError", "One or more fields are empty", "OK");
                return;
            }

            // Proceed with credit card processing
            long tempCardNumber;
            int tempCVC, tempMonth, tempYear;

            if (!long.TryParse(CardNumber.Text, out tempCardNumber) || !int.TryParse(CVC.Text, out tempCVC) ||
                !int.TryParse(ExpirationDate.Text.Substring(0, 2), out tempMonth) ||
                !int.TryParse(ExpirationDate.Text.Substring(3, 4), out tempYear))
            {
                DisplayAlert("PaymentError", "One or more entries incorrect", "OK");
                return;
            }

            DateTime tempExpirationDate = new DateTime(tempYear, tempMonth, 1);
            CreditCard tempCard = new CreditCard(tempCardNumber, tempCVC, CardHolderName.Text, tempExpirationDate);

            if (tempCard.ProcessPayment())
            {
                PaymentRedirect();
            }
            else
            {
                DisplayAlert("PaymentError", "Payment processing failed", "OK");
            }
        }
        else
        {
            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(Iban.Text) || IdealBank.SelectedItem == null || string.IsNullOrWhiteSpace(AccountHolderName.Text))
            {
                DisplayAlert("PaymentError", "One or more fields are empty", "OK");
                return;
            }

            // Proceed with iDeal processing
            IDeal tempIdeal = new IDeal(Iban.Text, IdealBank.SelectedItem.ToString(), AccountHolderName.Text);
            GatewayAdapter tempAdapter = new GatewayAdapter(tempIdeal);

            if (tempAdapter.ProcessPayment())
            {
                PaymentRedirect();
            }
            else
            {
                DisplayAlert("PaymentError", "Payment processing failed", "OK");
            }
        }
    }


    private void CreditCardButton(object sender, EventArgs e)
    {
        CreditCard.BackgroundColor = Color.FromArgb(selected);
        Ideal.BackgroundColor = Color.FromArgb(notSelected);

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
        Ideal.BackgroundColor = Color.FromArgb(selected);
        CreditCard.BackgroundColor = Color.FromArgb(notSelected);

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

    public async void PaymentRedirect()
    {
        float finalPrice = Order.Instance.GetTotalPrice();
        Order.Instance.Pay();
        await DisplayAlert("Payment Success", "Your payment has been processed successfully. Total order cost: " + finalPrice.ToString("C"), "OK");
        Application.Current.MainPage = new Showroom();
    }

    private void Cancel_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Current total", Order.Instance.GetTotalPrice().ToString(),"OK");
        Application.Current.MainPage = new ShoppingCart();
    }
}