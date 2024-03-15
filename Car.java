public abstract class Car {
    private long vin;
    private String brand;
    private String model;
    private int yearMade;
    private float price;

    public Car(long vin, String brand, String model, int yearMade, float price) {
        this.vin = vin;
        this.brand = brand;
        this.model = model;
        this.yearMade = yearMade;
        this.price = price;
    }

    public long getVin() {
        return vin;
    }

    public void setVin(long vin) {
        this.vin = vin;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getYearMade() {
        return yearMade;
    }

    public void setYearMade(int yearMade) {
        this.yearMade = yearMade;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public float calculateTax()
    {
        // Calculation logic for tax
        return 0;
    }

    public float getPriceWithTax() {
        return getPrice() + calculateTax();
    }
}