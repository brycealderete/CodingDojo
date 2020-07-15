import React, { useState,useEffect } from 'react'
import axios from 'axios';

const Display =({what,id})=>{
    const[starwars,setStarwars]=useState({});

    useEffect(()=>{
        axios.get(`https://swapi.dev/api/${what}/${id}/`)
            .then(response=>{setStarwars(response.data)})
    }, [what,id]); 
    console.log(starwars);




    return(
        <div>
            {what==="people" &&
            <div>
            <h1>Name: {starwars.name}</h1>
            <h2>Height: {starwars.height}</h2>
            <h2>Mass: {starwars.mass}</h2>
            <h2>Hair Color: {starwars.hair_color}</h2>
            <h2>Skin Color: {starwars.skin_color}</h2>
            </div>
            
            }
            {what==="planets" &&
            <div>
            <h1>Name: {starwars.name}</h1>
            <h2>Climate: {starwars.climate}</h2>
            <h2>Terrain: {starwars.terrain}</h2>
            <h2>Surface Water: {starwars.surface_water}</h2>
            <h2>Population: {starwars.population}</h2>
            </div>
            
            }
            
        </div>

    )
}
export default Display;