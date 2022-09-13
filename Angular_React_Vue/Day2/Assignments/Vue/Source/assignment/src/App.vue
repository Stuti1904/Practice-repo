<template>
<div>
  <HeaDer></HeaDer>
  <SectionHome></SectionHome>
  <SectionAbout></SectionAbout>
  <FooTer></FooTer>
  </div>
</template>

<script>
import HeaDer from './components/HeaDer.vue'
import SectionHome from './components/SectionHome.vue'
import SectionAbout from './components/SectionAbout.vue'
import FooTer from './components/FooTer.vue'
export default {
  name: 'App',
  components: {
   HeaDer,
   SectionHome,
   SectionAbout,
   FooTer
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
