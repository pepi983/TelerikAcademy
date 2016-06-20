function solve(args) {
    var a = +args[0],
    b = +args[1],
    c = +args[2],
    d = +args[3],
    e = +args[4];

    var max = a;

    if(b > max){
        max = b;
    }

    if(c > max){
        max = c;
    }

    if (d > max) {
        max = d;
    }

    if (e > max) {
        max = e;
    }

    console.log(max);
}

solve(['5', '2', '2', '4', '1']);