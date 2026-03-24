Description:
This project implements a university equipment rental service in C#.
It allows users to register equipment, rent and return it, check availability, and generate reports.

Design Justification:
To make it as SOLID as possible.

Justification: 
I separated some methods into different classes and repositories to make the project more readable and understandable for the User.

Class responsibilities:
Models: User, Equipment, Rental -> DATA
Service: RentalService -> Logic
Interfaces: IRentalService -> Interface

Cohesion:
Rental -> only stores rental data

Coupling:
Service logic -> Adding a new equipment type does not require changes in RentalService.


How to RUN:
1. clone repository
2. in console build an run

Possible:
We can add subclasses for specific equipment types (Laptop, Camera, Projector) with additional fields.

