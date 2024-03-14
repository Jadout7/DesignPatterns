public abstract class Car {
    private long VIN;
    private String brand;
    private String model;
    private int yearMade;
    private float price;

    public Car(long VIN, String brand, String model, int yearMade, float price) {
        this.VIN = VIN;
        this.brand = brand;
        this.model = model;
        this.yearMade = yearMade;
        this.price = price;
    }

    public long getVIN() {
        return VIN;
    }

    public String getBrand() {
        return brand;
    }

    public String getModel() {
        return model;
    }

    public int getYearMade() {
        return yearMade;
    }

    public float getPrice() {
        return price;
    }

    public double calculateTax() {
        // Calculation logic for tax
        double tax = 0;
        return tax;
    }

    public void addFeature(FeatureWrapper feature) {
        // Addition logic for feature
    }

    public void removeFeature(FeatureWrapper feature) {
        // Removal logic for feature
    }
}