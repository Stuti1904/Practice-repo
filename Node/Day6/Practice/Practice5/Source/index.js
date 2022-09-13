var exp= require('express');
var fs= require('fs');
var port= 3001;
var api= exp();
api.use(exp.json());
api.get("/customers",(req,res)=>{
    fs.readFile("./customers.json", (err, data)=>{
        res.send(data);
        res.end();
    })
})
api.delete("/customer/:id", (req, res)=>{
data1=[];
fs.readFile('./customers.json', 'utf-8', (err, data)=>{
    data1= JSON.parse(data);
    const result= data1.find((data)=>{
        return data.id==parseInt(req.params.id);
    })
 data1.splice(req.params.id-1, 1);
 fs.writeFile('./customers.json', JSON.stringify(data1), (err)=>{
     console.log("DELETED");
 });
 res.send(data1);
     res.end();
})
})
api.listen(port, ()=>{
    console.log("server started");
})