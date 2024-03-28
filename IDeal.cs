using System;

public class IDeal
{
    private string iban;
    private string bankName;
    private string accountHolderName;

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
        if (!iban.StartsWith("^[A-Z]{2}[0-9]{2}$"))
        {
            return false;
        }
        if (!Regex.IsMatch(iban.Substring(4), "^[A-Z0-9]+$"))
        {
            return false;
        }
        return true;
    }

    public bool IsValidBank()
    {
        if (!Regex.IsMatch(bankName, "^[a-zA-Z]+$"))
        {
            return false;
        }
        return true;
    }

    public bool IsValidAccountName()
    {
        if (!Regex.IsMatch(accountHolderName, "^[a-zA-Z]+$"))
        {
            return false;
        }
        return true;
    }
}
