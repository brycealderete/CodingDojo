const mongoose=require('mongoose');
const Author=mongoose.model('Author');

module.exports={
    index: (req,res)=>{
        Author.find()
        .then((authors)=>{
            console.log ("we are in authors.find");
            console.log(authors);
            res.json(authors)
        })
        .catch(err=>{
            console.log(err);
            res.status(400).json(err)
        });
    },
    getOne:(req,res)=>{
        Author.findOne({_id: req.params.id})
        .then(author=>res.json(author))
        .catch(err=>res.status(400).json(err));
    },
    create:(req,res)=>{
        Author.create(req.body)
        .then(newAuthor=>res.json(newAuthor))
        .catch(creationErrors=>res.status(400).json(creationErrors));
    },
    update: (req,res)=>{
        Author.findOneAndUpdate({_id:req.params.id},req.body, {runValidators:true,new:true})
        .then(updatedAuthor=>res.json({author:updatedAuthor}))
        .catch(err=>res.json({message:"something went wrong", error:err}));
    },
    delete: (req,res)=>{
        Author.deleteOne({_id: req.params.id})
        .then(result=>res.json({result:result}))
        .catch(err=>res.json({message:"Something went wrong", error:err}));
    }
}