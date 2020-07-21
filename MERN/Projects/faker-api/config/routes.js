let fakes = require('../controllers/fakes');
let people = require('../controllers/people');

module.exports = function(app) {
    app.all("*", (req, res, next) => {
        console.log(`incoming ${req.method} at ${req.originalUrl}`);
        next();
    })

    app.get('/api/person', people.index)
    app.post('/api/person', people.create)

    app.get("/api/fake", fakes.index)
    app.get("/api/fake/:id", fakes.getOne)
    app.post("/api/fake", fakes.create)
};