<template lang="">
    <div class="container mt-5">
      <button v-on:click="generateArray()" class="bt btn-dark text-light">Find your even numbers</button>
<div v-for="item in list" :key="item" class="m-5">
    <p v-if ="item%2==0">{{item}}</p>
</div>  
    </div>
</template>
<script>
export default {
      name: "EvenNumbers",
    props:{
        msg: String
    },
    data(){
        return{
          list:[],
        }
},
methods: {
     generateArray()
  {
    for (let i = 0; i < 100; i++) {
      this.list[i] = i+1;
    }
  }
},
}
</script>
<style lang="">
    
</style>