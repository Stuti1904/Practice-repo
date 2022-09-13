export{}
 type Book={id:number, name:string};
let books: Array<Book>=[
    {id: 1, name:"ACOTAR"},
    {id: 2, name:"ACOMAF"},
    {id: 3, name:"ACOWAR"},
    {id: 4, name:"ACOSF"}
];
const firstbook:Array<Book>=findbook(<Book><unknown>(books)) ;
console.log(firstbook);

function findbook <T,u>(inventory:T): Array <T>{
    return inventory[0];
}
