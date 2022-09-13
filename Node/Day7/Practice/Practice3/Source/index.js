const express= require('express');
const app= express();
var fs= require('fs');
var port= 3001;
app.use(express.json());
app.get('/users', (req,res)=>{
    fs.readFile('./helloo', "utf-8", (err, data)=>{
        console.log("HI");
    })
   next();
})
app.use((err, req, res, next)=>{
    console.log(err.stack);
    res.status(500).send('something broke');
})
app.listen(port, ()=>{
    console.log("server started");
})