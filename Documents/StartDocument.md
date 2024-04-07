# Repository for Design Patterns Course Year 3 Period 3

_______________________________________________________

## Problem Description

In 2024 the automotive world has a wide variety of vehicles whether they are diesel, petrol or if your environmentally conscious electric.
Our car showroom has everything you could possibly need. Whether it's a daily driver or your dream mobile. Our showroom allows you car customisation
where you let your wishes be our command. We offer a way of getting the car you want and how you want it directly to you. The best part?, your in control
the whole time!

The project aims to develop a comprehensive order management system for a car showroom. The system allows customers to browse through available cars, 
add multiple cars to their order, optionally add features to selected cars, view their order summary, and proceed to make payments using a payment 
interface of their choice. The primary goal is to create an intuitive and user-friendly interface that simplifies the car ordering process and enhances 
the overall customer experience.

_______________________________________________________

## Design Patterns Involved

| Serial Number | Pattern Type   | Pattern Description                                                                                                              | 
|:-------------:|----------------|----------------------------------------------------------------------------------------------------------------------------------|
|      1.       | Factory Method | Ability to obtain instances of class objects without needing to know the specific implementation details or subclass types       |
|      2.       | Decorator      | Allows things to be added to individual objects dynamically, without affecting the behavior of other objects from the same class | 
|      3.       | Adapter        | Acts as a bridge between two or more incompatible interfaces, allowing them to collaborate without modifying their source code   |

#### Pattern Implementation will be described in detail in the ReadMe file.
_______________________________________________________

## MoSCoW Analysis

| Serial Number | Requirement                                                       | Must have | Should have | Could have | Won't have |
|:-------------:|-------------------------------------------------------------------|:---------:|:-----------:|:----------:|:----------:|
|      1.       | Ability to purchase multiple cars in a single order               |     ✅     |             |            |            |
|      2.       | Ability to customise your car prior to placing an order           |     ✅     |             |            |            |
|      3.       | Ability to see the summary of the ordered items                   |           |      ✅      |            |            |
|      4.       | Adding a 4th pattern in case we need to fall back on it           |           |             |     ✅      |            |
|      5.       | Ability to register and create users                              |           |             |            |     ✅      |


_______________________________________________________
