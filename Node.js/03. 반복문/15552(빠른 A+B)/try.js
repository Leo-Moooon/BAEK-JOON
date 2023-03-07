const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n');

const T = Number(input[0]);
let AB = 0;
let sum = '';

for(let i = 1; i < T+1; i++) {
    AB = input[i].split(' ');
    sum += parseInt(AB[0]) + parseInt(AB[1]) + '\n';
};

console.log(sum);
