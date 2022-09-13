const express=require('express');
const mongoose=require('mongoose');
const DoctorModel= require('../Models/Doctors');
var app= express();
var router= express.Router();
router.get("/", async (req,res)=>{
   var data= await DoctorModel.find().populate("patients.patientId", "firstname lastname disease medicine ");
   res.send(data);
   res.end();
})
router.post("/", async(req,res)=>{
    var doctormodel= new DoctorModel(req.body);
    var result= await doctormodel.save();
    console.log(result);
    res.end();
})
router.delete("/", (req, res)=>{
    var data=DoctorModel.find();
    data.deleteOne({_id:req.body._id}).then(()=>{
        console.log("DATA DELETED");
    })
    res.send("DATA DELETED");
    res.end();
})
router.get("/patients/:id", async(req,res)=>{
    var patient= await DoctorModel.find({_id:req.params.id}).populate("patients.patientId", "firstname");
    res.send(patient);
    res.end();
})
router.put("/update",(req,res)=>{

    doctorModel.updateOne({_id:req.body._id},req.body,()=>{console.log("Doctor Data updated.")});

    res.send("Doctor data updated");

    res.end();

})
router.put("/update/addPatient",async (req,res)=>{

    let tempDoc = await doctorModel.findById(req.body._id);

    tempDoc.patients.push({"patientId":req.body.patientId});

    tempDoc.save();

    res.send("Patient Added");

    res.end();

})
module.exports=router;
