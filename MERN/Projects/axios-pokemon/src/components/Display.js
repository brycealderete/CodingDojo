import React from 'react'

const Display=({pokemon})=>{

    return(
        <div>
        {pokemon.map((item,i)=>
            <div key={i}>
            <ul>
                <li>{item.name}</li>
            </ul>
            </div>
            )}
            </div>
    )


}

export default Display;