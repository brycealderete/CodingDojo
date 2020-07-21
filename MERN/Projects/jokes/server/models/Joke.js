const mongoose=require('mongoose');

const JokeSchema=new mongoose.Schema({
    setUp:{
        type:String,
        required: true,
        minlength:[2,'Joke must be 2 or more characters!']
    },
    punchLine:{
        type:String,
        required:true
    }

},{timestamps:true})

mongoose.model("Joke",JokeSchema);