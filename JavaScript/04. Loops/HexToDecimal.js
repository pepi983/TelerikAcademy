function solve(args) {
    var hexNumber = args[0],
    decValue = 0;

    for(var i = 0; i < hexNumber.length; i += 1) {
       if(isNaN(hexNumber[i])){
           decValue = hexNumber[i].charCodeAt(0) - 55 + decValue * 16;
       } 
       else{
           decValue = +hexNumber[i] + decValue * 16;
       }
    }

    console.log(decValue);
}

solve(['FE']);

//  function solve(args) {
//   var input = String(args);

//   var hexKey = '0123456789ABCDEF';
//   var sum = 0;

//   var len = input.length;
//   for (var i = 0; i < len; i += 1) {
//     var digit = hexKey.indexOf(input[i]);

//     sum = digit + sum * 16;
//   }

//   console.log(sum);
// }