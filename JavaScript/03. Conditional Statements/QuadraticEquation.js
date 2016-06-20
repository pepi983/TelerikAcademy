function solve(args) {
    var a = +args[0],
    b = +args[1],
    c = +args[2];

    var d = b * b - 4 * a * c, 
    x1= 0,
    x2 = 0;
    

    if(d < 0){
        console.log('no real roots');
    }else if(d === 0){
        x1 = -b / (2 * a);
        console.log("x1=x2=" + x1.toFixed(2));
    }else{
        x1 = (-b + Math.sqrt(d)) / (a * 2);
        x2 = (-b - Math.sqrt(d)) / (a * 2);    

        if(x1 > x2){
            console.log('x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2));
        } else{
            console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
        }
    }
}

solve(['-0.5', '4', '-8']);