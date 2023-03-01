/**
 * 1시간 = 60분으로 치환하여 계산한 뒤 몫과 나머지로 분리해보자.
 */

const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split(' ');

const H = parseInt(input[0]);
const M = parseInt(input[1]);
const time = H * 60 + M;

let alarmTime = time - 45;
let alarmH = parseInt(alarmTime/60);
let alarmM = alarmTime%60;

console.log(`${alarmH} ${alarmM}`);