const Movie= require('../Models/Movies');
const Genre= require('../Models/Genres');
const mongoose= require('mongoose');
const express= require('express');
const validateMovie = require('../Models/Movies');
const router= express.Router();
router.get('/', async(req,res)=>{
    const movies= await Movie.Movie.find();
    res.send(movies);
    res.end();
})
router.post('/', async(req,res)=>{
    const{error}= validateMovie(req.body);
    if(error) return res.status(400).send(error.details[0].message);
    const genre= await Genre.findById(req.body.genreId);
    if(!genre) return res.status(400).send('Invalid Genre');
    let movie= new Movie({
        title:req.body.title,
        genre:{
            _id: genre._id,
            name: genre.name
        },
        numberInStock: req.body.numberInStock,
        dailyRentalRate: req.body.dailyRentalRate
    });
    movie= await movie.save();
})
module.exports= router