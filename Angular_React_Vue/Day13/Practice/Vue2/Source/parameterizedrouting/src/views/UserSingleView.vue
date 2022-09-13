<template>
  <div class="container m-auto mt-5">
    <h3>{{ $route.params.name }}'s id is: {{ $route.params.id }}</h3>
  </div>
</template>

<script>
export default {
  props: ['id', 'name'],
};
</script>
