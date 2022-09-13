import { Applicant } from "./applicant";
import { Interview } from "./interview";
import { Person } from "./person";


export interface ISelectedPerson extends Person{
    salary:number
    joinDate:string
    
}
export class SelectedPerson{
    hiredStack:ISelectedPerson[]=[];

        createHiredSet(obj:ISelectedPerson){
            this.hiredStack.push(obj)
        }
        viewAllHired(){
            for(let A of this.hiredStack){
                console.log(A);
                
            }
        }
        viewOneHired(id){
            var findINd = this.hiredStack.findIndex((item)=>item.id==id)
            console.log(this.hiredStack[findINd]);
        } 
}
