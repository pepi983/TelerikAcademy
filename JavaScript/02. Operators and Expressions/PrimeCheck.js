function solve(args) {

    var number = +args[0];
    if(number < 2)
    {
        console.log('false');
        return;
    }
    if(number === 2)
    {
        console.log('true');
        return;
    }

    var a = Math.floor(Math.sqrt(number));

    for(var i = 2; i <= a; i += 1) {
        if(number % i === 0)
        {
            console.log('false');
            return;
        }
    }

    console.log('true');
}

solve(['23']);