import React from 'react';
import axios from 'axios';
import {navigate,Link} from '@reach/router'


const Authors=({authors,deleteAuthor})=>{


    const deleteHandler=(id)=>{
        axios.delete(`http://localhost:8000/api/authors/${id}`)
            .then(response => {
                console.log(response);
                deleteAuthor(id);
            })
            .catch(err => {
                console.log(err);
            })
            

    }
    
    const editHandler=(id)=>{
        navigate(`/authors/edit/${id}`)

    }


    return(
        <div>
            <Link to="/authors/create">Create an author</Link>
            {authors.map((author,index)=>{
                return(
                <div key={index}>
                    <table>
                        <tr>
                            <th>Author</th>
                            <th>Actions</th>
                        </tr>
                        <tr>
                            <td>{author.name}</td>
                            <td>
                                <button onClick={()=>{deleteHandler(author._id)}}>Delete</button>
                                <button onClick={()=>{editHandler(author._id)}}>Edit</button>
                            </td>
                        </tr>
                    </table>

                </div>
                )
            })
            }

        </div>
    )
}
export default Authors;