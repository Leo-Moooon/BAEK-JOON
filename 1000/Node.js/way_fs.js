const fs = require('fs');
let input = fs.readFileSync('/dev/stdin').toString().trim().split(' ');

let A = Number(input[0]);
let B = Number(input[1]);

console.log(A+B);