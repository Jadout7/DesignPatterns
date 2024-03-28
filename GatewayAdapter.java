public class GatewayAdapter implements Payable {

    private IDeal ideal;
    public GatewayAdapter(IDeal ideal) {
        this.ideal = ideal;
    }

    @Override
    public boolean processPayment() {
        return ideal.isValidIban() && ideal.isValidBank() && ideal.isValidAccountName();
    }
}
