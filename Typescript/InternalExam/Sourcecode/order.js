"use strict";
exports.__esModule = true;
exports.orders = exports.myorder = void 0;
exports.myorder = [];
var orders = /** @class */ (function () {
    function orders() {
    }
    orders.prototype.generateorder = function (obj) {
        exports.myorder.push(obj);
    };
    orders.prototype.showorderlist = function () {
        for (var i = 0; i < exports.myorder.length; i++) {
            console.log("".concat(i + 1, " Userid: ").concat(exports.myorder[i].userid, " Username: ").concat(exports.myorder[i].username, "  Orderid: ").concat(exports.myorder[i].orderid));
            console.log("                                                                    ");
        }
    };
    return orders;
}());
exports.orders = orders;
