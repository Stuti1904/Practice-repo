import { Person } from "./person";

export interface Iapplicant extends Person{
    address:string;
    experience:number|string;
}
export var applicantStack:Iapplicant[]=[]
export class Applicant {
    createApplicant(obj:Iapplicant){
        applicantStack.push(obj);

    }
    viewAllApplicant(){
        for(let A of applicantStack){
            console.log(A);
            
        }
    }
    viewByIdApplicant(id:number){
        var findINd = applicantStack.findIndex((item)=>item.id==id)
        console.log(applicantStack[findINd]);
        
    }
}
