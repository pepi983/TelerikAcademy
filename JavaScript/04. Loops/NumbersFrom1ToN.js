function solve(args) {
    var number = +args[0],
    output = '1';
    
    for(var i = 2; i <= number; i += 1) {
        output += ' ' + i;
    }

    console.log(output);
}