const mongoose = require('mongoose');

mongoose.connect('mongodb://localhost/my-mongo', {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useFindAndModify: false
});

require('../models/Person');