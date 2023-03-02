const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().trim();

const num = Number(input);
let answer = "";

for(let i = 0; i < num/4; i++) {
 answer += 'long ';
};

console.log(`${answer}int`);