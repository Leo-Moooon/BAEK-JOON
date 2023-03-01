/**
 * 접근 방식
 * 시간을 분으로 환산하여 계산은 분 단위로 한다.
 * 
 * 계산이 끝나면 다시 시간 : 분으로 나눈다.
 * 2884(알람시계)와 동일한 로직으로 예상.
 * 
 * 관건: 공백과 줄바꿈은 어떻게 처리할 것인가
 *  - 일단 줄 단위로 나누고, 시간과 분은 나중에 따로 나눠보자.
 */

const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split('\n');

const H = parseInt(input[0].split(' ')[0]);
const M = parseInt(input[0].split(' ')[1]);
const cook = parseInt(input[1]);

let resultH = Math.floor((H * 60 + M + cook) / 60);
let resultM = (H * 60 + M + cook)%60;
if(resultH >= 24) {
    resultH -= 24;
}
console.log(`${resultH} ${resultM}`);