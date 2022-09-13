var htt= require('http');
var fs= require('fs');
var url= "4000";
htt.createServer((req, res)=>{
    if(req.url='/'){
        fs.readFile('./info.json', (err, data)=>{
            console.log(JSON.parse(data));
        })
    }
    res.write("Hello world");
    res.end();
}).listen(url, ()=>{
    console.log(`server started at ${url}`);
})