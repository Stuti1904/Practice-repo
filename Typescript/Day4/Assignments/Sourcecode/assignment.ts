type employeeType ={Id:number,Name:string ,city:string,DOJ:string}

let Emp_Data :employeeType[] = [
   {Id:1,Name:'stuti',city:'rajkot',DOJ:'2022/09/22'},
   {Id:2,Name:'yuta',city:'osaka',DOJ:'2022/09/22'},
   {Id:3,Name:'shotaro',city:'osaka',DOJ:'2022/09/22'},
   {Id:4,Name:'giselle',city:'seoul',DOJ:'1998/09/22'},
   {Id:5,Name:'hinata',city:'tokyo',DOJ:'1982/09/22'}
]; 
var id=2;
var findEmpById= Emp_Data.find((value)=>{
    return value.Id==id;
});

console.log(findEmpById);
var myDates = Emp_Data.filter((value)=>{
    return new Date(value.DOJ).getFullYear()>2020&&value.city=='ahmdabad';
})

console.log(myDates);


