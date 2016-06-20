function solve(args) {
    var max = +args[0],
    min = +args[0],
    sum = 0,
    average,
    i = 0,
    length = args.length;

    while(i < length) {
        if(+args[i] > max){
            max = +args[i];
        }

        if(+args[i] < min){
            min = +args[i];
        }

        sum += +args[i];
        i += 1;
    }

    average = sum / length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + average.toFixed(2));
}

solve(['2', '5', '1']);