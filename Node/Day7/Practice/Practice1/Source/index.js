const express= require('express');
const app= express();
var fs= require('fs');
var port=3001;
app.use((req,res,next)=>{
    console.log(new Date());
    next();
})
app.get('/',(req,res)=>{
    fs.readFile('./demo.json', "utf-8", (err,data)=>{
        const data1= JSON.parse(data);
        res.send(`${JSON.stringify(data1)}`);
        res.end();
    })
})
app.use('/user',(req,res,next)=>{
    console.log(`Request TYPE ${req.method}`)
    next();
})
app.listen(port, ()=>{
    console.log("SERVER STARTED");
})