<template>
  <div>
    <table class="table">
      <caption hidden>
        TABLE
      </caption>
      <thead>
        <th scope="header">ID</th>
        <th scope="header">Name</th>
        <th scope="header">Email</th>
        <th scope="header">Gender</th>
        <th scope="header">Status</th>
      </thead>
      <tbody>
        <tr v-for="user in items" :key="user.key">
          <td>{{ user.id }}</td>
          <td>{{ user.name }}</td>
          <td>{{ user.email }}</td>
          <td>{{ user.gender }}</td>
          <td>{{ user.status }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios';
export default {
  name: 'App',
  components: {},
  data() {
    return {
      items: [],
      token: '16a95a5b7206ecf08468f8beabf90c5f8a29515ef2ecf935a13536c12ee3e3c6',
    };
  },
  async created() {
    try {
      const res = await axios.get(`https://gorest.co.in/public/v2/users`, {
        headers: {
          'Content-Type': 'application/json',
          Authorization: `Bearer ${this.token}`,
        },
      });
      this.items = res.data;
      console.log(this.items);
    } catch (error) {
      console.log(error);
    }
  },
};
</script>

<style>
@import url('https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css');
</style>
