import React, {useState} from 'react';
import logo from './logo.svg';
import './App.css';
import UserForm from './components/UserForm'
import Results from './components/Results'

function App() {
  const [user,setUser] = useState({fistName:"",lastName:"",email:"",password:""})
  return (
    <div className="App">
      <UserForm  setUser={setUser}/>
      <Results user={user}/>
      
    </div>
  );
}

export default App;
