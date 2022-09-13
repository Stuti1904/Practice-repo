import React, { useState } from 'react'
const GreaterNumber=()=>{
    const[num1, setnum1]=useState(0)
    const[num2, setnum2]=useState(0)
    const [result, setresult] = useState(0)
    const Result=()=>{
        if(num1>num2){
            setresult(num1)
        }
        else{
            setresult(num2)
        }
    }
return(
    <div>
        <label>Enter the first number</label>
        <input type="number" value={num1} onChange={(e)=>setnum1(parseInt(e.target.value))}></input>
        <label>Enter the second number</label>
        <input type="number" value={num2} onChange={(e)=>setnum2(parseInt(e.target.value))} ></input>
        <button type="button" onClick={Result}>Submit</button>
        <p>{result}</p>
    </div>
)}
export default GreaterNumber