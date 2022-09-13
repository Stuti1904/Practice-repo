function identity<Type>(arg:Type):any{
    return arg;
}
let myvariable=identity<string>("stuti");
console.log(myvariable);