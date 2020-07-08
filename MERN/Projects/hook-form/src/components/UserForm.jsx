import React, {useState} from 'react';

const UserForm = props => {
    const [firstName , setFirstName]= useState("");
    const [lastName , setLastName]= useState("");
    const [email , setEmail]= useState("");
    const [password , setPassword]= useState("");
    const [titleError, setTitleError] = useState("stop");
    const [firstNameError, setFirstNameError] = useState("");
    const [lastNameError, setLastNameError] = useState("");
    const [emailError, setEmailError] = useState("");
    const [passwordError, setPasswordError] = useState("");
    
    const createUser = (e)=>{
        if(titleError === ""){
        e.preventDefault();
        const newUser={firstName,lastName,email,password};
        props.setUser(newUser);
        console.log(newUser)
        }
        else{
            setTitleError("Cannot prosess request");
            console.log("not creating user!")
        }


    };

    const handleFirstName = (e) => {
        setFirstName(e.target.value);
        if(e.target.value.length < 1) {
            setFirstNameError("Title is required!");
            setTitleError("Cannot prosess request");
        } 
        else if(e.target.value.length < 3) {
            setFirstNameError("Title must be 3 characters or longer!");
            setTitleError("Cannot prosess request");
        }
        else{
            setFirstNameError("");
            setTitleError("");
        }
    }
    const handleLastName = (e) => {
        setLastName(e.target.value);
        if(e.target.value.length < 1) {
            setLastNameError("Title is required!");
            setTitleError("Cannot prosess request");
        } 
        else if(e.target.value.length < 3) {
            setLastNameError("Title must be 3 characters or longer!");
            setTitleError("Cannot prosess request");
        }
        else{
            setLastNameError("");
            setTitleError("");
        }
    }
    const handleEmail = (e) => {
        setEmail(e.target.value);
        if(e.target.value.length < 1) {
            setEmailError("Title is required!");
            setTitleError("Cannot prosess request");
        } 
        else if(e.target.value.length < 3) {
            setEmailError("Title must be 3 characters or longer!");
            setTitleError("Cannot prosess request");
        }
        else{
            setEmailError("");
            setTitleError("");
        }
    }
    const handlePassword = (e) => {
        setPassword(e.target.value);
        if(e.target.value.length < 1) {
            setPasswordError("Title is required!");
            setTitleError("Cannot prosess request");
        } 
        else if(e.target.value.length < 8) {
            setPasswordError("Title must be 8 characters or longer!");
            setTitleError("Cannot prosess request");
        }
        else{
            setPasswordError("");
            setTitleError("");
        }
    }


    return(
        <form onSubmit={ createUser }>
            <div>
                <label>First Name: </label> 
                <input type="text" onChange={ handleFirstName } />
                {
                    firstNameError ?
                    <p style={{color:'red'}}>{firstNameError}</p>:
                    ''
                }
            </div>
            <div>
                <label>Last Name: </label> 
                <input type="text" onChange={ handleLastName } />
                {
                    lastNameError ?
                    <p style={{color:'red'}}>{lastNameError}</p>:
                    ''
                }
            </div>
            <div>
                <label>Email Address: </label> 
                <input type="email" onChange={ handleEmail } />
                {
                    emailError ?
                    <p style={{color:'red'}}>{emailError}</p>:
                    ''
                }
            </div>
            <div>
                <label>Password: </label>
                <input type="password" onChange={ handlePassword } />
                {
                    passwordError ?
                    <p style={{color:'red'}}>{passwordError}</p>:
                    ''
                }
            </div>
            <input type="submit" value="Create User" />
        </form>
    );

}



export default UserForm;