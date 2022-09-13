var fs= require('fs');
fs.appendFile('person.txt', 'Hello India', function(err){
    if(err) throw err;
    console.log("saved");
    fs.readFile('person.txt', function(err,data){
        console.log(data.toString());
    })
});
