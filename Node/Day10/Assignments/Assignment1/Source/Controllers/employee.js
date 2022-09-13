var express= require('express');
const mongoose= require('mongoose');
const EmployeeModel= require('../Models/Employees');
var router= express.Router();
router.get("/", (req, res)=>{
    EmployeeModel.find((err, data)=>{
        res.send(data);
        res.end();
    });
})
router.put("/", (req,res)=>{
    EmployeeModel.updateOne({_id: req.body._id}, {firstName: req.body.firstName}, {lastName:req.body.lastName},{Assignments:req.body.Assignments});
    res.send("STUDENT DATA UPDATED");
    res.end();
})
router.get("/assignments/:id", (req,res)=>{
    EmployeeModel.findById(req.params.id, (err,data)=>{
        res.send(data.Assignments);
        res.end();
    })
})
module.exports= router;