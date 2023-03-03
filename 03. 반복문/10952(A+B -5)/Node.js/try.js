const input = require('fs').readFileSync('/dev/stdin').toString().trim().split('\n');

for(let i = 0; i < input.length; i++) {
    let A = Number(input[i].split(' ')[0]);
    let B = Number(input[i].split(' ')[1]);

    if(A+B == 0) {
        break;
    }else { console.log(A+B);
    }
}