const mongoose=require('mongoose');
const connect = mongoose.connect('mongodb://localhost:27017/thirdb');
const Joi= require('joi');
const genres= require('./Routes/genre');
const express=require('express');
const movies=require('./Routes/movie');
const app=express();
app.use(express.json());
app.use('/api/genres', genres);
app.use('/movies', movies);
const port= 3000;
app.listen(port, ()=>{
    console.log("SERVER IS RUNNING")
})