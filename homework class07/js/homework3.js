let car = {
    name: "Seat",
    model: "Ibiza",
    color: "Black",
    year: 2007,
    fuel: "Petrol",
    fuelConsumption: 8,
    distance: function(){
        let km= prompt("Enter km to pass: ");
        let result = (this.fuelConsumption / 100) * km;
        console.log("You will need " + result + " liters of fuel");
    }
}
console.log(car.name + " " + car.model);
console.log(car.color + " " + car.year + " " + car.fuel);
console.log(car.fuelConsumption);
car.distance();