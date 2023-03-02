const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n');

const totalPrice = Number(input[0]);
const productNum = Number(input[1]);

let priceAndQuantity = 0;
let productPrice = 0;
let productQuantity = 0;
let arr = [];

for(i = 2; i< productNum; i++) {
    priceAndQuantity = input[i].toString().split(' ');
    productPrice = Number(priceAndQuantity);
    productQuantity = Number(priceAndQuantity);

    arr.push(productPrice * productQuantity);
}

let myTotal = arr.reduce((a, b) => a + b);

(myTotal == totalPrice) ? console.log('Yes') : console.log('No');