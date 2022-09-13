class myclass{
obje:string;
num:number;
}
const myob= new myclass();
myob.obje="stuti";
myob.num=19;
console.log(`${myob.obje} ${myob.num}`);
class Point {
    constructor(x: number, y: string);
    constructor(s: string);
    constructor(xs: any, y?: any) {
    }
  }
let myobj= new Point(11,"stuti");
console.log(`${myobj}`);
