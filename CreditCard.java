import java.time.LocalDate;
public class CreditCard {
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

    public void processPayment() {

    }

    public boolean isValidCVC(int cvc) {
        String cvcString = Integer.toString(cvc);
        if (cvcString.length() == 3 ) {
            return true;
        }
        return false;
    }

    public boolean isValidExpirationDate(LocalDate expirationDate){
        LocalDate today = LocalDate.now();
        if (expirationDate.isAfter(today)){
            return true;
        }
        return false;
    }

    //Could reduce all spacing to 1
    public boolean isValidCardHolder(String cardHolderName){
        String textRegex = "^[A-Za-z\\s]+$";
        if (cardHolderName.matches(textRegex)){
            return true;
        }
        return false;
    }

    public boolean isValidCardNumber(long cardNumber){
        String cardNumberString = Long.toString(cardNumber);
        if (cardNumberString.length() == 14){
            return true;
        }
        return false;
    }
}
