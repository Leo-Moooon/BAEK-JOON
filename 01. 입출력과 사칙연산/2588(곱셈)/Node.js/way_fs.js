const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n');

const num1 = parseInt(input[0]);
const num2 = parseInt(input[1]);
    const num2_1 = parseInt(input[1].charAt(2));
    const num2_10 = parseInt(input[1].charAt(1));
    const num2_100 = parseInt(input[1].charAt(0));

    console.log(num1 * num2_1);
    console.log(num1 * num2_10);
    console.log(num1 * num2_100);
    console.log(num1 * num2);