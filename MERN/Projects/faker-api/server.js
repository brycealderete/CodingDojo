// imports and requires
const express = require('express');
const cors = require('cors');
const app = express();

app.use(cors());
app.use(express.json());


// routes
// catch all
require('./config/mongoose');
require('./config/routes')(app);


// server listener
app.listen(8008, () => {
    console.log("Listening on port 8008 for basic express!")
})


