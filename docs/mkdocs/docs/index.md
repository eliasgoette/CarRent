*Software Architecture & Design*
# Car Rent 
## Use Cases
- UC01 Upload cars:
    - A user uploads a car. The car has a model that contains a brand and a category.
- UC02 Reserve cars:
    - A user reserves a car of a specified category and date (from/to). The reservation is for any car in that category.
- UC03 Pick up car:
    - A user picks a reserved car up. This converts the reservation into a rental contract and unlocks the car.
- UC04 Bring back car:
    - A user brings the car he rented back. This triggers the creation of a return form that includes damages and will be attached to the retal contract.