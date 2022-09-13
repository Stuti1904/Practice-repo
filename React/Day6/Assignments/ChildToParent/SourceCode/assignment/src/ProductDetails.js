import React, { useState,useEffect} from 'react';
import ProductList from './ProductList';
function ProductReact(){
const [productName, setProductName] = useState(null);
  const [price, setPrice] = useState(0);
  const [quantity, setQuantity] = useState(0);
  const [total, setTotal] = useState(0);
  const [product, setProduct] = useState(null);

  useEffect(() => { setTotal((price * quantity) - ((price * quantity) * 0.05)) }, [price, quantity])
  console.log(total);

  const handleSubmit = () => {
    let productObj = { productName: productName, productPrice: price, productQuantity: quantity, productTotal: total }

    setProduct(productObj);

    setProductName('');
    setPrice(0);
    setQuantity(0);
    setTotal(0);
  }

  return (

    <div className="container mt-4">
      <div className="w-50 mx-auto">
        <div className="border p-4 rounded bg-light">
          <div className="row mt-3">
            <div className="col-md-4">Product Name :</div>
            <div className="col-md-8">
              <input
                className="form-control"
                type="text"
                name='productName'
                value={productName}
                onChange={(e) => setProductName(e.target.value)}
                placeholder="Product Name"
              />
            </div>
          </div>
          <div className="row mt-3">
            <div className="col-md-4">Price :</div>
            <div className="col-md-8">
              <input
                className="form-control"
                type="number"
                name='price'
                value={price}
                onChange={(e) => setPrice(e.target.value)}
                placeholder="Price"
              />
            </div>
          </div>
          <div className="row mt-3">
            <div className="col-md-4">Quantity :</div>
            <div className="col-md-8">
              <input
                className="form-control"
                type="number"
                name='quantity'
                value={quantity}
                onChange={(e) => setQuantity(e.target.value)}
                placeholder="Quantity"
              />
            </div>
          </div>

          <div className="row mt-3">
            <div className="col-md-4"></div>
            <div className="col-md-8">
              <button
                className="btn btn-outline-primary w-25"
                onClick={handleSubmit}
              >
                Buy
              </button>
            </div>
          </div>
          <div className="row mt-3 bg-light h6">
            <div className="col-md-4">payable amount :</div>
            <div className="col-md-8 text-secondary">Total amount is <span className="h4 text-success"> {total}</span></div>
          </div>
        </div>
      </div>

      <hr></hr>

      <ProductList product={product} />
    </div>
  )
}
export default ProductReact