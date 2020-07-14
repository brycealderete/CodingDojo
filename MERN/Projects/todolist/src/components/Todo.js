import React, {useState} from 'react' 
import TodoDisplay from './TodoDisplay'

const Todo =()=>{
    const [todos,setTodos]= useState([]);
    const [todo,setTodo]= useState("");


    const submitHandler=(e)=>{
        e.preventDefault();
        setTodos([...todos, {message:todo, status:false, style:{"text-decoration": "line-through"}}])
    }

    const todoHandler=(e)=>{
        setTodo(e.target.value);
    }
    const deleteHandler=(i)=>{
        let newtodos=[];
        newtodos=[...todos];
        newtodos.splice(i,1);
        setTodos(newtodos);
    }

    const iscompleted =(i)=>{
        let newtodos=[];
        newtodos=[...todos];
        if(newtodos[i].status){
            newtodos[i].status=false;
            setTodos(newtodos);
            console.log(newtodos[i]);
        }
        else{
        newtodos[i].status=true;
        setTodos(newtodos);
        console.log(newtodos[i]);
        }

    }

    return(
        <div>
            <form onSubmit={submitHandler}>
                <label>Add Todo:</label> 
                <input type="text" onChange={todoHandler} value= {todo}/>
                <input type="submit"/>
            </form>
            <TodoDisplay todos={todos} iscompleted={iscompleted} deleteHandler={deleteHandler}/>
        </div>
    )
}

export default Todo;