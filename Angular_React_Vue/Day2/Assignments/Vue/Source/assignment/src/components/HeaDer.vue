<template lang="">
        <div id="header">
    <nav>
        <ul>
            <li><a href="#home">Home</a></li>
            <li><a href="#about">About</a></li>
        </ul>
    </nav>
</div>
</template>
<script>
export default {
    name: "HeaDer"
}
</script>
<style scoped>
    nav{
    background-color: black;
    color:white;
    position: sticky;
    margin-top:0px;
    width: 100%;
}
a{
    text-decoration: none;
    color:white;
    margin:5px;
}
ul{
    display: flex;
    padding: 10px;
    list-style: none;
}
</style>