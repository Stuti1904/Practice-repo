var fs = require('fs')
var bikerent = require('./bikerent')
const readline = require("readline");
const read1 = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var tempvar = new bikerent.BikeRent()
read1.question("ENter Cunstomer Name: ", function(name) {
    read1.question("ENTER Mobile Number: ", function(phone_number) {
        read1.question("ENTER Bike Number: ", function(bike_number) {
            read1.question("For How many days you want to rent this Bike: ", function(days) {
                var arr1 = []
                tempvar.customer_name = name
                tempvar.phone_number = phone_number
                tempvar.bike_number = bike_number
                tempvar.days = days
                tempvar.payment = tempvar.computed
                arr1.push(tempvar)
                console.log(arr1);
                read1.close()
            })
        })
    })
})
