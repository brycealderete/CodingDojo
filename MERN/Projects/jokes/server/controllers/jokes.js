const mongoose=require('mongoose');
const Joke=mongoose.model('Joke');

module.exports={
    index: (req,res)=>{
        Joke.find()
        .then((jokes)=>{
            console.log ("we are in jokes.find");
            console.log(jokes);
            res.json(jokes)
        })
        .catch(err=>{
            console.log(err);
            res.status(400).json(err)
        });
    },
    getOne:(req,res)=>{
        jokes.findOne({_id: req.params.id})
        .then(joke=>res.json(joke))
        .catch(err=>res.status(400).json(err));
    },
    create:(req,res)=>{
        Joke.create(req.body)
        .then(newJoke=>res.json(newJoke))
        .catch(creationErrors=>res.status(400).json(creationErrors));
    },
    update: (req,res)=>{
        Joke.findOneAndUpdate({_id:req.params.id},req.body, {runValidators:true,new:true})
        .then(updatedJoke=>res.json({joke:updatedJoke}))
        .catch(err=>res.json({message:"something went wrong", error:err}));
    },
    delete: (req,res)=>{
        Joke.deleteOne({_id: req.params.id})
        .then(result=>res.json({result:result}))
        .catch(err=>res.json({message:"Something went wrong", error:err}));
    }
}