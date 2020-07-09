import React, { useState } from 'react'

const Box =({color}) =>{
    
    // console.log(props.color)


    

        return(
            <div>
            
            {color.map((item,i) =>
            <div key={i} style={item.boxStyle}>
                <p style={item.boxStyle}>{item.color}</p>
            </div>
            )}
            </div>
        );

}


export default Box;