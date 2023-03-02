const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString();

let n = Number(input);
let arr = [];
let total = 0;
for(i = 1; i <= n; i++) {
 arr.push(i);
 total = arr.reduce((accumulator, currentNumber) => accumulator + currentNumber);
}

console.log(total);

