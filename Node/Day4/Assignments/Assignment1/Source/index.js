const http = require('http');

const fs = require('fs');

var url = "http://localhost:3001";

var url1 = new URL('/',url);

http.createServer((req,res)=>
{
    
    if(req.url="/")
    {
        fs.readFile('./person.json',(err,data)=>{
            if(err)
            {
                console.log(err);
                return;
            }
            console.log(JSON.parse(data));
        })
    }
    res.end();
}).listen(3001,()=>{console.log("Server Started at port 3001...")})


