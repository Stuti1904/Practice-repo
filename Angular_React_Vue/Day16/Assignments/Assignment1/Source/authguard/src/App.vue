<template>
  <div class="container mx-auto mt-5">
    <div class="row">
      <div>
        <label class="col-1 mt-3">Username</label>
        <input
          type="text"
          v-model="user"
          placeholder="Enter Username"
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
        <button @click="login()" class="col-1 mt-3 btn btn-outline-dark">
          LogIn
        </button>
      </div>
      <div class="mt-3">
        <router-link to="/user" class="col-2 text-decoration-none"
          >User</router-link
        >
        <router-link to="/admin" class="col-2 ms-3 text-decoration-none"
          >Admin</router-link
        >
      </div>
    </div>
    <router-view class="text-success" />
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
      if (this.user == 'admin' && this.pass == 'admin') {
        localStorage.setItem('admin', this.user);
        alert("Logged in as a admin");
      } else if (this.user == 'user' && this.pass == 'user') {
        localStorage.setItem('user', this.user);
        alert("logged In as an user");
      }
    },
  },
};
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
</script>
