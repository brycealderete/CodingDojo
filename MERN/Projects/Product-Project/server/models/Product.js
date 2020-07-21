const mongoose=require('mongoose');

const ProductSchema=new mongoose.Schema({
    title:{
        type:String,
        required: true,
        minlength:[2,'Product must be 2 or more characters!']
    },
    price:{
        type:Number,
        required:true
    },
    description:{
        type:String,
        required:true
    }

},{timestamps:true})

mongoose.model("Product",ProductSchema);