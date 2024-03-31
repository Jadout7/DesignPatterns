using System;
using System.Text.RegularExpressions;

public class CreditCard : IPayable
{
    private long CardNumber;
    private int Cvc;
    private string CardHolderName;
    private DateTime ExpirationDate;

    public CreditCard(long cardNumber, int cvc, string cardHolderName, DateTime expirationDate)
    {
        CardNumber = cardNumber;
        Cvc = cvc;
        CardHolderName = cardHolderName;
        ExpirationDate = expirationDate;
    }

    public bool ProcessPayment()
    {
        return IsValidCardHolder() && IsValidCVC() && IsValidCardNumber() && IsValidExpirationDate();
    }

    public bool IsValidCVC()
    {
        string cvcString = Cvc.ToString();
        int cvcLength = cvcString.Length;

        return cvcLength == 3;
    }

    public bool IsValidExpirationDate()
    {
        DateTime today = DateTime.Now;
        return ExpirationDate > DateTime.Today;
    }

    public bool IsValidCardHolder()
    {
        string textRegex = "^\\p{L}+(?:[- ]\\p{L}+)*$";
        return Regex.IsMatch(CardHolderName, textRegex);
    }

    public bool IsValidCardNumber()
    {
        string cardNumberString = CardNumber.ToString();
        return cardNumberString.Length == 14;
    }
}