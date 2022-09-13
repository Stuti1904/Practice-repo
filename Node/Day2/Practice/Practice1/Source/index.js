var fs= require('fs');
fs.readFile('./demo.txt', function(err,data){
    console.log(data.toString());
})