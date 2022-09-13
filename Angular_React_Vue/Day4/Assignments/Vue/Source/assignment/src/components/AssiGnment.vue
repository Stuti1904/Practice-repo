<template lang="">
    <div class="m-5">
        <h1 className="bg-light my-5">Sign up form</h1>
    <form id="myForm" name="myForm" className="w-50">
      <div className="mt-3 text-start">
        <label className="form-label" >Enter Name: </label>
        <input
          className="form-control"
          type="text"
          id="Name"
          name="name"
          placeholder="Enter your name"
          v-model="employee.name"
        />
      </div>
      <div className="my-4  text-start">
        <label className="form-label" >Enter Address: </label>
        <input
          className="form-control"
          type="text"
          name="address"
          id="Address"
          v-model="employee.address"
          placeholder="Enter your address"
        />
      </div>
      <div className=" text-start">
        <label className="form-label" >Enter gender: </label>
        <select
          className="form-select"
          name="gender"
          v-model="employee.gender"
        >
          <option></option>
          <option value="male">Male</option>
          <option value="female">Female</option>
          <option value="Other">Other</option>
        </select>
      </div>
      <div className=" text-start my-4">
        <label className="form-label" 
          >Enter date of joining:
        </label>
        <input
          className="form-control"
          type="date"
          name="doj"
          id="doj"
          v-model="employee.doj"
        />
      </div>
      <div className=" text-start">
        <label className="form-label" >Enter Hobbies: </label>
        <input
          className="form-control"
          type="text"
          name="hobbies"
          id="hobbies"
          placeholder="Enter your hobbies with leaving space"
          v-model="employee.hobbies"
        />
      </div>
      <button
        className="btn btn-success my-4"
        type="submit"
        @click="(e) => storeData(e)"
      >
        Save Employee
      </button>
    </form>
    <button className="btn btn-warning" @click="employeeDataFilter()">Filter</button>

          <table className="table-success w-50 table table-striped" aria-label="table">
            <caption>tabel filter</caption>
       <thead>
         <tr>
           <th>EmployeeName</th>
           <th>Address</th>
           <th>Gender</th>
           <th>Doj</th>
           <th>hobbies</th>
         </tr>
       </thead>
       
       
        <tbody>
          <tr v-for="employee of filteredArray" :key="employee.name">
            <td>{{employee.name}}</td>
            <td>{{employee.address}}</td>
            <td>{{employee.gender}}</td>
            <td>{{employee.doj}}</td>
            <td>{{employee.hobbies}}</td>
        </tr>
          </tbody>
      </table>
    <br><br>
      <table className="table-success w-50 table table-striped" aria-label="table">
       <thead>
         <tr>
           <th>EmployeeName</th>
           <th>Address</th>
           <th>Gender</th>
           <th>Doj</th>
           <th>hobbies</th>
         </tr>
       </thead>
       
       
        <tbody>
          <tr v-for="employee of employees" :key="employee.name">
            <td>{{employee.name}}</td>
            <td>{{employee.address}}</td>
            <td>{{employee.gender}}</td>
            <td>{{employee.doj}}</td>
            <td>{{employee.hobbies}}</td>
        </tr>
          </tbody>
      </table> 
    </div>
</template>
<script>
export default {
    name: "AssiGnment",
    props:{
        msg: String
    },
    data() {
        return {
            employees: [],
       employee: {
          // id: "",
          name: "",
          address: "",
          gender: "",
          doj: "",
          hobbies: "",
        },
        filteredArray:[]
        }
    },
    methods: {
    storeData(e){
      e.preventDefault();
    this.employees =[...this.employees,this.employee];
    this.employee={name:'',address:'',gender:'',doj:'',hobby:''};
  this.employees.sort((a, b) => a.name.localeCompare(b.name))
    },
    employeeDataFilter(){
     this.filteredArray= this.employees.filter((value)=>{
        return new Date(value.doj).getMonth()=== new Date().getMonth()
      })
       return this.filteredArray
    }

  }
}
</script>
<style lang="">
    
</style>