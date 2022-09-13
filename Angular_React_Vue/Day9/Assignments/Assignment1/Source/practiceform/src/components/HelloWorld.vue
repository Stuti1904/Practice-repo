<template>
  <div class="hello">
    <div class="card m-3 p-3">
   <label class="card-header">Student</label>
   <label>First Name</label><input type="text" v-model="v$.student.firstname.$model">
   <div v-if="v$.student.firstname.$error" class="text-danger">field has an error.</div>
   <label>Middle Name</label><input type="text" v-model="v$.student.middlename.$model">
   <div v-if="v$.student.middlename.$error" class="text-danger">field has an error.</div>
   <label> Last </label><input type="text" v-model="v$.student.lastname.$model">
<div v-if="v$.student.lastname.$error" class="text-danger">field has an error.</div>
 <label>Date of birth</label><input type="date" v-model="v$.student.date.$model">
<div v-if="v$.student.date.$error" class="text-danger">field has an error.</div>
<label>Phone Number</label><input type="number" v-model="v$.student.phonenumber.$model">
<div v-if="v$.student.phonenumber.$error" class="text-danger">field has an error.</div>
 </div>
<div class="card m-3 p-3">
   <label class="card-header"> Father's Deatils</label>
   <label>Father's First Name</label><input type="text" v-model="father.firstname">
   <label>Father's Middle Name</label><input type="text" v-model="father.middlename">
   <label> Father's Last Name </label> <input type="text" v-model="father.lastname">
   <label> Father's Email </label><input type="text" v-model="father.email">
   <label> Father's Education Qualification </label><input type="text" v-model="father.education">
   <label> Father's Profession </label><input type="text" v-model="father.profession">
   <label> Father's phone number </label><input type="text" v-model="father.phonenumber">
</div>
<div  class="card m-3 p-3">
   <label class="card-header"> Mother's Deatils</label>
                <label>Mother Name</label>
                <label for="">FirstName</label>
                <input type="text" v-model="mother.firstname">
                <label for="">MiddleName</label>
                <input type="text" v-model="mother.middlename">
                <label for="">LastName</label>
                <input type="text" v-model="mother.lastname">
                <label for="">Email</label>
                <input type="email" v-model="mother.email">
               <label for="">EducationQualification</label>
                <input type="text" v-model="mother.education">
                <label for="">Proffesion</label>
                <input type="text" v-model="mother.profession">
                <label for="">PhoneNumber</label>
                <input type="number" v-model="mother.phonenumber">
              </div>
              <div class="card m-3 p-3">
            <label class="card-header">EmergancyContactlist</label>
            <label>Name</label>
            <input type="text" v-model="emergency.name">
            <label for="">Relation</label>
                <input type="text" v-model="emergency.relation">
                <label for="">Number</label>
                <input type="number" v-model="emergency.phone">
                  </div>
                  <div class="card m-3 p-3">
                    <label class="card-header">Refrence Details</label>
                <label for="">ReferenceDetails</label>
                <input type="text" v-model="refrence.details">
                <label for="">ReferenceThrough</label>
                <input type="text" v-model="  refrence.through">
                <label for="">AddressWithTelNo</label>
                <input type="text" v-model="refrence.address">
                </div>
                <div>
            <button type="buttom" v-on:click="store()" class="btn btn-dark text-light">Store</button>
                </div>
                <div>
            <p> STUDENT TABLE</p>
            <table class="table table-dark text-light border" aria-label="table">
              <thead class="text-dark">
                <th> First Name</th>
                <th> Middle Name</th>
                <th> Last Name</th>
                <th> Date of birth</th>
                <th> Phone Number</th>
              </thead>
              <tbody>
                <tr v-for="s in students" v-bind:key="s">
                  <td>{{s.stdfirst}}</td>
                   <td>{{s.stdmid}}</td>
                    <td>{{s.stdlast}}</td>
                     <td>{{s.stddate}}</td>
                      <td>{{s.stdph}}</td>
                  </tr>
                </tbody>
              </table>
                </div>
                <hr>
                <div>
            <p> FATHER TABLE</p>
            <table class="table table-dark text-light border" aria-label="table">
              <thead class="text-dark">
                <th> First Name</th>
                <th> Middle Name</th>
                <th> Last Name</th>
                 <th> Email</th>
                  <th> Education</th>
                   <th> Profession</th>
                    <th> Phone Number</th>
              </thead>
              <tbody>
                <tr v-for="f in fathers" v-bind:key="f">
                  <td>{{f.fatfirst}}</td>
                   <td>{{f.fatmid}}</td>
                    <td>{{f.fatlast}}</td>
                    <td>{{f.fatemail}}</td>
                    <td>{{f.fatedu}}</td>
                    <td>{{f.fatpro}}</td>
                    <td>{{f.fatpho}}</td>
                  </tr>
                </tbody>
              </table>
              </div>
              <hr>
              <div>
               <p> Mother TABLE</p>
            <table class="table table-dark text-light border" aria-label="table">
              <thead class="text-dark">
                <th> First Name</th>
                <th> Middle Name</th>
                <th> Last Name</th>
                 <th> Email</th>
                  <th> Education</th>
                   <th> Profession</th>
                    <th> Phone Number</th>
              </thead>
              <tbody>
                <tr v-for="m in mothers" v-bind:key="m">
                  <td>{{m.motfirst}}</td>
                   <td>{{m.motmid}}</td>
                    <td>{{m.motlast}}</td>
                    <td>{{m.motemail}}</td>
                    <td>{{m.motedu}}</td>
                    <td>{{m.motpro}}</td>
                    <td>{{m.motpho}}</td>
                  </tr>
                </tbody>
              </table>  
              </div>
              <hr>
              <div>
               <p> Emergency TABLE</p>
            <table class="table table-dark text-light border" aria-label="table">
              <thead class="text-dark">
                <th> Name</th>
                <th> Phone Number</th>
                <th> Relation</th>
              </thead>
              <tbody>
                <tr v-for="e in emergencies" v-bind:key="e">
                  <td>{{e.emename}}</td>
                   <td>{{e.emephone}}</td>
                    <td>{{e.emerelation}}</td>
                  </tr>
                </tbody>
              </table>  
              </div>
              <hr>
              <div>
              <p> Refrences TABLE</p>
            <table class="table table-dark text-light border" aria-label="table">
              <thead class="text-dark">
                <th> Through</th>
                <th> Details</th>
                <th> Addresss</th>
              </thead>
              <tbody>
                <tr v-for="r in refrences" v-bind:key="r">
                  <td>{{r.refthrough}}</td>
                   <td>{{r.refdetails}}</td>
                    <td>{{r.refaddress}}</td>
                  </tr>
                </tbody>
              </table>  
              </div>
              <hr>
  </div>
</template>

<script>
import useVuelidate from '@vuelidate/core';
import { required, minLength, maxLength, numeric } from '@vuelidate/validators'
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
  setup () {
    return { v$: useVuelidate() }
  },
  data() {
    return {
      student:{
        firstname: '',
        middlename: '',
        lastname:'',
        date: '',
        firstlang:'',
        phonenumber:'',
      },
      father:{
        firstname:'',
        middlename: '',
        lastname: '',
        emaill:'',
        education:'',
        profession:'',
        phonenumber: ''
      },
     mother:{
        firstname:'',
        middlename: '',
        lastname: '',
        emaill:'',
        education:'',
        profession:'',
        phonenumber: ''
      }, 
      emergency:{
        name:'',
        phone: '',
        relation: '',
      },
      refrence:{
        through:'',
        details: '',
        address: '',
      },
      students:[],
      fathers:[],
      mothers:[],
      emergencies:[],
      refrences:[]
    }
  },
  methods: {
    store(){
     const result = this.v$.$validate()
      if(!result) {
       
        return
      }
     var stdobj= {stdfirst:this.student.firstname, stdmid: this.student.middlename, stdlast: this.student.lastname, stddate: this.student.date, stdph: this.student.phonenumber} ;
     if(this.student.firstname==''|| this.student.middlename==''|| this.student.lastname==''||this.student.date==''|| this.student.phonenumber=='' ){
       alert("REQUIRED FIELDS");
       return 1;
     }
     this.students.push(stdobj);
     var fatobj= {fatfirst:this.father.firstname, fatmid: this.father.middlename, fatlast: this.father.lastname, fatemail: this.father.email, fatedu: this.father.education,
                  fatpro:this.father.profession, fatpho: this.father.phonenumber } ;
      this.fathers.push(fatobj);
      var motobj= {motfirst:this.mother.firstname, motmid: this.mother.middlename, motlast: this.mother.lastname, motemail: this.mother.email, motedu: this.mother.education,
                  motpro:this.mother.profession, motpho: this.mother.phonenumber } ;
      this.mothers.push(motobj);
       var emeobj= {emename:this.emergency.name, emephone: this.emergency.phone, emerelation: this.emergency.relation} ;
     this.emergencies.push(emeobj);
        var refobj= {refthrough:this.refrence.through, refdetails: this.refrence.details, refaddress: this.refrence.address} ;
     this.refrences.push(refobj);
    console.log( v$.student.phonenumber.$error);
     this.student.firstname='';
     this.student.middlename='';
     this.student.lastname='';
     this.student.date='';
     this.student.phonenumber='';
     this.father.firstname='';
     this.father.middlename='';
     this.father.lastname='';
     this.father.email='';
     this.father.education='';
     this.father.profession='';
     this.father.phonenumber='';
     this.mother.firstname='';
     this.mother.middlename='';
     this.mother.lastname='';
     this.father.emaill='';
     this.mother.education='';
     this.mother.profession='';
     this.mother.phonenumber='';
     this.emergency.name='';
     this.emergency.phonenumber='';
     this.emergency.relation='';
     this.refrence.through='';
     this.refrence.details='';
     this.refrence.address='';
    }
  },
  validations(){
    return{
      student:{
        firstname: { required },
        middlename: { required },
        lastname:{ required },
         date:{ required },
         phonenumber:{ required, numeric, minLength:minLength(10), maxLength:maxLength(10)
 },
      }
    }
  }
  }
</script>
<style scoped>

</style>
