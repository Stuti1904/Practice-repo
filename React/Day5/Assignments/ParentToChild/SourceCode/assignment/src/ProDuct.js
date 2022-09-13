import React, { useState, useEffect } from 'react';
import ProductList from './ProductList';
function ProDuct() {
    let [product, setproduct]= useState([{name: '', price: 0, quantity:0, total:0}]);
    let [products, setproducts]= useState([]);
    const[total, setTotal]= useState(0);
    const handlechange =e=> {
        const key= e.target.key;
        const value= e.target.value;
         setproduct((prevState) => {
          return {...prevState, [key]: value}
           
       });
     };
     const enterproduct =(e) =>{
        e.preventDefault();
        setproducts([...products, product]);
        console.log(products);
      }
      useEffect(() => { setTotal(parseInt((product.price * product.quantity) - ((product.price * product.quantity) * 0.05)))}, [product.price, product.quantity])
  return (
    <div className="App">
    <label>Product Name</label><input type="text" name="name" value={product.name} onChange={handlechange}></input>
        <label>Porduct Price</label><input type="number" name="price" value={product.price} onChange={handlechange}></input>
        <label>Product quantity</label><input type="number" name="quantity" value={product.quantity} onChange={handlechange}></input>
<button type="button" onClick={enterproduct}>Add to cart</button>
<ProductList products={products} total={total}></ProductList>
    </div>
  );
}

export default ProDuct;
