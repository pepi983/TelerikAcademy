function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var h = +args[2];

    var area = ((a + b) / 2) * h;
    
    console.log(area.toFixed(7));
}

solve(['8.5', '4.3', '2.7']);