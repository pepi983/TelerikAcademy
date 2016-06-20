function solve(args) {
    var a = +args[0];
    var b = +args[1];

    var area = a * b;
    var perimeter = 2 * a + 2 * b;

    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

solve(['2.5', '3']);