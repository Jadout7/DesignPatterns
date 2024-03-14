public class PetrolCar extends Car {
    private String fuelType;

    public PetrolCar(long VIN, String brand, String model, int yearMade, float price, String fuelType) {
        super(VIN, brand, model, yearMade, price);
        this.fuelType = fuelType;
    }

    public String getFuelType() {
        return fuelType;
    }

    public void setFuelType(String fuelType) {
        this.fuelType = fuelType;
    }
}