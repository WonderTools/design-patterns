
# Challenge 04

There are 4 common approaches (may be more) to solve [this problem](https://github.com/WonderTools/design-patterns/blob/master/Challenge04.md).
We will discuss the tradeoffs in each of this approach.

## Approach 1

![Approach 1](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach1.png)

### Advantages
* Very easy and understandable

### Limitations
* The requirments given by Mr. X is broken and implementated in multiple classes. This also contains requirments from Mr. Y and others. So SRP violation.
* OCP violoation. It's difficult to add a new charge say Security Charge. Multiple classes have to be modified.
* The presistance and business logic is in the same class. This makes it as the second SRP violation.

## Approach 2
 
![Approach 2](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach2.png)

### Advantages
* Very easy and understandable
* Persistance and buiness logic is segregated

### Limitations
* The requirments given by Mr. X is broken and implementated in multiple classes. This also contains requirments from Mr. Y and others. So SRP violation.
* OCP violoation. It's difficult to add a new charge say Security Charge. Multiple classes have to be modified.

## Approach 3
 
![Approach 3 (Template Method Design Pattern)](https://github.com/WonderTools/design-patterns/blob/master/Solution/approach3.png)

### Advantages
* Very easy and understandable
* Persistance and buiness logic is segregated

### Limitations
* OCP violoation. It's difficult to add a new Rentable. (However it would be more common scenario to add a charge than a rentable, so this would be better that Approach 1 and 2)



