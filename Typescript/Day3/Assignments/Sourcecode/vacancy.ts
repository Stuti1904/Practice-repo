

export  interface Vacancyint{
    id:number
    post:string
    vacNo:number
    company_Name:string
    jobDes:string
}
export  class Vacancy {

vacStack:Array<Vacancyint> =[]


createVacancy(obj:Vacancyint){
    this.vacStack.push(obj);
}
displayAllVacancy(){
    for(let item of this.vacStack){
        console.log(item);
        
    } 
}
viewOneVacancy(id:number){
    var findINd = this.vacStack.findIndex((item)=>item.id==id)
    console.log(this.vacStack[findINd]);
    
}
clearVacancy(id:number){
    var findINd = this.vacStack.findIndex((item)=>item.id==id)
    this.vacStack.splice(findINd,1);
}

}