const mongoose= require('mongoose');
var doctorSchema= mongoose.Schema({
    name:{type: String, required:true, minlength:3, maxlength:250},
    speciality:{type: String, required:true, minlength:3, maxlength:250},
    qualification:{type: String, required:true, minlength:3, maxlength:250},
    patients:[{
        patientId:{
        type:mongoose.Schema.Types.ObjectId,
        ref:"patient"}}]
    })
const DoctorModel=mongoose.model("doctor", doctorSchema);
module.exports=DoctorModel;