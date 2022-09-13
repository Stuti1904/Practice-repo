const mongoose= require('mongoose');
const productschema = new mongoose.Schema({
    productName: {type : String, required: true, trim:true, uppercase: true},
    productPrice: {type: Number, required: true, trim:true},
    categoryID:{
        type: mongoose.Schema.Types.ObjectId,
        ref: "category",
        required: true,
        trim: true,
    }
});
const ProductModel= mongoose.model("product", productschema);
module.exports= ProductModel;