import React, {useEffect, useState} from 'react';
import axios from 'axios';
import {navigate} from '@reach/router';


const UpdateProduct =({updateProduct,id})=>{
    const [title,setTitle]=useState("");
    const [price,setPrice]=useState();
    const [description,setDescription]=useState("");
    

    useEffect(()=>{
        axios.get(`http://localhost:8000/api/products/${id}`)
        .then(response=>{
        console.log(response.data);
        setTitle(response.data.title)
        setPrice(response.data.price)
        setDescription(response.data.description)
        })
        .catch(err=>{
        console.log(err.response);
        })
    },[]);


    const clickHandler =(e)=>{
        e.preventDefault()
        let updatedProduct={
            title:title,
            price:price,
            description:description
        }

        axios.put(`http://localhost:8000/api/products/${id}`,updatedProduct)
        .then(response => {
            console.log(response);
            
    
            // updateColor(id, {name: name, hex: hex});
            
        })
        .catch(err => {
    
            // const errorsArray = [];
            // for(const key of Object.keys(err.response.data.errors)){
            //     errorsArray.push(err.response.data.errors[key].properties.message);
            // };
    
            // setErrors(errorsArray);
        })
        updateProduct(id,updatedProduct);
        navigate("/");
    }
    


    return (
        <div>
            <h1>Edit Product</h1>
            <form className="form-group" onSubmit={clickHandler} >
            <label className="form-control">Title</label>
            <input className="form-control" type="text" value={title} onChange={(e) => setTitle(e.target.value)} />
            <br/>
            <label className="form-control">Price</label>
            <input className="form-control" type="number" value={price} onChange={(e) => setPrice(e.target.value)} />
            <br/>
            <label className="form-control">Description</label>
            <input className="form-control" type="text" value={description} onChange={(e) => setDescription(e.target.value)} />
            <br/>
            <input type="submit"/>
            </form>


        </div>
    )
}
export default UpdateProduct;