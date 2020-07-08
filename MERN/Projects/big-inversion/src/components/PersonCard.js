import React, {Component} from 'react';

const PersonCard = props => {
    return(
        <div>
            <h1>{props.firstName}, {props.lastName}</h1>
            <p>Age: {props.Age}</p>
            <p>Hair Color: {props.hairColor}</p>
            

            

        </div>
    );
}



export default PersonCard; 