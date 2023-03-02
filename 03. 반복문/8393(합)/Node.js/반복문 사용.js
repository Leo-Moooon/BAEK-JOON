const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString();

let n = Number(input);
let total = 0;
for(i = 1; i <= n; i++) {
 total += i;
}

console.log(total);

