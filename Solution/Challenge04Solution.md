
# Challenge 04

There are 4 common approaches (may be more) to solve [this problem](https://github.com/WonderTools/design-patterns/blob/master/Challenge04.md).
We will discuss the tradeoffs in each of this approach.

## Approach 1

![Approach 1](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach1.png?raw=true)
[Code](https://github.com/WonderTools/design-patterns/blob/master/MallCharges/MallChargesCalculator-Approach1.zip?raw=true)

### Advantages
* Very easy and understandable

### Limitations
* The requirments given by Mr. X is broken and implementated in multiple classes. This also contains requirments from Mr. Y and others. So SRP violation.
* OCP violoation. It's difficult to add a new charge say Security Charge. Multiple classes have to be modified.
* The presistance and business logic is in the same class. This makes it as the second SRP violation.

## Approach 2
 
![Approach 2](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach2.png?raw=true)
[Code](https://github.com/WonderTools/design-patterns/blob/master/MallCharges/MallChargesCalculator-Approach2.zip?raw=true)
### Advantages
* Very easy and understandable
* Persistance and buiness logic is segregated

### Limitations
* The requirments given by Mr. X is broken and implementated in multiple classes. This also contains requirments from Mr. Y and others. So SRP violation.
* OCP violoation. It's difficult to add a new charge say Security Charge. Multiple classes have to be modified.

## Approach 3
 
![Approach 3 (Template Method Design Pattern)](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach3.png?raw=true)
[Code](https://github.com/WonderTools/design-patterns/blob/master/MallCharges/MallChargesCalculator-Approach3.zip?raw=true)

### Advantages
* Very easy and understandable
* Persistance and buiness logic is segregated

### Limitations
* OCP violoation. It's difficult to add a new Rentable. (However it would be more common scenario to add a charge than a rentable, so this would be better that Approach 1 and 2)

## Approach 4
 
![Approach 4 (Visitor Design Pattern)](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach4.png?raw=true)
[Code](https://github.com/WonderTools/design-patterns/blob/master/MallCharges/MallChargesCalculator-Approach4.zip?raw=true)

### Advantages
* Clean
* Introduction of a rentable will have a compile time check. (Run time check in Approach 3)

### Limitations
* OCP violoation. It's difficult to add a new Rentable. (However it would be more common scenario to add a charge than a rentable, so this would be better that Approach 1 and 2)
* A bit complex (Developers need to familiar with Visitor Pattern)
* A reverse coupling in the solution. (eg. ShowRoom know about the existance of Stall due to Visitor)




