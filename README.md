# Repository for Design Patterns Course Year 3 Period 3

_______________________________________________________

## Application Idea

Online Car Showroom System: Application that enables customers to browse cars, place orders, and make payments.

## Design Patterns involved

| Serial Number | Pattern Type   | Pattern Description                                                                                                              | 
|---------------|----------------|----------------------------------------------------------------------------------------------------------------------------------|
| 1.            | Factory Method | Ability to obtain instances of class objects without needing to know the specific implementation details or subclass types       |
| 2.            | Decorator      | Allows things to be added to individual objects dynamically, without affecting the behavior of other objects from the same class | 
| 3.            | Adapter        | Acts as a bridge between two or more incompatible interfaces, allowing them to collaborate without modifying their source code   |
| 4.            | Observer       | Maintains a list of its dependents, and notifies them of any changes in state, usually by calling one of their methods           |

## Design Pattern Implementation

### 1. Factory Method Pattern (Can be either Abstract Class or Interface):

The app offers different types of cuisines, each with its own menu. Implementation of the Factory Method pattern for
generating menu objects based on a selective cuisine.

In Pseudo-Code: Create an abstract class/interface `CarType` representing a menu of food items. Then, create subclasses
like `PetrolCarType`, `DieselCarType`, etc., each implementing the `CarType` abstract class/interface and providing
their own
implementations for generating car types. The `CarTypeFactory` Class acts as a factory method, responsible for creating
instances of car type classes based on the customer's selection.

### 2. Decorator Pattern (Preferably Interface):

Customers may have different preferences for their car, such as adding an air freshener, a rear camera, or an
under-glow. To accommodate these preferences, the Decorator pattern can be implemented to dynamically modify the
features of the car based on customer selections.

In Pseudo-Code: Create a `CarFeature` interface representing a feature of the car. Then, create feature implementations
like `AirFreshener`, `RearCamera`, etc. each adding specific modifications to the base car features. When a customer
selects a
feature, decorators can be dynamically applied based on their preferences.

### 3. Adapter Pattern (Preferably Interface):

The Showroom uses multiple gateways to complete transactions(IDeal, Paypal, ApplePay). However, each
payment gateway may have a different interface for processing payments. We can implement the Adapter pattern to create
adapters for different payment gateways so that the customers can use whatever gateway they prefer.

In Pseudo-Code: Create an `PaymentGateway` interface representing the common operations required for processing
payments. Then, implement adapter classes like `PayPalAdapter`, `IDealAdapter`, etc., each adapting the interface of a
specific payment gateway to the `PaymentGateway` interface.

### Observer Pattern

The Showroom also takes care of a stock management system for their cars and needs to notify interested parties, such as
suppliers, whenever there are changes in the stock levels of certain car models. We can implement the Observer pattern
to achieve this.

In Pseudo-Code: Create a `CarStockSubject` interface that maintains the stock levels of car models. Then, create classes
like `CarModelStockManager` that implement this interface and manages the stock levels of different car models. The 
`CarStockSubject` also maintains a list of observers such as suppliers and notifies them whenever there are changes in 
the stock levels.
