let authors =require('../controllers/authors')
const { Aggregate } = require('mongoose')
module.exports=(app)=>{
    app.get('/api/authors',authors.index);
    app.get('/api/authors/:id', authors.getOne);
    app.post('/api/authors', authors.create);
    app.put('/api/authors/:id',authors.update);
    app.delete('/api/authors/:id',authors.delete);

}