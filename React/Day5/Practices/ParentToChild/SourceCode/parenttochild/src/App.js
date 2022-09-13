import React, {useState} from 'react';
import './App.css';
import Display from './DisPlay';
function App() {
  const[item, setitem]= useState('');
  return (
    <div className="App">
      <input type="text" onChange={(e)=>setitem(e.target.value)}></input>
      <Display items={item}></Display>
    </div>
  );
}

export default App;
