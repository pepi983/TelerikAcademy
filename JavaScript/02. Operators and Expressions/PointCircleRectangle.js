function solve(args) {
    var x = +args[0];
    var y = +args[1];

    var isInCircle = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5;

    var isInRectangle = (y <= 1 && y >= -1) && (x >= -1 && x <=5);

    if(isInRectangle && isInCircle){
        console.log('inside circle inside rectangle');
    }
    else if(isInRectangle && !isInCircle){
        console.log('outside circle inside rectangle');
    }
    else if(!isInRectangle && isInCircle){
        console.log('inside circle outside rectangle');
    }
    else {
        console.log('outside circle outside rectangle');
    }
}

solve(['2.5', '2']);