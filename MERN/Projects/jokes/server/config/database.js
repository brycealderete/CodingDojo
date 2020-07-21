const mongoose = require('mongoose');
mongoose.connect ("mongodb://localhost/jokes_db",{
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useFindAndModify: false
})
require('../models/Joke');