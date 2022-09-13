<template>
  <div class="container m-auto mt-5 shadow-lg w-50 p-3">
    <h3 class="text-success text-center">Result</h3>
    <div v-for="item in res" :key="item">
      <div v-if="item.id == $route.params.id">
        <p><strong> ID : </strong> {{ item.id }}</p>
        <p><strong> Name : </strong>{{ item.name }}</p>
        <p><strong> Address : </strong>{{ item.address }}</p>
        <p><strong> Result : </strong>{{ item.result }}</p>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: 'ResultView',
  data() {
    return {
      res: [
        {
          id: 1,
          name: 'keyuri',
          address: 'porbandar',
          result: 'pass',
        },
        {
          id: 2,
          name: 'krupa',
          address: 'baroda',
          result: 'pass',
        },
        {
          id: 3,
          name: 'vinit',
          address: 'anand',
          result: '1-backlog',
        },
        {
          id: 4,
          name: 'twinkle',
          address: 'balasinor',
          result: 'fail',
        },
      ],
    };
  },
};
</script>
