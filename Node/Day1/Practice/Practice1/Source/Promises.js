const done=true;
const isItDoneYet= new Promise((resolve, reject)=>{
if(done){
    const sentence="Here is what I did";
    resolve(sentence);
}
else{
    const sentence="The work is pending";
    reject(sentence);
}
})
const checkIfDone =()=>{
    isItDoneYet
    .then(ok=>{
        console.log(ok);
    })
    .catch(error=>{
        console.log(error);
    })
}
checkIfDone();