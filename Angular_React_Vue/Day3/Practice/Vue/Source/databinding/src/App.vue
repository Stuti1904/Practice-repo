<template>
  <component-calc></component-calc>
</template>

<script>
import ComponentCalc from './components/ComponentCalc.vue'
export default {
  name: 'App',
  components: {
    ComponentCalc
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
