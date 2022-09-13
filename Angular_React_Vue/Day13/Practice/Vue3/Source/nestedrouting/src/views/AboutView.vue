<template>
  <div>
    <h1>User page</h1>
    <strong >Select a user</strong>
    <ul>
      <button>
        <router-link to="/about/1">User 1</router-link>
      </button>
      <button>
        <router-link to="/about/2">User 2</router-link>
      </button>
      <button>
        <router-link to="/about/3">User 3</router-link>
      </button>
    </ul>
    <router-view></router-view>
  </div>
</template>
<script>
export default {};
</script>
