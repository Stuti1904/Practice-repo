var exp= require('express');
var fs= require('fs');
const { json } = require('express');
var port= 300;
var api= exp();
api.get('/customers/:id', (req,res)=>{
    fs.readFile('./customers.json', 'utf-8', (err, data)=>{
        const customer= JSON.parse(data);
        const result= customer.find((data)=>{
            return data.id==parseInt(req.params.id);
        })
        res.send(`${JSON.stringify(result)}`);
    })
}).listen(port, ()=>{
    console.log("SERVER STARTED");
})