import React, { useState } from 'react'
const Employee=()=>{
    const [values, setvalue]=  useState({id: " ", empname: " ", address:" ", gender: " ", date: " ", hobby: " " })
   const[employees, setemployees]= useState([])
  const handlechange =e=> {
     const name= e.target.name;
     const value= e.target.value;
      setvalue((prevState) => {
       return {...prevState, [name]: value}
        
    });
  };
  const employeepush =(e) =>{
    e.preventDefault();
    setemployees([...employees, values]);
    console.log(employees);
  }
return(
    <div>
        <label>Employee Id</label><input type="text" name="id" value={values.id} onChange={handlechange}></input>
        <label>Employee Name</label><input type="text" name="empname" value={values.empname} onChange={handlechange}></input>
        <label>Employee Address</label><input type="text" name="address" value={values.address} onChange={handlechange}></input>
        <input type="radio" id="male" name="gender" value="male"  {...values.gender} onChange={handlechange}></input>
      <label htmlFor="male">Male</label>
    <input type="radio" id="female" name="gender"  value=" female"{...values.gender} onChange={handlechange}></input>
    <label htmlFor="female">Female</label>
    <input type="radio" id="other" name="gender"  value= "other"{...values.gender} onChange={handlechange}></input>
    <label htmlFor="other">Other</label>
    <label>Date of Joining</label><input type="text" name="date"value={values.date} onChange={handlechange}></input>
    <label>Hobbies</label><input type="text" name="hobby" value={values.hobby} onChange={handlechange}></input>
    <button type="button" onClick={employeepush}>Submit</button>
    <table>
        <th>Id</th>
        <th>Name</th>
        <th>Address</th>
        <th>Gender</th>
        <th>Date of Joining</th>
        <th>Hobbies</th>
        {employees.map((emp)=>(
        <tr>
          <td>{emp.id}</td>
          <td>{emp.empname}</td>
          <td>{emp.address}</td>
          <td>{emp.gender}</td>
          <td>{emp.date}</td>
          <td>{emp.hobby}</td>
        </tr>
         ))}
    </table>
         </div>
)}
export default Employee
