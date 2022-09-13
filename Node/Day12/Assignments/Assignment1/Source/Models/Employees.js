const mongoose= require('mongoose');
var employeeSchema=mongoose.Schema({
firstName: {type: String, required:true, trim:true, uppercase: true},
lastName: {type:String, required:true, trim:true, uppercase: true},
Assignments: [{
    AssignmentId: {type: Number, required:true, trim:true, uppercase: true},
    AssignmentCategory: {type: String, required:true, trim:true, uppercase: true},
    AssignmentName: {type: String, required:true, trim:true, uppercase: true},
    AssignmentStatus: {type: String, required:true, trim:true, uppercase: true}
}
]
})
const EmployeeModel=mongoose.model("employee",employeeSchema);
module.exports=EmployeeModel;