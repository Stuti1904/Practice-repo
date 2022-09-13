<template>
  <div class="container mx-auto mt-5">
    <div class="row">
      <div>
        <label class="col-1 mt-3">Username</label>
        <input
          type="text"
          v-model="user"
          placeholder="Enter Uesrname "
          class="col-3 mt-3"
        />
      </div>
      <div>
        <label class="col-1 mt-3">Password</label>
        <input
          type="password"
          v-model="pass"
          placeholder="Enter Password"
          class="col-3 mt-3"
        />
      </div>
      <div>
        <button @click="login()" class="col-1 mt-3 btn btn-outline-success">
          LogIn
        </button>
      </div>
    </div>
    <nav class="d-flex mt-5">
      <router-link to="/" class="mx-3 text-decoration-none text-2xl"
        >Home</router-link
      >
      |
      <router-link to="/about" class="mx-3 text-decoration-none text-2xl"
        >About</router-link
      >
      |
      <router-link to="/protected" class="mx-3 text-decoration-none text-2xl"
        >Protected</router-link
      >
    </nav>
    <router-view class="mt-5 text-success" />
  </div>
</template>
<script>
export default {
  data() {
    return {
      user: '',
      pass: '',
    };
  },
  methods: {
    login() {
      if (this.user == 'user' && this.pass == 'user') {
        localStorage.setItem('user', this.user);
        alert(localStorage.getItem(this.user) + 'Logged In');
      }
    },
  },
};
</script>
<style>
@import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
</style>
