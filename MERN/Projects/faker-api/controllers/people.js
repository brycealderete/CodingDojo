const mongoose = require("mongoose");
let Person = mongoose.model("Person");

module.exports = {
    index: (req, res) => {
        // check req
        // check req.params
        // check req.body
        Person.find()
            .then(data => res.json({message: "success", data: data}))
            .catch(err => {
                console.log("We are in index of people controller:");
                console.log(err);
                res.status(400).json(err)
            })
    },

    create: (req, res) => {
        Person.create(req.body)
            .then(data => res.json(data))
            .catch(err => res.json(err))
    }
}

// CRUD

// Create
// Read
//  - Find One By Id
//  - Get All
// Update
//  - Both the ID of the object to update
//  - AND we need the new data
//  - Change an existing document
// Delete
// - Delete by Id