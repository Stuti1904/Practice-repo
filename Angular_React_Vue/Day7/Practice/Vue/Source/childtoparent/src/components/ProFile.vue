<template lang="">
    <div>
      <label>Name</label>
<input type="text" v-model="myname">
<button type="button" @click="display()">Display</button>  
    </div>
</template>
<script>
export default {
    name: "ProFile",
    props:{
        message: String
    },
    data() {
        return {
            myname:'',
        }
    },
    methods: {
        display(){
             this.$emit('getData', this.myname);
        }
    },
}
</script>
<style lang="">
    
</style>