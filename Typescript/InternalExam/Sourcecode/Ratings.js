"use strict";
exports.__esModule = true;
exports.dorate = exports.myrating = void 0;
exports.myrating = [];
var dorate = /** @class */ (function () {
    function dorate() {
    }
    dorate.prototype.pushrates = function (obj) {
        exports.myrating.push(obj);
    };
    dorate.prototype.viewrating = function () {
        for (var i = 0; i < exports.myrating.length; i++) {
            console.log(" ".concat(i + 1, ". Username: ").concat(exports.myrating[i].username, " Orderid :").concat(exports.myrating[i].orderid, "  Rating: ").concat(exports.myrating[i].rating, "  Remarks: ").concat(exports.myrating[i].remark));
            console.log("                                                         ");
        }
    };
    dorate.prototype.sortbyrating = function () {
        for (var i = 0; i < exports.myrating.length; i++) {
            if (exports.myrating[i].rating <= 3) {
                console.log("".concat(i + 1, " Username: ").concat(exports.myrating[i].username, " Orderid :").concat(exports.myrating[i].orderid, "  Rating: ").concat(exports.myrating[i].rating, "  Remarks: ").concat(exports.myrating[i].remark));
                console.log("                                                         ");
            }
        }
    };
    dorate.prototype.fiverating = function () {
        for (var i = 0; i < exports.myrating.length; i++) {
            if (exports.myrating[i].rating == 5) {
                console.log("".concat(i + 1, " Username: ").concat(exports.myrating[i].username, " Orderid :").concat(exports.myrating[i].orderid, "  Rating: ").concat(exports.myrating[i].rating, "  Remarks: ").concat(exports.myrating[i].remark));
                console.log("                                                         ");
            }
        }
    };
    dorate.prototype.sortbyusername = function () {
        var temp;
        for (var i = 0; i < exports.myrating.length - 1; i++) {
            if (exports.myrating[i].username > exports.myrating[i + 1].username) {
                temp = exports.myrating[i + 1];
                exports.myrating[i + 1] = exports.myrating[i];
                exports.myrating[i] = temp;
            }
        }
        for (var i = 0; i < exports.myrating.length; i++) {
            console.log(" ".concat(i + 1, ". Username: ").concat(exports.myrating[i].username, " Orderid :").concat(exports.myrating[i].orderid, "  Rating: ").concat(exports.myrating[i].rating, "  Remarks: ").concat(exports.myrating[i].remark));
            console.log("                                                         ");
        }
    };
    dorate.prototype.decreasingrating = function () {
        var temp;
        for (var i = 0; i < exports.myrating.length - 1; i++) {
            if (exports.myrating[i].rating < exports.myrating[i + 1].rating) {
                temp = exports.myrating[i + 1];
                exports.myrating[i + 1] = exports.myrating[i];
                exports.myrating[i] = temp;
            }
        }
        for (var i = 0; i < exports.myrating.length; i++) {
            console.log(" ".concat(i + 1, ". Username: ").concat(exports.myrating[i].username, " Orderid :").concat(exports.myrating[i].orderid, "  Rating: ").concat(exports.myrating[i].rating, "  Remarks: ").concat(exports.myrating[i].remark));
            console.log("                                                         ");
        }
    };
    return dorate;
}());
exports.dorate = dorate;
