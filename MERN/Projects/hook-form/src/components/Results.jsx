import React from 'react';

const Results = (props)=>{
    const {firstName,lastName,email,password}= props.user;
    return(
        <div>
            <p>First Name:     {firstName}</p><br/>
            <p>Last Name:     {lastName}</p><br/>
            <p>Email:     {email}</p><br/>
            <p>Password:     {password}</p>
        </div>
    );
};



export default Results;
