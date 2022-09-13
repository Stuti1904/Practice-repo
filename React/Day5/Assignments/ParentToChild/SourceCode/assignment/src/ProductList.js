import React from 'react';
export default function ProductList(props){
    return(
        <div>
    <table>
        <thead>
            <tr>
            <th>Name</th>
            <th>Price</th>
            <th>quantity</th>
            <th> Final Price</th>
            </tr>
            </thead>
        {props.products.map((pro)=>(
            <tbody>
            <tr>
        <td>{pro.name}</td>
        <td>{pro.price}</td>
        <td>{pro.quantity}</td>
        {/* <td>{props.total}</td> */}
        </tr>
        </tbody>
        ))}
    </table>
    </div>
        );
}