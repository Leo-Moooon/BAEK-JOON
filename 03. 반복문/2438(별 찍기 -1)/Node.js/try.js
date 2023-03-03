const input = require('fs').readFileSync('/dev/stdin').toString().trim();
const num = Number(input);
let star = [];

for (let i = 0; i < num; i++) {
    star += '*';
    console.log(star);
}