import { User, username } from "./user";
export interface order extends User, username{
orderid: number;
}
export var myorder: order[]=[];
export class orders{
    generateorder(obj:order){
        myorder.push(obj);
    }
    showorderlist(){
        for(var i=0; i<myorder.length;i++){
            console.log(`${i+1} Userid: ${myorder[i].userid} Username: ${myorder[i].username}  Orderid: ${myorder[i].orderid}`);
            console.log("                                                                    ");
        }
    }
}