import React from 'react';
import { Router, Link } from '@reach/router';
import './App.css';
import Home from './components/Home'
import Color from './components/Color'
import Hello from './components/Hello'
import Number from './components/Number'

function App() {
  return (
    <div className="App">
      <Router>
            <Home path="/home/"/>
            <Number path="/:num/"/>
            <Hello path ="/hello/"/>
            <Color path ="/:string/:backgroundColor/:textColor/"/>
        </Router>
        <Link to="/home">Home</Link>
        <br></br>
        <Link to="/hello/">Hello</Link>
        

    </div>
  );
}

export default App;
