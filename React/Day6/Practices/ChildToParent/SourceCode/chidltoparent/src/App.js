import './App.css';
import ProFile from './ProFile';
import { useState } from 'react';
function App() {
  const [name, setname]= useState();
  function display(name){
setname(name);
  }
  return (
    <div className="App">
     <ProFile getdata={display}></ProFile>
     <h1>{name}</h1>
    </div>
  );
}

export default App;
