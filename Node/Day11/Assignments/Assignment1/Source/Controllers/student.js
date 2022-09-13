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
router.post("/", (req, res) => {
    var studentModel = new StudentModel(req.body);
    studentModel.save();
    res.send("DATA POSTED");
    res.end();
})
router.delete("/",(req,res)=>{

    var data = StudentModel.find();

    data.deleteOne({_id: req.body._id}).then(()=>{console.log("Student deleted successfully")});

    res.send("Student Deleted");

    res.end();

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