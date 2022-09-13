var exp= require('express');
var fs= require('fs');
var port= 3001;
var api= exp();
api.use(express.json());
app.get("/api/customers",(req,res)=>{
  fs.readFile("./customers.json",(err,data)=>{
  res.send(data);
  res.end();
  })
  })
api.post('/customers', (req, res) => {
    let data1 = [];
    fs.readFile('./customers.json', 'utf-8', (err, data) => {
      data1 = JSON.parse(data);
      data1.push(req.body);
      fs.writeFile('./customers.json', JSON.stringify(data1), (err) => {
        console.log('File written');
      });
      res.send(data1);
      res.end();
    });
  });
  api.listen(port, ()=>{
    console.log("SERVER STARTED");
  })