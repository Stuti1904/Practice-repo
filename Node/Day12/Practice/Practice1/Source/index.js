const express = require('express');
const mongoose = require('mongoose');
const connect = mongoose.connect('mongodb://localhost:27017/validatedb');
const router = express.Router();
//Schema definitions
var categorySchema = mongoose.Schema({
    categoryName:String
})
var testerSchema = mongoose.Schema({
    testerName:'String'
})
var stringValidateSchema = mongoose.Schema({
    testString:{type:String, minLength:1, maxLength:[5,'{VALUE} received, max allowed 5'],uppercase:true}
})
// Model Creation
var categoryModel = mongoose.model('category',categorySchema);
var testerModel = mongoose.model('tester',testerSchema);
var stringTesterModel = mongoose.model('stringTester',stringValidateSchema);
// implementation
var tempCategory = new categoryModel({categoryName:"Food"}).categoryName;
console.log(tempCategory);
var tempTester = new testerModel({testerName:42}).testerName;
console.log(tempTester);
var stringTest = new stringTesterModel({testString:"St1".toUpperCase()});
// Handling error with .save() promise
stringTest.save().then(()=>{console.log("Successfully Saved")}).catch((err)=>{console.log(err.message)});
// validateSync Demo
const err = stringTest.validateSync();
if(err){
    console.log(err.message);
}else{
   console.log("DATA VALID");
}

const app = express();
