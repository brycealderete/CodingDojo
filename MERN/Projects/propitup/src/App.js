import React from 'react';
import './App.css';
import PersonCard from './components/PersonCard';

function App() {
  return (
    <div className="App">
      <PersonCard firstName={"Bryce"} lastName={"Alderete"} age={"31"} hairColor={"Brown"}/>
      <PersonCard firstName={"Destinee"} lastName={"Alderete"} age={"28"} hairColor={"Blonde"}/>
      <PersonCard firstName={"Hector"} lastName={"Raygoza"} age={"50"} hairColor={"Brown"}/>
      <PersonCard firstName={"Gina"} lastName={"Raygoza"} age={"52"} hairColor={"Brown"}/>
        
    </div>
  );
}

export default App;
