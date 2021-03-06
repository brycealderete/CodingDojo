import React,{useState}from 'react'
import axios from 'axios'
import { navigate, Link } from '@reach/router';

const CreateAuthor=({addAuthor})=>{
    const [name,setName]=useState("");
    const [error,setError]=useState({});

    const formHandler=(e)=>{
        e.preventDefault();
        let author={
            name:name
        }
        axios.post("http://localhost:8000/api/authors",author)
        .then(response=>{
            console.log(response);
            addAuthor(response.data);
            setError({});
            navigate("/");

        })
        .catch(err=>{
            console.log(err.response.data.errors.name.properties)
            let newError={};
            newError=err.response.data.errors.name.properties;
            setError(newError)
        })

    }

    return(
        <div>
            <Link to="/">Back</Link>
            <h1>Create a Author</h1>
            <form onSubmit={formHandler}>
                <label>Name:</label>
                {error!={} &&
                <p style={{color:'red'}}>{error.message}</p>
                }
                <input type="text" onChange={(e)=>{setName(e.target.value)}}></input>
                <input type="submit"/>
            </form>
            
        </div>

    )
}

export default CreateAuthor;