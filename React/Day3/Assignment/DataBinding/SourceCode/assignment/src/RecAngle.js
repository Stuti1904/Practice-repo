import React, { useState } from 'react'
const RectAngle=()=>{
    const[length, setLength]=useState(0)
    const[width, setWidth]=useState(0)
    const [area, setArea] = useState("")
    const Area=()=>{
        setArea(length*width);
    }
return(
    <div class="card">
        <h1 class="card-header">This is rectangle component</h1>
        <label>Enter Length</label>
        <input type="number" value={length} onChange={(e)=>setLength(parseInt(e.target.value))} id="len"></input>
        <label>Enter Width</label>
        <input type="number" value={length} onChange={(e)=>setWidth(parseInt(e.target.value))} id="wid"></input>
        <button type="button" onClick = {Area}>Submit</button>
        <div class="card-footer">
            {
                <h4>The area is {area}</h4>
            }
        </div>
    </div>
)}
export default RectAngle
