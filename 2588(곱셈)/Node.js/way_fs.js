const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n').map(el => parseInt(el));

const num1 = input[0];
const num2 = input[1];
    const num2_1 = num2%10;
    const num2_10 = parseInt((num2%100)/10); 
    const num2_100 = parseInt(num2/100);

console.log(num1 * num2_1);
console.log(num1 * num2_10);
console.log(num1 * num2_100);
console.log(num1 * num2);