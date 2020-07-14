import React, { useEffect,useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import Display from './components/Display'

function App() {
  const [pokemon,setPokemon]=useState([]);
  
    
    const clickHandler =()=>{
        axios.get("https://pokeapi.co/api/v2/pokemon?offset=300&limit=100")
            .then(response=>{setPokemon(response.data.results)})
      }; 
    
    
  
  
// console.log(pokemon);
return(
    <div>
      <button onClick={clickHandler}>Fetch pokemon</button>
      <Display pokemon={pokemon}/>
        
    </div>
)
}


export default App;
