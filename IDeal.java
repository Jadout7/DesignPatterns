public class IDeal {
    private String iban;
    private String bankName;
    private String accountHolderName;

    public String getIban() {
        return iban;
    }

    public void setIban(String iban) {
        this.iban = iban;
    }

    public String getBankName() {
        return bankName;
    }

    public void setBankName(String bankName) {
        this.bankName = bankName;
    }

    public String getAccountHolderName() {
        return accountHolderName;
    }

    public void setAccountHolderName(String accountHolderName) {
        this.accountHolderName = accountHolderName;
    }

    public boolean isValidIban(){
        if (iban.length() < 5 && iban.length() > 32){
            return false;
        }
        if (!iban.matches("^[A-Z]{2}[0-9]{2}")) {
            return false;
        }
        if (!iban.substring(4).matches("^[A-Z0-9]+$")){
            return false;
        }
        return true;
    }
    public boolean isValidBank() {
        if (!bankName.matches("^[a-zA-Z]+$")){
            return false;
        }
        return true;
    }

    public boolean isValidAccountName() {
        if (!accountHolderName.matches("^[a-zA-Z]+$")){
            return false;
        }
        return true;
    }
}
