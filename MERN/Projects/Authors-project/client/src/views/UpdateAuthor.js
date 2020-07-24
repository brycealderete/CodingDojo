import React, { useState,useEffect } from 'react'
import axios from 'axios'
import {navigate,Link} from '@reach/router'


const UpdateAuthor=({id,updateAuthor})=>{
    const [name, setName]=useState("");
    const [error, setError]=useState({});

    useEffect(()=>{
        axios.get(`http://localhost:8000/api/authors/${id}`)
        .then(response=>{
        console.log(response.data);
        setName(response.data.name);
        setError({});
        
        })
        .catch(err=>{
        console.log(err.response.reason);
        setError(err.response);

        })
    },[]);
    console.log(error)

    const formHandler =(e)=>{
        e.preventDefault();
        let updatedAuthor={
            name:name
        }
        axios.put(`http://localhost:8000/api/authors/${id}`,updatedAuthor)
        .then(response => {
            console.log(response);
            updateAuthor(id,updatedAuthor);
            navigate("/");
            
            
        })
        .catch(err => {
    
            // const errorsArray = [];
            // for(const key of Object.keys(err.response.data.errors)){
            //     errorsArray.push(err.response.data.errors[key].properties.message);
            // };
    
            // setErrors(errorsArray);
        })
        
        
        



    }


    return(
        <div>
            <div>
                {error.status == 400 &&
                    <div>
                        <h3 style={{color:'red'}}>We're sorry, but we could not find the author you are looking for. Would you like to add this author to our database?</h3>
                        <Link to="/authors/create">Create an author</Link>
                    </div>
                }
            </div>
            <div>
                <Link to="/">Back</Link>
                <h1>Edit Author</h1>
                <form on onSubmit={formHandler}>
                    <label>Author Name:</label>
                    <input type="text" value={name} onChange={(e)=>{setName(e.target.value)}} ></input>
                    <input type="submit" ></input>
                </form>
            </div>

        </div>
    )
}

export default UpdateAuthor;