/**
 * 윤년의 조건
 * 4의 배수이면서 100의 배수가 아닐 것
 * 혹은 400배의 배수일 것
 */

const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().trim();
const year = parseInt(input);

if( (year % 4 == 0) && (year % 100 != 0) ) {
    console.log('1');
} else if (year % 400 == 0) {
    console.log('1');
} else {
    console.log('0');
};