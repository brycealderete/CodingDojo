import React, { useState } from 'react'
import TabStuff from './TabStuff'

const Tabs = props => {
    const [tabs,setTabs]=useState([{name:"Tab1",message:"tab1 stuff",selected:true},{name:"Tab2",message:"tab2 stuff",selected:false},{name:"Tab3",message:"tab3 stuff",selected:false}])
    
    
    const onClickHandler = (e, value,index) => {
        let newTab=value;
        let newTabs=[].concat(...tabs);
        
        
        for(let i =0;i<newTabs.length;i++){
            if(newTabs[i]===newTabs[index]){
                
                newTabs[i]=({name:newTab.name,message:newTab.message,selected:true});
                console.log(newTabs[i])
            }
            else{
                let temp=newTabs[i];
                newTabs[i]=({name:temp.name,message:temp.message,selected:false})
                console.log("in temp"+newTabs[i])
                
                
            }

            setTabs(newTabs);
        }

        
    }

    return tabs.map( (item, index) => {
        
        return (
        <div>
            <div>
                <button onClick={ (e) => onClickHandler(e, item, index) }>{ item.name }</button>
        

            </div>
            <div>
                {item.selected &&
                <p>{item.message}</p>
                }
            </div>
        </div>
    )}
    );
        
}


export default Tabs;