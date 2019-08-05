
# Challenge 04

You have been hired as a developer for developing an application that helps in making renting agreements for a huge real estate company. The company builds malls and rents parts of the malls to their clients. The company rents Theaters, Multiplexes, FoodCourts, Eateries, Showrooms, Stalls, Parking Spaces and Advertisement boards.

While negotiating the rent for the properties. It's important to inform that clients about the water charges, electricty charges and cleaning charges along with the rent. The water supply to the mall is managed by Mr. X and his department. The electricty is managed by Mr. Y and his department, the general cleanliness is maintained by Mr. Z and his team, and Mr. R is responsible for deciding the basic renting charges.

As a developer, we should build an application that is supposed to show all the charges for a property. When given a property id (101, 102, 103, 104, 105, 201, 202....), the type of property, the rent, the electricty charges and water charges need to be shown. The basic (not working) application is available in this link. 

## Requeirments from office of Mr. R
The rent should be calculated as below
* ShowRoom:  AreaInSquareFeet * 80
* Stall: AreaInSquareFeet * 200
* Theater: SeatingCapacity * 800 + 1000
* Multiplex: TotalSeatingCapacity * 700 + NumberOfScreens * 1000
* FoodCourt: NumberOfCounters * 10000 + SeatingCapacity * 300
* Eatery: SeatingCapacity * 400 + 10000
* AdvertisementBoard: AreaInSquareFeet * 3
* Parking: CarCapacity * 300 + MotorBikeCapacity * 50

## Requeirments from office of Mr. X
The water charges should be calculated as below
* ShowRoom:  AreaInSquareFeet * 4
* Stall: AreaInSquareFeet * 6
* Theater: SeatingCapacity * 2 + 100
* Multiplex: TotalSeatingCapacity * 2 + NumberOfScreens * 80
* FoodCourt: NumberOfCounters * 100 + SeatingCapacity + 10
* Eatery: SeatingCapacity * 10 + 1000
* AdvertisementBoard: 0
* Parking: CarCapacity * 1 + MotorBikeCapacity * .5

## Requeirments from office of Mr. Y
The electricity charges should be calculated as below
* ShowRoom:  AreaInSquareFeet * 3
* Stall: AreaInSquareFeet * 5
* Theater: SeatingCapacity * 5 + 5000
* Multiplex: TotalSeatingCapacity * 5 + NumberOfScreens * 5000
* FoodCourt: NumberOfCounters * 100 + SeatingCapacity * 6
* Eatery: SeatingCapacity * 6 + 1000
* AdvertisementBoard: AreaInSquareFeet * 10
* Parking: 1000

## Requeirments from office of Mr. Z
The cleaning charges should be calculated as below
* ShowRoom:  AreaInSquareFeet * 1
* Stall: AreaInSquareFeet * 1
* Theater: SeatingCapacity * 10
* Multiplex: TotalSeatingCapacity * 10
* FoodCourt: SeatingCapacity * 25
* Eatery: SeatingCapacity * 25
* AdvertisementBoard: 50
* Parking: 2000

