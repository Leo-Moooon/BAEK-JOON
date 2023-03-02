const fs = require('fs');
const input = fs.readFileSync('dev/stdin').toString().split(' ').map(Number);

const [a, b, c] = [input[0], input[1], input[2]];

const reward = (a, b ,c) => {
    // 3개 모두 동일한 눈금
    if(a == b && b == c && c == a) return console.log(10000 + (a * 1000));

    // 2개만 동일한 눈금
    // 하나는 다르고
    if(a != b || b != c || c != a) {
        // 둘은 같을 때
        if(a == b || a == c) return console.log(1000 + (a*100));
        if(b == c) return console.log(1000 + (b*100));
    }

    // 모두 다른 눈금
    if(a != b && b != c && c != a) {
        const sort = [a, b, c].sort(); // 오름차순 정렬
        return console.log(sort.pop() * 100);
    }
};

reward(a, b ,c);