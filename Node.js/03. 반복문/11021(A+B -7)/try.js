const fs = require('fs');
let input = fs.readFileSync('/dev/stdin').toString().trim().split('\n');

for(let i = 1; i <= input[0]; i++) {
    let AB = input[i].split(' ');

    console.log(`Case #${i}: ${Number(AB[0]) + Number(AB[1])}`);
}