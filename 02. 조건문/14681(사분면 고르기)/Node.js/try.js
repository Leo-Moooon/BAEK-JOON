/**
 * readFileSync(0) : 표준 파일 설명자 값(standard input)이 0이기 때문.
 * readFileSync('dev/stdin') : 별도의 파일로 입력받는 경우
 *  - 이 문제의 경우 해당 경로에 파일이 없던가, 권한 설정이 안된 경우라고 한다.
 */

const fs = require('fs');
const input = fs.readFileSync(0).toString().split('\n');

const x = parseInt(input[0]);
const y = parseInt(input[1]);

if( x > 0 && y > 0 ) {
    console.log(`1`);
} else if( x < 0 && y > 0 ) {
    console.log(`2`);
} else if( x < 0 && y < 0 ) {
    console.log(`3`);
} else if( x > 0 && y < 0 ) {
    console.log(`4`);
};