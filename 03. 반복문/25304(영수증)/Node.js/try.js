const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n');

const billTotal = Number(input[0]);
const billQuan = Number(input[1]);

let productPrice = 0;
let productQuan = 0;
let sum = 0;

for(let i = 2; i < billQuan; i++) {
    productPrice = Number((input[i].toString().split(' '))[0]);
    productQuan = Number((input[i].toString().split(' '))[1]);
    sum += productPrice * productQuan;
}

(billTotal == sum) ? console.log('Yes') : console.log('No');