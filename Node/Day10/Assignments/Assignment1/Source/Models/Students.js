const mongoose= require('mongoose');
var studentSchema=mongoose.Schema({
    Name:{type: String,  trim:true, uppercase: true},
    Address:{type:String,  trim:true, uppercase: true},
    Fees:{
        Amount: {type:Number,  trim:true, uppercase: true},
        PaymentDate:{type: String,   trim:true, uppercase: true},
        Status:{type: Boolean,   trim:true, uppercase: true}
    },
    Result:{
        Hindi:{type:Number,   trim:true, uppercase: true},
        English:{type:Number,  trim:true, uppercase: true},
        Total:{type:Number,   trim:true, uppercase: true},
        Grade: {type:String,   trim:true, uppercase: true}
    }
})
const StudentModel=mongoose.model("student",studentSchema);
module.exports=StudentModel;