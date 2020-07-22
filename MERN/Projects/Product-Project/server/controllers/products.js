const mongoose=require('mongoose');
const Product=mongoose.model('Product');

module.exports={
    index: (req,res)=>{
        Product.find()
        .then((products)=>{
            console.log ("we are in products.find");
            console.log(products);
            res.json(products)
        })
        .catch(err=>{
            console.log(err);
            res.status(400).json(err)
        });
    },
    getOne:(req,res)=>{
        Product.findOne({_id: req.params.id})
        .then(product=>res.json(product))
        .catch(err=>res.status(400).json(err));
    },
    create:(req,res)=>{
        Product.create(req.body)
        .then(newProduct=>res.json(newProduct))
        .catch(creationErrors=>res.status(400).json(creationErrors));
    },
    update: (req,res)=>{
        Product.findOneAndUpdate({_id:req.params.id},req.body, {runValidators:true,new:true})
        .then(updatedProduct=>res.json({product:updatedProduct}))
        .catch(err=>res.json({message:"something went wrong", error:err}));
    },
    delete: (req,res)=>{
        Product.deleteOne({_id: req.params.id})
        .then(result=>res.json({result:result}))
        .catch(err=>res.json({message:"Something went wrong", error:err}));
    }
}