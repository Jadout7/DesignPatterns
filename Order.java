import java.util.ArrayList;

class Order {
    private ArrayList<Car> cars;

    public Order() {
        ArrayList<Car> cars = new ArrayList<>();
    }

    public void addItem(Car car) {
        this.cars.add(car);
    }

    public float getTotalPrice() {
        // Calculate and return the total price of the items in the order (for each loop)
        return 0;
    }

    public void pay() {
        // Implement the payment process

    }
}