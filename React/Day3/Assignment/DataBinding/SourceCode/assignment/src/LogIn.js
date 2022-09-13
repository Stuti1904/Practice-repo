import React, { useState } from 'react'
const Login=()=>{
    const[userName, setusername]=useState("")
    const[passWord, setpassword]=useState("")
    const [result, setresult] = useState("")
    const Result=()=>{
        if(userName=="admin"&& passWord=="admin"){
            setresult("Logged In");
        }
        else{
            setresult("Not logged in");
        }
    }
return(
    <div class="card">
        <h1 class="card-header">This is Login component</h1>
        <label>Enter Username</label>
        <input type="text" value={userName} onChange={(e)=>setusername(e.target.value)} id="user"></input>
        <label>Enter password</label>
        <input type="text" value={passWord} onChange={(e)=>setpassword(e.target.value)} id="pass"></input>
        <button type="button" onClick = {Result}>Submit</button>
        <div class="card-footer">
            {
                <h4>You are: {result}</h4>
            }
        </div>
    </div>
)}
export default Login
