var arr: number[]=[1,2,3,4,5];
for (var index in arr){
    console.log(arr[index]);
}
var arr1 :number[]=[6,7,8,9];
var arr2: number[]= arr1.concat(arr);
console.log(arr2);