import React,{useState, useEffect} from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios'
import { Router,Link } from '@reach/router';
import Authors from './views/Authors';
import UpdateAuthor from './views/UpdateAuthor';
import CreateAuthor from './views/CreateAuthor';


function App() {
  const [authors, setAuthors]=useState([]);
  useEffect(()=>{
    getAuthorAPI();
  },[]);

  const getAuthorAPI=()=>{
    axios.get("http://localhost:8000/api/authors")
    .then(response=>{
      console.log(response.data);
      setAuthors(response.data);
    })
    .catch(err=>{
      console.log(err.response);
    })
  }

  const deleteAuthor =(id)=>{
    setAuthors(authors.filter(author => author._id !== id));
  }
  const updateAuthor=(id,author)=>{
    let index=0;
    for (let i=0;i<authors.length;i++){
      if (authors[i]._id==id){
        index=i;
      }
    }
    let newAuthors=[...authors];
    newAuthors[index].name=author.name;
    setAuthors(newAuthors);
  }

  const addAuthor=(author)=>{
    let newAuthors=[...authors,author]
    setAuthors(newAuthors);

  }

  return (
    <div className="App">
      
      <Router>
        <Authors path="/" authors={authors} deleteAuthor={deleteAuthor} ></Authors>
        <CreateAuthor path="/authors/create" addAuthor={addAuthor}></CreateAuthor>
        <UpdateAuthor path="/authors/edit/:id" updateAuthor={updateAuthor}></UpdateAuthor>
      </Router>
      
    </div>
  );
}

export default App;
