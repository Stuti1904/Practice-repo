
const http = require('http');
var url = "http://localhost:3000";

var url1 = new URL("/product?param1=5&param2=10",url);
let param1 = parseInt(url1.searchParams.get("param1"));
let param2 = parseInt(url1.searchParams.get("param2"));
let sum=[0];
http.createServer((req,res)=>{
    if(req.url=="/product?param1=5&param2=10")
    {
       sum= param1+param2;
    }
    res.write(`the sum is ${sum}`);
    res.end();
}).listen(3000,()=> {console.log("Server started. listening on post 3000...")})

