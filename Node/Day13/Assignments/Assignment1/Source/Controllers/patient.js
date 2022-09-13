const express=require('express');
const mongoose=require('mongoose');
const PatientModel= require('../Models/Patients');
var app= express();
var router= express.Router();
router.get("/", (req,res)=>{
   PatientModel.find((err, data)=>{
       res.send(data);
       res.end();
   });
})
router.post("/", async(req,res)=>{
    var patientmodel= new PatientModel(req.body);
    var result= await patientmodel.save();
    console.log(result);
    res.end();
})
module.exports=router;