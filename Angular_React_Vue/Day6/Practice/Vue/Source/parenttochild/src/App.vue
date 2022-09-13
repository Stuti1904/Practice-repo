<template>
<div>
  <DisPlay :item="item">
  </DisPlay>
  <input type="text" v-model="item">
  </div>
</template>

<script>
import DisPlay from './components/DisPlay.vue'

export default {
  name: 'App',
  data() {
    return {
     item: '',
    }
  },
  components: {
   DisPlay
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
