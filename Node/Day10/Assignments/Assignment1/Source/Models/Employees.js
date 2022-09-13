const mongoose= require('mongoose');
var employeeSchema=mongoose.Schema({
firstName: {type: String},
lastName: {type:String},
Assignments: [{
    AssignmentId: {type: Number},
    AssignmentCategory: {type: String},
    AssignmentName: {type: String},
    AssignmentStatus: {type: String}
}
]
})
const EmployeeModel=mongoose.model("employee",employeeSchema);
module.exports=EmployeeModel;