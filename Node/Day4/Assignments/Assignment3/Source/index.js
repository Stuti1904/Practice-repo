const http = require('http');

const fs = require('fs');

var url = "http://localhost:3000";

var url3 = new URL("/",url);

http.createServer((req,res)=>{
    if(req.url="/"){
        fs.readFile("./test.json",(err,data)=>{
            if(err){
                console.log(err);
                return;
            }
            let name = JSON.parse(data).name;
            let temp = name.split('');
            for(let i=0;i<temp.length;i++){
                if(temp[i]=="a"||temp[i]=="A"||temp[i]=="e"||temp[i]=="E"||temp[i]=="i"||temp[i]=="I"||temp[i]=="o"||temp[i]=="O"||temp[i]=="u"||temp[i]=="U"){
                    console.log(` The first vowel of ${name} is ${temp[i]}`);
                    break;
                }
            }
        })
        res.end();
    }
}).listen(3000, ()=> {console.log("Server started. listening on post 3000...")});


