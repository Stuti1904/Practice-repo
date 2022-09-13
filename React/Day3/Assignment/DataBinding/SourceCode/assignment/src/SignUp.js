import React, { useState } from 'react'
const SignUp=()=>{
    const[Name, setname]=useState("")
    const[Address, setaddress]=useState("")
    const[PanNumber, setpan]=useState("")
    const [finalname, setfinalname] = useState("")
    const [finaladdress, setfinaladdress] = useState("")
    const [finalpan, setfinalpan] = useState("")
    const Result=()=>{
      setfinalname(Name);
      setfinalpan(PanNumber);
      setfinaladdress(Address);
    }
return(
    <div class="card">
        <h1 class="card-header">This is SignUp component</h1>
        <label>Enter Username</label>
        <input type="text" value={Name} onChange={(e)=>setname(e.target.value)} id="name"></input>
        <label>Enter address</label>
        <input type="text" value={Address} onChange={(e)=>setaddress(e.target.value)} id="address"></input>
        <label>Enter PanNumber</label>
        <input type="text" value={PanNumber} onChange={(e)=>setpan(e.target.value)} id="pan"></input>
        <button type="button" onClick = {Result}>Submit</button>
        <div class="card-footer">
            {
                <div>
               <p>Your name is{finalname}</p>
               <p>Your address is{finaladdress}</p>
               <p>Your pan number is{finalpan}</p>
               </div>
            }
        </div>
    </div>
)}
export default SignUp
