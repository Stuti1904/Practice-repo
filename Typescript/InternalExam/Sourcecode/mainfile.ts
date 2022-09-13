import { User } from "./user";
import { username } from "./user";
import { order } from "./order";
import { myorder } from "./order";
import { orders } from "./order";
import { myrating } from "./Ratings";
import { dorate } from "./Ratings";
var order1= new orders();
order1.generateorder({"userid":1, "orderid": 13,"username": "stuti"});
order1.generateorder({"userid":2, "orderid": 14,"username": "yuta"});
order1.generateorder({"userid":3, "orderid": 15,"username": "shotaro"});
order1.showorderlist();
console.log("-------------------------------------------------");
var rating1= new dorate();
rating1.pushrates({
    rating: 4, 
    remark: "amazing",
    orderid: 13,
    userid: 1,
    username: "stuti"
});
rating1.pushrates({
    rating: 2.7, 
    remark: "ok",
    orderid: 14,
    userid: 2,
    username: "yuta"
});
rating1.pushrates({
    rating: 5, 
    remark: "amazing",
    orderid: 13,
    userid: 1,
    username: "stuti"
});
rating1.pushrates({
    rating: 2, 
    remark: "bad",
    orderid: 15,
    userid: 3,
    username: "shotaro"
});
rating1.viewrating();
console.log("------------------------------------------------");
rating1.sortbyrating();
console.log("----------------------------------------");
rating1.fiverating();
console.log("-------------------------------------------");
rating1.sortbyusername();
console.log("--------------------------------------------");
rating1.decreasingrating();
console.log("----------------------------------------------");