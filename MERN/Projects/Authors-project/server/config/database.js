const mongoose = require('mongoose');
mongoose.connect ("mongodb://localhost/Authors_db",{
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useFindAndModify: false
})
require('../models/Author');