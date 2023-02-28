const rl = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout,
});

let input = [];

rl.on("line", (line) => {
    input = line.split(' ').map(el => parseInt(el));
}).on("close", () => {
    console.log(input[0]/input[1]);
    process.exit();
})