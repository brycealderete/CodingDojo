import React,{useState} from 'react';
import logo from './logo.svg';
import './App.css';
import Tabs from './components/Tabs';
import TabStuff from './components/TabStuff';

function App() {
  const [tabs,setTabs]=useState(["tab1 stuff","tab2 stuff","tab3 stuff"])
  return (
    <div className="App">
      <Tabs tabs={tabs}/>
    </div>
  );
}

export default App;
