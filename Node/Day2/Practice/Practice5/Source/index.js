var fs= require('fs');
fs.readFile('adress.txt',function(err,data){
    console.log(data.toString());
    var add= data.toString();
    var l= add.length;
    var vowel=0;
    var number=0;
    var special=0;
    var consonants=0;
   for(var i=0; i<l; i++){
       if(add[i]=='a'|| add[i]=='e' || add[i]=='i'|| add[i]=='o'|| add[i]=='u'){
        vowel++;
       }
       else if(add[i]==0 || add[i]>0){
        number++;
       }
       else if(add[i]==" " || add[i]==","){
           special++;
       }
       else{
           consonants++;
       }
   }
   console.log(consonants);
})