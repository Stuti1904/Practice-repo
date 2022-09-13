const mongoose= require('mongoose');
var patientSchema= mongoose.Schema({
    firstname:{type: String, required:true, minlength:3, maxlength:250},
    lastname:{type: String, required:true, minlength:3, maxlength:250},
    disease:{type: String, required:true, minlength:5, maxlength:250},
    healthcareAssitant:[{
        assistantId: {type: Number, required:true},
        assistantName: {type: String, required:true, minlength:3, maxlength:250},
        department:{type: String, required:true, minlength:3, maxlength:250}
    }],
    medicine:[{
        name:{type: String, required:true, minlength:3, maxlength:250},
        morning:{type:Boolean, default:true},
        afternoon:{type:Boolean, default:true},
        night:{type:Boolean, default:true}
    }]
})
const PatientModel=mongoose.model("patient", patientSchema);
module.exports= PatientModel;