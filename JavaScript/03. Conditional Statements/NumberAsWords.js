function solve(args) {
    var number = args[0] + "";

    var toString = "",
    indexOfSmall,
    indexOfBig;

    if(+number < 10){
        indexOfSmall = 0;
    }
    else if(+number < 100){
        indexOfSmall = 1;
        indexOfBig = 0;
    }
    else{
        indexOfSmall = 2;
        indexOfBig = 1;
    }

    switch(number[indexOfSmall]){
            case '0': toString = 'Zero'; break;
            case '1': toString = 'One'; break;
            case '2': toString = 'Two'; break;
            case '3': toString = 'Three'; break;
            case '4': toString = 'Four'; break;
            case '5': toString = 'Five'; break;
            case '6': toString = 'Six'; break;
            case '7': toString = 'Seven'; break;
            case '8': toString = 'Eight'; break;
            case '9': toString = 'Nine'; break;
        }

        if(number % 100 >= 10 && number % 100 <= 19){
            switch(number[indexOfSmall]){
            case '0': toString = 'Ten'; break;
            case '1': toString = 'Eleven'; break;
            case '2': toString = 'Twelve'; break;
            case '3': toString = 'Thirteen'; break;
            case '4': toString = 'Fourteen'; break;
            case '5': toString = 'Fifteen'; break;
            case '6': toString = 'Sixteen'; break;
            case '7': toString = 'Seventeen'; break;
            case '8': toString = 'Eighteen'; break;
            case '9': toString = 'Nineteen'; break;
        }
        }

        if(number >= 20){
            toString = toString.toLocaleLowerCase();
            
            if (toString === 'zero') {
                toString = '';
            }

            switch(number[indexOfBig]){
            case '2': toString = 'Twenty' + ' ' + toString; break;
            case '3': toString = 'Thirty' + ' ' + toString; break;
            case '4': toString = 'Forty' + ' ' + toString; break;
            case '5': toString = 'Fifty' + ' ' + toString; break;
            case '6': toString = 'Sixty' + ' ' + toString; break;
            case '7': toString = 'Seventy' + ' ' + toString; break;
            case '8': toString = 'Eighty' + ' ' + toString; break;
            case '9': toString = 'Ninety' + ' ' + toString; break;
        }
        }

        if(number >= 100){
            toString = toString.toLocaleLowerCase();
            
            if(toString === ''){
                toString = ' hundred';
            }
            else{
                toString = ' hundred and ' + toString;
            }

             switch(number[0]){
            case '1': toString = 'One' + toString; break;
            case '2': toString = 'Two' + toString; break;
            case '3': toString = 'Three' + toString; break;
            case '4': toString = 'Four' + toString; break;
            case '5': toString = 'Five' + toString; break;
            case '6': toString = 'Six' + toString; break;
            case '7': toString = 'Seven' + toString; break;
            case '8': toString = 'Eight' + toString; break;
            case '9': toString = 'Nine' + toString; break;
        }
        }

        console.log(toString);
}

solve(['273']);
solve(['100']);
solve(['99']);
solve(['90']);
solve(['15']);
solve(['3']);