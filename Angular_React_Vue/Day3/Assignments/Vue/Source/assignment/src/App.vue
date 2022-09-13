<template>
<div class="container">
  <div class="row">
    <div class="col">
       <RectAngle></RectAngle>
    </div>
    <div class="col">
   <LogIn></LogIn> -->
</div>
<div class="col">
    <SignUp></SignUp>
</div>
  </div>
</div>
</template>

<script>
import LogIn from './components/LogIn.vue'
import RectAngle from './components/RectAngle.vue'
import SignUp from './components/SignUp.vue'
export default {
  name: 'App',
  components: {
    RectAngle,
    LogIn,
    SignUp
  }
}
</script>
<style>
@import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
</style>
