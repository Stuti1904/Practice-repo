const Genre= require('../Models/Genres');
const express= require('express');
const router= express.Router();
const mongoose= require('mongoose');
const validateGenre = require('../Models/Genres');
const app= express();
app.use(express.json());
router.get('/', async(req,res)=>{
    const genres= await Genre.find()
    res.send(genres);
    res.end();
});

router.post('/', (req,res)=>{
    const{error}= validateGenre(req.body);
    if(error) return res.statusMessage(400).send(error.details[0].message);
    let genre = new Genre({
        name: req.body.name
    });
     genre.save();
    res.send(genre);
    res.end();
})
module.exports= router

