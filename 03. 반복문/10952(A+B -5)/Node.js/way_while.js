const input = require('fs').readFileSync('/dev/stdin').toString().trim().split('\n');
let i = 0;

while(true) {
    let A = Number(input[i].split(' ')[0]);
    let B = Number(input[i].split(' ')[1]);
    
    if(A == 0 && B == 0){
        break;
    }
    console.log(A+B);
    i++;
}