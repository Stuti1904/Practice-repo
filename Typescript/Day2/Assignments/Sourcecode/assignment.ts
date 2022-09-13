var inventory: {pid:number, pname:string, quantity:number}[]=[
    {pid:12, pname:"pencil", quantity:10},
    {pid:13, pname:"pen", quantity:10},
    {pid:14, pname:"eraser", quantity:10},
    {pid:15, pname:"ruler", quantity:10},
    {pid:16, pname:"sharpner", quantity:10},
  ];
  let ordered=13;
  let amount=2;
  var r=inventory.filter((value)=>{
    if(value.pid ==ordered) {
         value.quantity=value.quantity-amount;
        if(value.quantity<5){
            console.log("REORDER");
            console.log( value.pid, value.pname);
        }
        else{
            console.log(value.pid, value.pname + "quantity remaining"+ value.quantity);
        }
    } 
    return true;
  })
  