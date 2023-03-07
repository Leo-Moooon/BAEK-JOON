/**
 * 접근 방식
 * split을 줄단위, 공백단위로 2번 시행해서 분리.
 * 테스트 케이스 개수인 T를 반복문 시행 횟수로 연결
 */

const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n');

const T = Number(input[0]);

for( let i = 1; i <= T; i++ ) {
    let testCase = input[i].toString().split(' ');
    let A = parseInt(testCase[0]);
    let B = parseInt(testCase[1]);
    console.log(A + B);
};
