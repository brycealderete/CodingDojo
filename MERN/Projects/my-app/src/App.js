import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { render } from 'react-dom';



class App extends Component {
  render(){
    return (
      <div className="App">
        <h1>Hello Dojo!</h1>
        <h3>Things I need to do:</h3>
        <ul>
          <li>Learn React</li>
          <li>Climb Mt. Everest</li>
          <li>Run a Marathon</li>
          <li>Feed the dogs</li>
        </ul>
      </div>
    );
  }
  
}

export default App;
