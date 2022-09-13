<template>
    <div class="card p-2 m-5">
    <h1 class="card-header">This is signup component</h1>
    <label class="p-2">Name</label>
<input type="text" v-model="Username">
<label class="p-2">Address</label>
<input type="text" v-model="Address">
<label class="p-2">Pan Number</label>
<input type="text" v-model="panNumber">
<button type="button" v-on:click="sign()" class="w-25 bg-primary text-white m-2">Submit</button>
<div class="card-footer">
<p>Your name is: {{Username}}</p>
<p>Your address is: {{Address}}</p>
<p>Your pan number is: {{panNumber}}</p>
<p>{{greeting}}</p>
</div>
    </div>
</template>
<script>
export default {
    name: "SignUp",
    props:{
        msg: String,
    },
    data() {
        return {
         Username:' ',
Address: ' ',
panNumber:' ',   
        }
    },
    methods: {
        sign(){
  var greeting="you are signed in"
}
    },
}
</script>
<style lang="">
    
</style>