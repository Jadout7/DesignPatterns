public class CarFactory {

    public Car createCar(Car carType){
        if (carType==null){
            return null;
        }
        //TODO: Ask about should a simple factory be used or factory method or Abstract factory

        if(carType instanceof ElectricCar){
            return new ElectricCar(carType.getVin(),carType.getBrand(),carType.getModel(), carType.getYearMade(), carType.getPrice(), 100);
        } else if (carType instanceof PetrolCar) {
            //I apologise for the typecast but it *should work*
            return new PetrolCar(carType.getVin(),carType.getBrand(),carType.getModel(), carType.getYearMade(), carType.getPrice(), ((PetrolCar) carType).getFuelType());
        } else if (carType instanceof HydrogenCar){
            return new HydrogenCar(carType.getVin(),carType.getBrand(),carType.getModel(), carType.getYearMade(), carType.getPrice(), 100);
        } else return null;

    }
}
