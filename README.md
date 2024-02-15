# Repository for Design Patterns Course Year 3 Period 3

_______________________________________________________

## Application Idea

UberEats / Thuizbezorged / Intercontinental Food Ordering System: Application that enables customers to browse menus,
place orders, and make payments.

## Design Patterns involved

| Serial Number | Pattern Type   | Pattern Description                                                                                                              | 
|---------------|----------------|----------------------------------------------------------------------------------------------------------------------------------|
| 1.            | Factory Method | Ability to obtain instances of class objects without needing to know the specific implementation details or subclass types       |
| 2.            | Decorator      | Allows things to be added to individual objects dynamically, without affecting the behavior of other objects from the same class | 
| 3.            | Adapter        | Acts as a bridge between two or more incompatible interfaces, allowing them to collaborate without modifying their source code   |

## Design Pattern Implementation

### 1. Factory Method Pattern (Can be either Abstract Class or Interface):

The app offers different types of cuisines, each with its own menu. Implementation of the Factory Method pattern for
generating menu objects based on a selective cuisine.

In Pseudo-Code: Create an abstract class/interface `Menu` representing a menu of food items. Then, create subclasses
like `ItalianMenu`, `ChineseMenu`, etc., each implementing the `Menu` abstract class/interface and providing their own
implementations for generating menu items. The `MenuFactory` Class acts as a factory method, responsible for creating
instances of menu classes based on the customer's selected cuisine.

### 2. Decorator Pattern (Preferably Interface):

Customers may have different dietary preferences(gluten-free, vegetarian, or vegan), so to accommodate these
preferences, the Decorator pattern can be implemented to dynamically add or modify the behavior of menu items based on
customer selections.

In Pseudo-Code: Create a `MenuItem` interface representing a food item on the menu. Then, create food implementations
like `Pizza`, `Chow Mein`, etc. Also, implement decorator classes like `GlutenFreeDecorator`, `VegetarianDecorator`,
etc., each adding specific dietary modifications to the base menu items. When a customer selects a menu item, decorators
can be dynamically applied based on their preferences.

### 3. Adapter Pattern (Preferably Interface):

Uber/Thuizbezorged/whatever uses multiple gateways to complete trasnactions(IDeal, Paypal, ApplePay). However, each
payment gateway may have a different interface for processing payments. We can implement the Adapter pattern to create
adapters for different payment gateways so that the customers can use whatever gateway they prefer.

In Pseudo-Code: Create an `PaymentGateway` interface representing the common operations required for processing
payments. Then, implement adapter classes like `PayPalAdapter`, `IDealAdapter`, etc., each adapting the interface of a
specific payment gateway to the `PaymentGateway` interface.

