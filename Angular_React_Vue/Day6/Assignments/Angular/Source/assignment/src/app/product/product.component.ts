import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
   products:any=[];
  product= {
    name:" " ,
    price: 0,
    quantity: 0,
  };
  check(){
    var tempprice= this.product.price*this.product.quantity;
    var finalprice= tempprice- (0.5*tempprice);
    var tempobj={prdname:this.product.name, prdquan: this.product.quantity, prdprice: this.product.price, final:finalprice}
  this.products.push(tempobj);
  this.product.name=" ";
  this.product.price=0;
  this.product.quantity=0;
  finalprice=0;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
