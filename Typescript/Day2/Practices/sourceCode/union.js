// function printId(id1 : number | string) {
//     if(typeof id1=='string'){
//         console.log(id1.toUpperCase())
//     }
//     else{
//         console.log("Your ID is: " + id1);
//   }}
//   printId(101);
//   printId("hi");
function welcomePeopl(x) {
    if (Array.isArray(x)) {
        console.log("Hello, " + x.join(" and "));
        // } else {
        //   console.log("Welcome lone traveler " + x);
        // }
    }
    if (typeof (x) == 'string') {
        console.log("hello");
    }
}
welcomePeopl("hello");
