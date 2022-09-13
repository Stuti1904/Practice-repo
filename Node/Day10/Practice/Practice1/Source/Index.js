const express = require('express');

const mongoose = require('mongoose');

const connect = mongoose.connect('mongodb://localhost:27017/testdb');

const category = require('./Controller/category');

const categoryModel = require('./Models/Category');



const product = require('./Controller/product');

const productModel = require('./Models/Products');

var app = express();




app.use(express.json());



app.use("/category",category);

app.use("/products",product);




app.listen(3001,()=>{

    console.log("Server running at 3001.....")

})
