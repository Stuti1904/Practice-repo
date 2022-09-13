const mongoose= require('mongoose');
var employeeSchema=mongoose.Schema({
firstName: {type: String, required:true},
lastName: {type:String, required:true},
Assignments: [{
    AssignmentId: {type: Number, required:true},
    AssignmentCategory: {type: String, required:true},
    AssignmentName: {type: String, required:true},
    AssignmentStatus: {type: String, required:true}
}
]
})
const EmployeeModel=mongoose.model("employee",employeeSchema);
module.exports=EmployeeModel;