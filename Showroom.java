import java.util.ArrayList;

public class Showroom {
    private ArrayList<Car> cars;
    private ArrayList<Car> soldCars;

    public Showroom(ArrayList<Car> cars, ArrayList<Car> soldCars) {
        this.cars = cars;
        this.soldCars = soldCars;
    }

    //TODO: method to place order

    //TODO: purchasing multiple cars method

    public ArrayList<Car> getCars() {
        return cars;
    }

    public void addCar(Car car){
        this.cars.add(car);
    }

    public void removeCar(Car car){
        cars.remove(car);
    }

    public ArrayList<Car> getSoldCars() {
        return soldCars;
    }
}
