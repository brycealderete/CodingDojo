module.exports = {
    index: (req, res) => {
        // return all people
        res.json(new Fake());
    },

    create: (req, res) => {
        // create and return new person
        console.log(req.body);
        res.json({"response": "Your data was passed successfully!"});
    },

    getOne: (req, res) => {
        res.json({"response": `Your id is ${req.params.id}`});
    }

}