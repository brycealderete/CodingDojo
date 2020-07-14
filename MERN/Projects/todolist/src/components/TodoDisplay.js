import React from 'react'

const TodoDisplay =({todos,iscompleted,deleteHandler})=>{
    // console.log(todos);





    return(
        <div>
            {todos.map((item,i)=>
            <div key={i}>
                <p>{item.message}</p>
                {item.status===true &&
                <div>
                <label style={item.style}>Check when completed</label>
                <input type="checkbox"  checked={item.status} onChange={(e)=>{iscompleted(i)}} />
                </div>
                }
                {item.status===false &&
                <div>
                <label >Check when completed</label>
                <input type="checkbox"  onChange={(e)=>{iscompleted(i)}} />
                </div>
                }
                <form onSubmit={(e)=>{
                    e.preventDefault()
                    deleteHandler(i)
                }}>
                    <input type="submit" value="Delete" />
                </form>


            </div>
            
            )}
        </div>

    );

}


export default TodoDisplay;