function solve(args) {
    var a = +args[0];

    var bit = (a >> 3) & 1;

    console.log(bit);
}

solve(['1024']);