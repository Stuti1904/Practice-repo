import { User } from "./user";
import { username } from "./user";
import { order } from "./order";
import { myorder } from "./order";
import { orders } from "./order";
export interface Rate extends order,username{
    rating:number;
    remark:string;
}
export var myrating:Rate[]=[];
 export class dorate{
    pushrates(obj:Rate){
           myrating.push(obj);
        }
    viewrating(){
       for(var i=0; i<myrating.length;i++){
           console.log(` ${i+1}. Username: ${myrating[i].username} Orderid :${myrating[i].orderid}  Rating: ${myrating[i].rating}  Remarks: ${myrating[i].remark}`);
           console.log("                                                         ");
       }
    }
    sortbyrating(){
        for(var i=0; i<myrating.length; i++){
            if(myrating[i].rating<=3){
                console.log(`${i+1} Username: ${myrating[i].username} Orderid :${myrating[i].orderid}  Rating: ${myrating[i].rating}  Remarks: ${myrating[i].remark}`);
                console.log("                                                         ");
            }
        }
    }
    fiverating(){
        for(var i=0; i<myrating.length;i++){
            if(myrating[i].rating==5){
                console.log(`${i+1} Username: ${myrating[i].username} Orderid :${myrating[i].orderid}  Rating: ${myrating[i].rating}  Remarks: ${myrating[i].remark}`);
                console.log("                                                         ");
            }
        }
    }
    sortbyusername(){
        var temp:Rate;
        for(var i=0; i<myrating.length-1;i++){
            if(myrating[i].username>myrating[i+1].username){
               temp=myrating[i+1];
                myrating[i+1]=myrating[i];
                myrating[i]=temp;
            }
        }
        for(var i=0; i<myrating.length;i++){
            console.log(` ${i+1}. Username: ${myrating[i].username} Orderid :${myrating[i].orderid}  Rating: ${myrating[i].rating}  Remarks: ${myrating[i].remark}`);
            console.log("                                                         ");
        }
    }
    decreasingrating(){
        var temp:Rate;
        for(var i=0; i<myrating.length-1;i++){
            if(myrating[i].rating<myrating[i+1].rating){
               temp=myrating[i+1];
                myrating[i+1]=myrating[i];
                myrating[i]=temp;
            }
        }
        for(var i=0; i<myrating.length;i++){
            console.log(` ${i+1}. Username: ${myrating[i].username} Orderid :${myrating[i].orderid}  Rating: ${myrating[i].rating}  Remarks: ${myrating[i].remark}`);
            console.log("                                                         ");
        } 
    }
}
