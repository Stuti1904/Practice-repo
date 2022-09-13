<template>
  <div>
    <h3>Fees</h3>
    <div v-for="item in fees" :key="item">
      <div v-if="item.id == $route.params.id">
        <p><strong> ID : </strong> {{ item.id }}</p>
        <p><strong> Name : </strong>{{ item.name }}</p>
        <p><strong> Address : </strong>{{ item.address }}</p>
        <p><strong> Fees Status : </strong>{{ item.fees }}</p>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: 'FeesView',
  data() {
    return {
      fees: [
        {
          id: 1,
          name: 'keyuri',
          address: 'porbandar',
          fees: 'paid',
        },
        {
          id: 2,
          name: 'krupa',
          address: 'baroda',
          fees: 'Feeship-card',
        },
        {
          id: 3,
          name: 'vinit',
          address: 'anand',
          fees: 'paid',
        },
        {
          id: 4,
          name: 'twinkle',
          address: 'balasinor',
          fees: 'unpaid',
        },
      ],
    };
  },
};
</script>
