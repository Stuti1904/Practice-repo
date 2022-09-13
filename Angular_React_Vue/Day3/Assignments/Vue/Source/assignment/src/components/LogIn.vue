<template lang="">
    <div>
       <div class="card p-2 m-5">
    <h1 class="card-header">THIS IS LOGIN PART</h1>
    <label  class="p-2"> Enter Username:</label>
    <input type="text" v-model="name">
    <label  class="p-2"> Enter Password:</label>
    <input type="text" v-model="passWord">
    <button type="button" v-on:click="check()" class="w-25 bg-primary text-white m-2">Submit</button>
    <h3 class="card-footer"> You are {{answer}}</h3>
</div> 
    </div>
</template>
<script>
export default {
    name: "LogIn",
    prop:{
        msg:String
    },
    data() {
        return {
            name:'',
passWord:'',
answer:'',
        }
    },
    check(){
  if(this.name =="admin" && this.passWord =="admin"){
    this.answer="Logged In";
    console.log(this.answer);
  }
  else{
    this.answer="Not logged in"
    console.log(this.answer);
  }
}
}
</script>
<style lang="">
    
</style>