var fs= require('fs');
var name=process.argv.slice(2);
fs.appendFile('person.txt', `Hello ${name[0]}`, function(err){
    if(err) throw err;
    console.log("saved");
    fs.readFile('person.txt', function(err,data){
        console.log(data.toString());
    })
});

