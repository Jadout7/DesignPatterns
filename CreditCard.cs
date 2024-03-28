using System;

public class CreditCard : Payable
{
    private long CardNumber;
    private int Cvc;
    private string CardHolderName;
    private LocalDate ExpirationDate;

    public CreditCard(long cardNumber, int cvc, string cardHolderName, LocalDate expirationDate)
    {
        CardNumber = cardNumber;
        Cvc = cvc;
        CardHolderName = cardHolderName;
        ExpirationDate = expirationDate;
    }

    public bool ProcessPayment()
    {
        return IsValidCVC() && IsValidCardHolder() && IsValidCardNumber() && IsValidExpirationDate();
    }

    public bool IsValidCVC()
    {
        string cvcString = Cvc.ToString();
        int cvcLength = cvcString.Length;

        return cvcLength == 3;
    }

    public bool IsValidExpirationDate()
    {
        LocalDate today = LocalDate.Now;
        return ExpirationDate.IsAfter(today);
    }

    public bool IsValidCardHolder()
    {
        string textRegex = "^[A-Za-z\\s]+$";
        return !CardHolderName.Matches(textRegex);
    }

    public bool IsValidCardNumber()
    {
        string cardNumberString = CardNumber.ToString();
        return cardNumberString.Length == 14;
    }
}