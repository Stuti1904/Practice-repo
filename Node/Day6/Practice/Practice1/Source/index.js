var exp= require('express');
var fs= require('fs');
var api = exp();
var port = 3001;
api.get('/customers', (req, res)=>{
    fs.readFile('./customers.json', 'utf-8',(err, data)=>{
        const customer= JSON.parse(data);
        res.send(customer);
    });
}).listen(port, ()=>{
    console.log("SERVER STARTED AT 3001")
})