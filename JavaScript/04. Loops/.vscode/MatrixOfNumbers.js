function solve(args) {
    var n = +args[0],
    i = 1,
    counter = 0,
    output = '',
    br = 0;

    while (true) {

        counter += 1;
        if(counter === n)
        {   output += i;
            i += 1;
            console.log(output);
            output = '';
            counter = 0;
            br += 1;
            i = br + 1;

            if (br === n) {
                break;
            }
        }
        else{
            output += i + ' ';
            i += 1;
        }
    }
}