import React, { useState } from 'react'
import { render } from '@testing-library/react';
import Box from './Box'





const BoxGenerator = (props)=>{
    const [colors,setColor]=useState("");
    const [state, setState] = useState([
    ]);

    

    const createBox =(e)=>{
        e.preventDefault();

        setState([
            ...state,{"color":colors,
                "boxStyle": {
                width:"100px",
                height:"130px",
                background: colors, 
                color: colors,
                border: colors,
                display: "inline-block"
                }
            }
        ]);
        console.log(state);
        console.log(colors);
    
    };
        


    const handleColor =(e)=>{
        setColor(e.target.value)

    }

    
    

    return(
        <form onSubmit={createBox}>
            <div >
                <label>Color:</label>
                <input type="text" onChange={(e)=>setColor(e.target.value)}/>
                <br></br>
                <input type="submit" value="Add Box" />
                
            </div>
            <div><Box color={state}/></div>

        </form>
    )
}

export default BoxGenerator;