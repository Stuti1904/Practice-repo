<template>
  <div class="hello">
    <input type="text" v-model="v$.name.$model">
    <div v-if="v$.name.$error">Name field has an error</div>
    <button @click="submit()">submit</button>
  </div>
</template>

<script>
import useVuelidate from '@vuelidate/core'
import { required } from '@vuelidate/validators'
export default {
  name: 'App',
  setup: () => ({ v$: useVuelidate() }),
  data: () => ({ name: '' }),
  validations () {
    return {
      name: { required }
    }
  },
  methods: {
    setName ($event) {
      
      this.name = $event.target.value.toUpperCase()
      
    },
     submit () {
      const result =  this.v$.$validate()
      if (!result) {
       
        return
      }
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
