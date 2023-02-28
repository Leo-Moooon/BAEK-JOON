const rl = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout,
});

let input = [];

rl.on("line", (line) => {
    input = line;
}).on("close", () => {
    console.log(`${input}??!`);
    process.exit;
})