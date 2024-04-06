using System;
using System.Text.RegularExpressions;

public class IDeal
{
    private string iban;
    private string bankName;
    private string accountHolderName;

    public IDeal(string iban, string bankName, string accountHolderName)
    {
        this.iban = iban;
        this.bankName = bankName;
        this.accountHolderName = accountHolderName;
    }

    public string GetIban()
    {
        return iban;
    }

    public void SetIban(string iban)
    {
        this.iban = iban;
    }

    public string GetBankName()
    {
        return bankName;
    }

    public void SetBankName(string bankName)
    {
        this.bankName = bankName;
    }

    public string GetAccountHolderName()
    {
        return accountHolderName;
    }

    public void SetAccountHolderName(string accountHolderName)
    {
        this.accountHolderName = accountHolderName;
    }

    public bool IsValidIban()
    {
        if (iban.Length < 5 && iban.Length > 32)
        {
            return false;
        }
        if (iban.StartsWith("^[A-Z]{2}[0-9]{2}[A-Z0-9]{9,34}$"))
        {
            return false;
        }
        return true;
    }

    public bool IsValidBank()
    {
        string textRegex = "^\\p{L}+(?:[- ]\\p{L}+)*$";
        return Regex.IsMatch(bankName, textRegex);
    }

    public bool IsValidAccountName()
    {
        string textRegex = "^\\p{L}+(?:[- ]\\p{L}+)*$";
        return Regex.IsMatch(accountHolderName, textRegex);
    }
}
