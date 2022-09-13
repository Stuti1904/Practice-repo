// const mongoose= require("mongoose");
// const categorySchema= new mongoose.Schema({
//     CategoryName: {type: String},
// });
// const CategoryModel= mongoose.model("category", categorySchema);
// module.exports= CategoryModel;
const mongoose = require('mongoose');

var categorySchema = mongoose.Schema({
    categoryName: {type:String}
});

const categoryModel = mongoose.model("category",categorySchema);
module.exports = categoryModel;