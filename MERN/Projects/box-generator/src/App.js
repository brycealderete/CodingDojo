import React, {useState} from 'react';
import './App.css';
import BoxGenerator from './components/BoxGenerator';
import Box from './components/Box'

function App() {
  const [colors,setColor]=useState({color:""});
  
  return (
    <div className="App">
      <BoxGenerator color={setColor}/>
      
    </div>
  );
}

export default App;
