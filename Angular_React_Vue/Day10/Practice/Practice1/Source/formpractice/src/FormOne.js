import react, {useState} from 'react';
const Name=()=>{
    const [name, setname]=useState("")
    const [result, setresult] =useState("")
    const submit=(e)=>{
        setresult(name);
        return result;
    }
return(
    <div>
<input type="text" value={name} onChange={(e)=>setname(e.target.value)}></input>
<button type="button" onClick={submit}>Submit</button>
<p>{result}</p>
    </div>
)
}
export default Name