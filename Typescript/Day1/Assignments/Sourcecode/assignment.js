"use strict";
exports.__esModule = true;
var employees = [
    { fname: "Stuti", employeeid: 234, lname: "Shahu", address: "42,Osaka,Japan", salary: 30000 },
    { fname: "Yuta", employeeid: 235, lname: "Nakamoto", address: "42,Osaka,Japan", salary: 30000 },
    { fname: "Shotaro", employeeid: 236, lname: "Osaki", address: "42,Osaka,Japan", salary: 30000 },
    { fname: "Hinata", employeeid: 237, lname: "Hyuga", address: "42,Osaka,Japan", salary: 30000 }
];
var tobefound = 235;
var search = employees.filter(function (value) {
    return value.employeeid == tobefound;
});
console.log(search);
for (var _i = 0, employees_1 = employees; _i < employees_1.length; _i++) {
    var i = employees_1[_i];
    var address1 = i.address.split(",");
    var pf = i.salary * 0.083;
    console.log("ID:= ".concat(i.employeeid, "  Employee's Full Name:").concat(i.fname, " ").concat(i.lname));
    console.log("Address:Flat no. ".concat(address1[0], " City:").concat(address1[1], " State:").concat(address1[2]));
    console.log("Salary:".concat(i.salary, " PF:").concat(pf));
    console.log(" ");
}
var emp = [
    { "fname": "Dennny", "employeeid": 7, "lname": "Adamsss", "address": "20,Dallas ,Texas,Us", "salary": 150000 }
];
employees = employees.concat(emp);
console.log(employees);
