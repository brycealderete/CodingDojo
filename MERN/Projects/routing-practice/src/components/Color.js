import React, {useState} from 'react'
import { Router, Link } from '@reach/router';

const Color =({string,backgroundColor,textColor})=>{
    const style=({"background-color":backgroundColor,"color":textColor});
    return(
        <h1 style={style}>{string}</h1>
    )
}

export default Color;