<template>
  <div>
    <h1 class="bg-dark text-center text-warning rounded m-2">Day-8 Module-9</h1>
  <hr />
  <div class="container">
    <label class="control-label col-sm-2" for="">Id:</label>
    <div class="col-lg-10">
      <input
        type="text"
        class="col-lg-12"
        v-model="Id"
        required
        placeholder="Enter Your Id"
      />
    </div>
    <label class="control-label col-sm-2" for="">Name:</label>
    <div class="col-lg-10">
      <input
        type="text"
        class="col-lg-12"
        v-model="Name"
        required
        placeholder="Enter Your Name"
      />
    </div>
    <label class="control-label col-sm-2" for="">Address:</label>
    <div class="col-lg-10">
      <input
        type="text"
        class="col-lg-12"
        v-model="Address"
        required
        placeholder="Enter Your Address"
      />
    </div>
    <button
      class="rounded btn-success text-white mt-3"
      type="button"
      v-on:click="Submit()"
    >
      Submit
    </button>
        <table aria-label="table">
    <thead>
    <th>Id</th>
    <th>Name</th>
    <th>Address</th>
    </thead>
    <tbody>
    <tr v-for="p in  people" v-bind:key="p">
    <td>{{p.pid}}</td>
    <td>{{p.pname}}</td>
    <td>{{p.paddress}}</td>
    </tr>
    </tbody>
    </table>
  </div>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
   data() {
    return {
      Id: '',
      Name: '',
      Address: '',
      people: [],
    };
  },
  methods: {
    Submit() {
      if(this.Id==''|| this.Name==''|| this.Address==''){
        alert("REQUIRED FIELD/FIELDS");
      }

      var pobj = { pid: this.Id, pname: this.Name, paddress: this.Address };

      this.people.push(pobj);

      console.log(this.people);
    },
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
@import url('https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css');
</style>
