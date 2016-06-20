function solve(args) {
    var a = +args[0];
    
    var digit = ((a / 100) % 10 ) | 0;
    
    if (digit === 7) {
        console.log('true');
    }
    else{
        console.log('false ' + digit);
    }
}

solve(['777777']);