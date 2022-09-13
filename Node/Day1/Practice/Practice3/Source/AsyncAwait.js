const firsttask=()=>{
    return new Promise(resolve=>{
         setTimeout(()=> resolve("First task"),3000)
        })
}
const secondtask= async ()=>{
const second= await firsttask();
return second+ "second task";
}
secondtask().then(res=>{
    console.log(res);
});