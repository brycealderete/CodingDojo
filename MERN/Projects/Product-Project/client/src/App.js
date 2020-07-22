import React, {useEffect, useState} from 'react';
import { Router } from '@reach/router';
import axios from 'axios';
import './App.css';
import Products from './views/Products'
import Product from './views/Product'
import {navigate} from '@reach/router';

function App() {
  const [products,setProducts]=useState([]);
  const [title,setTitle]=useState("");
  const [price,setPrice]=useState();
  const [description,setDescription]=useState("");

  useEffect(()=>{
    getProductsAPI();
  },[])


  const getProductsAPI=()=>{
    axios.get("http://localhost:8000/api/products")
    .then(response=>{
      console.log(response.data);
      setProducts(response.data);
    })
    .catch(err=>{
      console.log(err.response);
    })
  }


    const createProduct=(e)=>{
      e.preventDefault()
      let newProduct= {
        title:title,
        price:price,
        description:description
      };
      

      axios.post("http://localhost:8000/api/products",newProduct)
      .then(response=>{
        console.log(response);
        setProducts([...products,response.data]);
        navigate("/");


        
      })
      .catch(err=>{
        console.log(err.response)
      })
    }

  return (
    <div className="App">
      <div>
        <h2>Product Manager</h2>
        <form className="form-group" onSubmit={createProduct} >
          <label className="form-control">Title</label>
          <input className="form-control" type="text" onChange={(e) => setTitle(e.target.value)} />
          <br/>
          <label className="form-control">Price</label>
          <input className="form-control" type="number" onChange={(e) => setPrice(e.target.value)} />
          <br/>
          <label className="form-control">Description</label>
          <input className="form-control" type="text" onChange={(e) => setDescription(e.target.value)} />
          <br/>
          <input type="submit"/>
        </form>
      </div>
      <div>
        
      </div>
      <Router> 
        <Products path="/" products={products}/>
        <Product path ="/products/:id"/>
      </Router>
    </div>
  );
}

export default App;
