import React from 'react'
import { Link } from '@reach/router';

const Products =({products})=>{
    
    
    
    
    
    return(
        <div>
            {products.map((product,i)=>{
                return(
                <div key={i}>
                    <h3> <Link to={`/products/${product._id}`} >{product.title}</Link></h3>
                    

                </div>
                )

            })
            }
        </div>

    )
}


export default Products;