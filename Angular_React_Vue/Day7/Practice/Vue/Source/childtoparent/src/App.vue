<template>
<div>
  <ProFile @getData="Display($event)"></ProFile>
  <h1>{{username}}</h1>
  </div>
</template>

<script>
import ProFile from './components/ProFile.vue'

export default {
  name: 'App',
  components: {
   ProFile
  },
   data() {
    return {
      username: '',
    };
  },
  methods: {
    Display(username) {
      this.username = username;
    },
  },
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
