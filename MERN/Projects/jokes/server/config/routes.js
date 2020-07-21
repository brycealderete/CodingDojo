let jokes =require('../controllers/jokes')
const { Aggregate } = require('mongoose')
module.exports=(app)=>{
    app.get('/api/jokes',jokes.index);
    app.get('/api/jokes/:id', jokes.getOne);
    app.post('/api/jokes', jokes.create);
    app.put('/api/jokes/:id',jokes.update);
    app.delete('/api/jokes/:id',jokes.delete);

}