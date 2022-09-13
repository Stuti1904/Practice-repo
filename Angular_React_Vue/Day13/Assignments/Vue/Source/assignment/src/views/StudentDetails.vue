<template>
  <div>
    <h3 >Student Details</h3>
    <table
      aria-describedby="">
      <thead>
        <tr>
          <th>ID</th>
          <th>Name</th>
          <th>Address</th>
          <th></th>
          <th></th>
        </tr>
      </thead>
      <tbody v-for="item in students" :key="item.id">
        <tr>
          <td>{{ item.id }}</td>
          <td>{{ item.name }}</td>
          <td>{{ item.address }}</td>
          <td>
            <button>
              <router-link :to="{ name: 'FeesView', params: { id: item.id } }"
                >Fees</router-link
              >
            </button>
          </td>
          <td>
            <button>
              <router-link :to="{ name: 'ResultView', params: { id: item.id } }"
                >Result</router-link
              >
            </button>
          </td>
        </tr>
      </tbody>
    </table>
    <div>
      <router-view></router-view>
    </div>
  </div>
</template>

<script>
export default {
  name: 'StudentDetails',
  data() {
    return {
      students: [
        {
          id: 1,
          name: 'keyuri',
          address: 'porbandar',
        },
        {
          id: 2,
          name: 'krupa',
          address: 'baroda',
        },
        {
          id: 3,
          name: 'vinit',
          address: 'anand',
        },
        {
          id: 4,
          name: 'twinkle',
          address: 'balasinor',
        },
      ],
    };
  },
};
</script>
