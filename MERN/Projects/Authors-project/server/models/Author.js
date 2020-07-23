const mongoose=require('mongoose');

const AuthorSchema=new mongoose.Schema({
    name:{
        type:String,
        required: true,
        minlength:[2,'Author must be 2 or more characters!']
    }

},{timestamps:true})

mongoose.model("Author",AuthorSchema);