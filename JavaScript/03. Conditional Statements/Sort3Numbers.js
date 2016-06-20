function solve(args) {
    var a = +args[0],
    b = +args[1],
    c = +args[2];

    if(a >= b && b >= c){
        console.log(a + " " + b + " " + c);
    }
    else if(a >= c && b <= c){
        console.log(a + " " + c + " " + b);
    }
    else if(a <= b && a >= c){
        console.log(b + ' ' + a + ' ' + c);
    }
    else if(c <= b && a <= c){
        console.log(b + ' ' + c + ' ' + a);
    }
    else if(c >= a && a >= b){
        console.log(c + ' ' + a + ' ' + b);
    }
    else if(c >= b && b >= a){
        console.log(c + ' ' + b + ' ' + a);
    }
}