
// replace products with whatever we are creating
let products =require('../controllers/products')
const { Aggregate } = require('mongoose')
module.exports=(app)=>{
    app.get('/api/products',products.index);
    app.get('/api/products/:id', products.getOne);
    app.post('/api/products', products.create);
    app.put('/api/products/:id',products.update);
    app.delete('/api/products/:id',products.delete);

}