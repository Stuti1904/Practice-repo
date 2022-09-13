export{}
var  employees: {fname:string, employeeid:number,lname:string, address:any, salary:number}[]=[
 {fname:"Stuti", employeeid:234, lname:"Shahu", address:"42,Osaka,Japan",salary:30000},
{fname:"Yuta", employeeid:235, lname:"Nakamoto",address:"42,Osaka,Japan", salary:30000},
 {fname:"Shotaro", employeeid:236, lname:"Osaki",address:"42,Osaka,Japan",salary:30000 },
  {fname:"Hinata", employeeid:237, lname:"Hyuga",address:"42,Osaka,Japan", salary:30000 }
]
let tobefound=235;
let search = employees.filter((value)=>{
    return value.employeeid ==tobefound ; 
})
console.log(search);
for (var i of employees){
    let address1=i.address.split(",");
    var pf=i.salary*0.083;
    console.log(`ID:= ${i.employeeid}  Employee's Full Name:${i.fname} ${i.lname}`);
    console.log(`Address:Flat no. ${address1[0]} City:${address1[1]} State:${address1[2]}`);
    console.log(`Salary:${i.salary} PF:${pf}`);
    console.log(" ");
}
var emp1:{fname:string , employeeid:number,lname :string ,address:any , salary: number}[] = [
    { "fname":"Dennny","employeeid":7 ,"lname":"Adamsss" ,"address":"20,Dallas ,Texas,Us","salary":150000 }];
    employees=employees.concat(emp1);
    console.log(employees);
