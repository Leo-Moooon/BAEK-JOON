const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().trim().split('\n');

const billTotal = Number(input[0]);
const billQuan = Number(input[1]);
let sum = 0;

for(let i = 2; i <= billQuan+1; ++i) {
    let arr = input[i].split(' ').map(el => Number(el));
    sum += arr[0] * arr[1];
};

console.log(billTotal == sum ? 'Yes' : 'No');