public abstract class FeatureWrapper { // Abstract? Interface?
    public Car car;
    private double price;
    private double taxAmount;

    public FeatureWrapper(Car car, double price, double taxAmount) {
        this.car = car;
        this.price = price;
        this.taxAmount = taxAmount;
    }

    public Car getCar() {
        return car;
    }

    public void setCar(Car car) {
        this.car = car;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public double getTaxAmount() {
        return taxAmount;
    }

    public void setTaxAmount(double taxAmount) {
        this.taxAmount = taxAmount;
    }
}