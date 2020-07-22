
import axios from 'axios';
import React, {useEffect, useState} from 'react';
import {navigate} from '@reach/router';

const Product =({id,deleteProduct}) =>{
    const[product,setProduct]=useState({})
    

    

    useEffect(()=>{
        axios.get(`http://localhost:8000/api/products/${id}`)
        .then(response=>{
        console.log(response.data);
        setProduct(response.data)
        })
        .catch(err=>{
        console.log(err.response);
        })
    },[]);
    
    const clickHandler=()=>{
        navigate(`/products/edit/${id}`)
    }
    const deleteHandler=()=>{
        axios.delete(`http://localhost:8000/api/products/${id}`)
            .then(response => {
                console.log(response);
                deleteProduct(id);
            })
            .catch(err => {
                console.log(err);
            })
            navigate("/")
    
    }
    
    
    
    return(
        <div>
            <div>
                <h2>{product.title}</h2>
                <p>{product.price}</p>
                <p>{product.description}</p>
            </div>
            <div>

                <button onClick={clickHandler}>Edit</button>
                <button onClick={deleteHandler}>Delete</button>
            </div>
        </div>

    )
}


export default Product;