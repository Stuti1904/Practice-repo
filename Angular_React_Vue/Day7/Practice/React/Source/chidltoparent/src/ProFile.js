import react, {useState} from 'react';
export default function ProFile(props){
const [myname, setmyname]= useState('')
function display(){
    props.getdata(myname);
}
return (
    <div>
        <input type="text" onChange={(e)=>setmyname(e.target.value)}></input>
        <button type="button" onClick={display}>Display</button>
    </div>
)
}