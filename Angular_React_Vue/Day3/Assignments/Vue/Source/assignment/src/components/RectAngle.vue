<template lang="">
    <div class="card p-2 m-5">
        <h1 class="card-header">This is rectangle component</h1>
        <label class="p-2">Lenght of the rectangle</label>
<input type="number" v-model="length">
<label class="p-2">Breadth of the rectangle</label>
<input type="number" v-model="breadth">
<button type="button" v-on:click="findArea()" class="w-25 bg-primary text-white m-2">Area</button>
<p class="card-footer">The area of rectangle is {{area}}</p>
    </div>
</template>
<script>
export default {
    name: "RectAngle",
    props:{
        msg: String
    },
    data(){
        return{
            length:0,
breadth:0,
area:0
        }
},
methods: {
    findArea(){
  this.area= this.length*this.breadth;
}
},
}

</script>
<style lang="">
    
</style>