const input = require('fs').readFileSync('dev/stdin').toString().split(' ').map(el => parseInt(el));
console.log(input[0] + input[1] + input[2]);