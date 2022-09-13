const port=3000;
const express= require('express');
var app= express();
const mongoose= require('mongoose');
const student= require('./Controllers/student');
const studentModel= require('./Models/Students');
const connect = mongoose.connect('mongodb://localhost:27017/firstdb');
const employeeModel=require('./Models/Employees');
const employee= require('./Controllers/employee');
app.use(express.json());
app.use("/student",student);
app.use("/employee", employee);
app.listen(port, ()=>{
    console.log("app is started");
})