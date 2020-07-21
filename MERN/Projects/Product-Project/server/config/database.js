const mongoose = require('mongoose');
mongoose.connect ("mongodb://localhost/Products_db",{
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useFindAndModify: false
})
require('../models/Product');