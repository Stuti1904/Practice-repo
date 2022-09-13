<template>
<div>
  <p>Parent component</p>
    <h4>Total likes are : {{ count }}</h4>
    <table class="table table-bordered" aria-label="table">
      <thead>
          <th>Post Name</th>
          <th>Post Decs</th>
          <th>Post Date</th>
          <th>Post Image</th>
      </thead>
      <tbody>
        <tr v-for="item in postlist" v-bind:key="item.postName">
          <td>{{ item.postName }}</td>
          <td>{{ item.postDesc }}</td>
          <td>{{ item.postDate }}</td>
          <td>{{ item.postImage }}</td>
        </tr>
      </tbody>
    </table>
    <PostList @getValue="display($event)"></PostList>
    </div>
</template>

<script>
import PostList from './components/PostList.vue'
export default {
  name: 'App',
  components: {
  PostList
  },
  data() {
    return {
      count: 0,
      postlist: [],
    };
  },
  methods: {
    display(message) {
      this.postlist = message;
      this.count++;
    },
  },
};
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
