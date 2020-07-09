import React from 'react'

const Tabs = props => {
    const tabs=[{tab1:"tab1 stuff"},{tab2:"tab2 stuff"},{tab3:"tab3 stuff"}]
    const onClickHandler = (e, value) => {
        alert(value);
    }
 
    return props.tabs.map( (item, index) => {
        return <button onClick={ (e) => onClickHandler(e, item) }>{ item }</button>
    });
}

export default Tabs;