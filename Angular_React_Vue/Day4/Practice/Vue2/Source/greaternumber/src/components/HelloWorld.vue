<template>
  <div class="card m-5 p-5">
    <h1 class="card-header">Greater of two numbers</h1>
<label>Enter the first number</label>
<input type="number" v-model ="num1">
<label>Enter the second number</label>
<input type="number" v-model ="num2">
<p v-if="num1>num2">{{num1}}</p>
<p v-else>{{num2}}</p>
  </div>
</template>
<script>
export default {
  name: 'HelloWorld',
  data() {
    return {
      num1:'',
      num2:'',
      value:'true',
    }
  }
}
</script>
<style scoped>

</style>
