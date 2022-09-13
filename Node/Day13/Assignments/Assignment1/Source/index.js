const express= require('express');
const mongoose= require('mongoose');
const connect = mongoose.connect('mongodb://localhost:27017/assignmentdb');
const doctor= require('./Controllers/doctor');
const doctorModel= require('./Models/Doctors');
const patient= require('./Controllers/patient');
const patientModel= require('./Models/Patients');
var app=express();
app.use(express.json());
app.use("/doctors", doctor);
app.use("/patients", patient);
app.listen(3001, ()=>{
    console.log("SERVER STARTED");
})