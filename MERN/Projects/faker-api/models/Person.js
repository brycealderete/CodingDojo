const mongoose = require('mongoose');

const PersonSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        minlength: [4, "Your name must be at least four characters long."]
    },
    age: Number,
    email: String
}, {timestamps: true})

mongoose.model("Person", PersonSchema);