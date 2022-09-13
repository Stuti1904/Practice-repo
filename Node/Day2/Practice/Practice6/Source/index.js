var fs= require('fs');
const folder= "./Tester";
fs.mkdir(folder, function(errr){
    if(errr){
        console.log(errr);
    }
    else{
        console.log("done");
    }
});
var extra= require('fs-extra');
extra.moveSync('person.txt', './Tester/person.txt', function(err){
    if(err){
        console.log(err);
    }
    else{
        console.log("moved");
    }
})
