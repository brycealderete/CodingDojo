import React, { useState, useEffect } from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  const [pokemon,setpokemon] = useState([]);

  useEffect(()=>{
    fetch("https://pokeapi.co/api/v2/pokemon?offset=300&limit=100")
    .then(response=>response.json())
    .then(response=>setpokemon(response.results))
  },[]);
  console.log(pokemon);

  return (
    
    <div className="App">
      {pokemon.length>0 && pokemon.map((poke,idx)=>{
        return(<div key={idx}> {poke.name}</div>)
      })}

    </div>
  );
}

export default App;
