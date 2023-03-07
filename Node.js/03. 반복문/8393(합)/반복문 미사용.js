const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString();

let n = Number(input);

console.log((n * (n +1))/2);