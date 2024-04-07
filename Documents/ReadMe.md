# Project Readme - Car Showroom
___

## Overview
This project is a car showroom application designed to facilitate the purchase of cars with optional features. Users can add cars to their order, each of which may include a maximum of one feature. Additionally, users can proceed to the shopping cart without selecting a feature if desired. The application provides a simple interface for viewing the order, accessing the shopping cart, and making payments.
___

## Design Pattern Implementation

### 1. Factory Method Pattern:

The app offers different types of cars, each with its own engine types. Implementation of the Factory Method pattern for
generating car objects is based on the customer's selective preference.

In Pseudo-Code: Creates classes representing the type of engine the car runs on like `PetrolCar`, `ElectricCar` and `HydrogenCar` each implementing the `Car` abstract class and providing
their own implementations for generating car types. The `CarFactory` Class acts as a factory method, responsible for
creating instances of car type classes based on the customer's selection.

### 2. Decorator Pattern:

Customers may have different preferences for their car, such as adding an air freshener, a rear camera, or an
under-glow. To accommodate these preferences, the Decorator pattern can be implemented to dynamically modify the
features of the car based on customer selections.

In Pseudo-Code: Create a `CarDecorator` class representing a feature of the car. Then, create feature implementations
like `AirFreshener`, `RearCamera`, etc. each adding specific modifications to the base car features. When a customer
selects a feature, it will be dynamically applied to the car.

### 3. Adapter Pattern:

The Showroom uses multiple gateways to complete transactions(IDeal and Credit Card). However, each
payment gateway may have a different interface for processing payments. We can implement the Adapter pattern to create
adapters for different payment gateways so that the customers can use whichever payment gateway they prefer.

In Pseudo-Code: Create `Ideal` and `Credit Card` interfaces representing the common operations required for processing
payments. Then, implement adapter class like `IPayable` adapting the details of the `IDeal` interface to that of the `Credit Card` interface.
___

## Features
- **Car Selection**: Users can select from a variety of cars available in the system.
- **Optional Features**: Each car can have at most one optional feature added to it. When a feature is added to a car, the price of the feature is automatically added to the total price of the car in the order.
- **Order Management**: Multiple cars can be added to an order, and users can view the cars added to the order.
- **Shopping Cart**: Users can access their shopping cart by clicking the cart button located at the top right of the application.
- **Payment Options**: Two payment methods are supported: IBAN and Credit Card. Each method has specific validation rules.
    - *Credit Card*:
        - Must include a CVC code of 3 digits
        - The expiry date must be at least 1 month from the current date
        - The card number must be 14 digits in length.
        - The cardholder's name cannot contain special characters except for spaces and hyphens.
    - *IBAN*:
        - Must start with 2 uppercase letters followed by 2 digits, and then contain between 10 and 13 alphanumeric characters (lowercase letters are not allowed).
        - Users must select a bank from the dropdown,
        - The account holder's name must adhere to similar restrictions as a cardholder's name.
___

## Known Issues
There is a known bug in the MAUI framework where the program may fail to load initially. If this occurs, simply rerun the program to resolve the issue.
___
