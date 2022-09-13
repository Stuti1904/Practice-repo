<template>
<div>
  <table aria-label="table">
    <thead>
      <th> Id </th>
      <th>Name</th>
    </thead>
    <tbody>
      <tr v-for="user in users" v-bind:key="user.id">
        <router-link
        to="{
              name: 'userSingleView',
              params: {
                id: user.id,
                name: user.name,
              },
            }">
            <td>{{user.id}}</td>
          </router-link>
          <td>{{user.name}}</td>
        </tr>
    </tbody>
    </table>
<div>
  <router-view></router-view>
</div>
</div>
</template>

<style>
</style>
<script>
export default {
  data() {
    return {
      users: [
        { id: 1, name: 'John' },
        { id: 2, name: 'Jane' },
        { id: 3, name: 'Jack' },
        { id: 4, name: 'Jill' },
      ],
    };
  },
};
</script>

