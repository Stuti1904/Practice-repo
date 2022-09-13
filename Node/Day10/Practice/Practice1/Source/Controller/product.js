var express= require('express');
const mongoose= require('mongoose');
const ProductModel= require('../Models/Products');
var router= express.Router();
 router.get('/', async(req,res)=>{
     var data= await ProductModel.find().populate("categoryID", "categoryName");
     res.send(data);
     res.end();
 })
 router.post('/', async(req,res)=>{
     var productModel= new ProductModel(req.body);
     var result= await productModel.save();
     res.end();
 })
 module.exports= router;