<template>
  <div>
    <h2>User ID {{ $route.params.id }}</h2>
  </div>
</template>

<script>
export default {
  props: ['id'],
};
</script>
