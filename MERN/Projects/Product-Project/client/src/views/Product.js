
import axios from 'axios';
import React, {useEffect, useState} from 'react';

const Product = props =>{
    const[product,setProduct]=useState({})
    

    useEffect(()=>{
        axios.get(`http://localhost:8000/api/products/${props.id}`)
        .then(response=>{
        console.log(response.data);
        setProduct(response.data)
        })
        .catch(err=>{
        console.log(err.response);
        })
    },[]);
    
        
    
    
    
    return(
        <div>
            <h2>{product.title}</h2>
            <p>{product.price}</p>
            <p>{product.description}</p>
        </div>

    )
}


export default Product;