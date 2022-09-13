import { Applicant } from "./applicant";

export interface IInterview{
    id:number
    date:string
    type:string
    appliId:number
    vacId:number
    pass?:boolean
}

export class Interview{

    interviewStack:IInterview[]=[]

    scheduleInterview(obj:IInterview){
        this.interviewStack.push(obj)
    }
    viewAllInterview(){
        for(let i of this.interviewStack){
            console.log(i);
            
        }
    }
    updateInterview(id:number,status:boolean){
        var findINd = this.interviewStack.findIndex((item)=>item.appliId==id)
        this.interviewStack[findINd].pass=status;
    }
    hiredPep(){
        var hired= this.interviewStack.filter((value,i,interviewStack)=>{
            return value.pass==true;
        });
        for(let p of hired){
            console.log(p);
            
        }
    }

}