import React, {useState} from 'react';
import './App.css';
import { Router, navigate } from '@reach/router';
import Display from './conponents/Display'

function App() {
  const[what,setWhat]=useState("");
  const[id,setId]=useState("")

  const formhandler= (e)=>{
    e.preventDefault()
    navigate(`/${what}/${id}`)
    console.log(what+'  '+id);


  }

  return (
    <div className="App">
      
      <form onSubmit={formhandler}>
        <label>Search for:</label>
        <select onChange={ (e) => setWhat(e.target.value) }>
          <option  value="people">People</option>
          <option  value="planets">Planet</option>
          <option selected disabled value=""></option>
        </select>
        <label>ID:</label>
        <input type="text" onChange={ (e) => setId(e.target.value) }/>
        <input type="submit"/>
      </form>
      <div>
        <Router>
          <Display path="/:what/:id/"/>
        </Router>
        
      </div>
      
      
    </div>
  );
}

export default App;
