<template lang="">
    <div>
        <label> First number</label>
<input type="number" v-model="first">
<label> Second Number</label>
<input type="number"  v-model="second">
<button type="button" v-on:click="addnumber()">ADD</button>
<button type="button" v-on:click="subtractnumber()">SUBTRACT</button>
<button type="button" v-on:click="multiplynumber()">MULTIPLY</button>
<button type="button" v-on:click="dividenumber()">DIVIDE</button>
<h3>The value of sum is {{sum}}</h3>
<h3>The value of difference is {{difference}}</h3>
<h3>The value of product is {{product}}</h3>
<h3>The quotient is {{quotient}}</h3>


    </div>
</template>
<script>
export default {
    name: "ComponentCalc",
    props:{
      msg:String
    },
    data() {
      return {
        first: 0,
second:0,
sum:0,
difference:0,
product:0,
quotient:0
      }
    },
    methods:{
addnumber(){
  this.sum= this.first+this.second;
  console.log(this.sum);
},
subtractnumber(){
  this.difference= this.first-this.second;
  console.log(this.difference);
},
multiplynumber(){
  this.product= this.first*this.second;
  console.log(this.product);
},
dividenumber(){
  if(this.second!=0){
  this.quotient= this.first/this.second;
  console.log(this.quotient);
}
else{
  console.log("DO NOT ENTER THE SECOND NUMBER AS ZERO")
}
}
    }
}
</script>
<style scoped>
    
</style>