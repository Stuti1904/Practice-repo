var express = require('express');
const mongoose = require('mongoose');
const StudentModel = require('../Models/Students');
var router = express.Router();
router.get("/", (req, res) => {
    StudentModel.find((err, data) => {
        res.send(data);
        res.end();
    });
})
router.put("/",(req,res)=>{

    StudentModel.updateOne({_id:req.body._id},{Name:req.body.Name, Address:req.body.Address,Fees:req.body.Fees,Result:req.body.Result}).then(()=>{console.log("Student Updated.")});

    res.send("Student Data updated.")

    res.end();

})
router.get("/fees/:id", (req,res)=>{
    StudentModel.findById(req.params.id, (err,data)=>{
        res.send(data.Fees);
        res.end();
    })
})
router.get("/result/:id", (req,res)=>{
    StudentModel.findById(req.params.id, (err,data)=>{
        res.send(data.Result);
        res.end();
    })
})
module.exports = router;