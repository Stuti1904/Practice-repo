import React, { useState,useEffect} from 'react';
  export default function ProductList({product}){
    const [productList,setProductList] = useState([]);
    
    useEffect(()=>{
        if(product!==null){
            setProductList([...productList,product])
        }
    },[product]);

    console.log(productList);
    return(
        <div>
            
            <div>
            <div class="border rounded w-75 mx-auto">
            <div class="bg-light ps-4 pb-2 h4 text-secondary">Product List :</div>
            <table class="table table-striped text-center">
                <caption>
                    
                </caption>
                <thead>
                    <th>Product name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Total (5% dis)</th>
                </thead>
                <tbody>
                    {productList.length>0 && productList.map( products => (
                    <tr>
                        <td>{products.productName}</td>
                        <td>{products.productPrice}</td>
                        <td>{products.productQuantity}</td>
                        <td>{products.productTotal}</td>
                    </tr>                    
                    ))}
                </tbody>
            </table>

      </div>
            </div>
        </div>
    )
}
