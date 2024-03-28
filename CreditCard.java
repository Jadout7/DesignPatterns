import java.time.LocalDate;
public class CreditCard implements Payable{
    private long cardNumber;
    private int cvc;
    private String cardHolderName;
    private LocalDate expirationDate;

    public CreditCard(long cardNumber, int cvc, String cardHolderName, LocalDate expirationDate) {
        this.cardNumber = cardNumber;
        this.cvc = cvc;
        this.cardHolderName = cardHolderName;
        this.expirationDate = expirationDate;
    }

    @Override
    public boolean processPayment() {
        //*if(isValidCVC() && isValidCardHolder() && isValidCardNumber() && isValidExpirationDate())
        return isValidCVC() && isValidCardHolder() && isValidCardNumber() && isValidExpirationDate();
    }

    public boolean isValidCVC() {
        String cvcString = Integer.toString(cvc);
        //boolean isValid = false;
        int cvcLength = cvcString.length();

        if (cvcLength == 3) {
            return true; // Must be 3 digits
        }
        return false;
    }

    public boolean isValidExpirationDate(){
        LocalDate today = LocalDate.now();
        if (expirationDate.isAfter(today)){
            return true;
        }
        return false;
    }

    //Could reduce all spacing to 1
    public boolean isValidCardHolder(){
        String textRegex = "^[A-Za-z\\s]+$";
        if (cardHolderName.matches(textRegex)){
            return false;
        }
        return true;
    }

    public boolean isValidCardNumber(){
        String cardNumberString = Long.toString(cardNumber);
        if (cardNumberString.length() == 14){
            return true;
        }
        return false;
    }
}
