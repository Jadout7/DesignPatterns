import java.time.LocalDate;

public class GatewayAdapter extends CreditCard {

    private IDeal ideal;

    //Not sure what to do with CVC number, Date set to today which will throw an error, Card number must only be 14
    public GatewayAdapter(IDeal ideal) {
        super(ideal.getIban().hashCode() + ideal.getBankName().hashCode(), 000, ideal.getAccountHolderName(), LocalDate.now());
        this.ideal = ideal;
    }

    @Override
    public void processPayment() {
    }
}
