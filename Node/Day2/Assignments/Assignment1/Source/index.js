let result;
function addition(a, b) {
  return parseInt(a) + parseInt(b);
}
function subtract(a, b) {
  return parseInt(a) - parseInt(b);
}
function multiply(a, b) {
  return parseInt(a) * parseInt(b);
}
function divide(a, b) {
  return parseInt(a) / parseInt(b);
}

var num = process.argv;
console.log("TYPE add FOR ADDITION, sub FOR SUBTRACTION, mul FOR MULTIPLICATION, div FOR DIVISION")
switch (num[2]) {
  case 'add':
    result = addition(num[3], num[4]);
    break;
  case 'sub':
    result = subtract(num[3], num[4]);
    break;
  case 'div':
    result = divide(num[3], num[4]);
    break;
  case 'mul':
    result = multiply(num[3], num[4]);
    break;
  default:
    console.log('Error');
}
const content = result.toString();
var fs = require('fs');

fs.writeFile('./Answer.txt', content, 'utf8', (err) => {
  if (err) throw err;
  console.log('File saved');
  fs.readFile('./Answer.txt', 'utf8', (error, d) => {
    if (error) {
      console.error(error);
    } else {
      console.log(d);
    }
  });
});

