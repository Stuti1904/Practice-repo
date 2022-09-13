<template lang="">
    <div>
       <h3>Product List Component</h3>
    <table aria-label="table">
      <thead>
          <th>Post Name</th>
          <th>Post Decs</th>
          <th>Post Date</th>
          <th>Post Image</th>
      </thead>
      <tbody>
        <tr v-for="item in post" v-bind:key="item.postName">
          <td>{{ item.postName }}</td>
          <td>{{ item.postDesc }}</td>
          <td>{{ item.postDate }}</td>
          <td>{{ item.postImage }}</td>
          <td><button @click="likes(item.postName)">Like</button></td>
        </tr>
      </tbody>
    </table> 
    </div>
</template>
<script>
export default {
    name: "PostList",
data() {
    return {
      postName: '',
      postDesc: '',
      postDate: '',
      postImage: '',
      postlist1: [],
      post: [
        {
          postName: 'BTS',
          postDesc: 'FAV BTS PHOTO',
          postDate: '10-04-2022',
          postImage:
            '',
        },
        {
          postName: '2',
          postDesc: 'Second',
          postDate: '11-04-2022',
          postImage:
            '',
        },
        {
          postName: '3',
          postDesc: 'Third',
          postDate: '12-04-2022',
          postImage:
            '',
        },
      ],
    };
  },
  methods: {
    likes(obj) {
      this.post.forEach((element) => {
        if (obj === element.postName) {
          this.postlist1.push(element);
        }
      });
      this.$emit('getValue', this.postlist1);
    },
  },
};
</script>
<style lang="">
    
</style>