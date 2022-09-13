const mongoose= require('mongoose');
var studentSchema=mongoose.Schema({
    Name:{type: String, required: true, trim:true, uppercase: true},
    Address:{type:String, required: true, trim:true, uppercase: true},
    Fees:{
        Amount: {type:Number, required: true, trim:true, uppercase: true},
        PaymentDate:{type: String,  required: true, trim:true, uppercase: true},
        Status:{type: Boolean,  required: true, trim:true, uppercase: true}
    },
    Result:{
        Hindi:{type:Number,  required: true, trim:true, uppercase: true},
        English:{type:Number, required: true, trim:true, uppercase: true},
        Total:{type:Number,  required: true, trim:true, uppercase: true},
        Grade: {type:String,  required: true, trim:true, uppercase: true}
    }
})
const StudentModel=mongoose.model("student",studentSchema);
module.exports=StudentModel;