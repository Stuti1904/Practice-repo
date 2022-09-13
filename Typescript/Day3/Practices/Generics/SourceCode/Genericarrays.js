"use strict";
exports.__esModule = true;
var books = [
    { id: 1, name: "ACOTAR" },
    { id: 2, name: "ACOMAF" },
    { id: 3, name: "ACOWAR" },
    { id: 4, name: "ACOSF" }
];
var firstbook = findbook((books));
console.log(firstbook);
function findbook(inventory) {
    return inventory[0];
}
