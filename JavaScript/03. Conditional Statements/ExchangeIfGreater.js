function solve(args) {
    var a = +args[0],
    b = + args[1],
    c;

    if (a > b) {
        c = b;
        b = a;
        a = c;
    }

    console.log(a + ' ' + b);
}