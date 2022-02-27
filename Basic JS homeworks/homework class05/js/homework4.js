const array=[2,5,6,1,7,9,4]
function findNumber(numbers, type){
    let output = [];
if(type === 'odd'){
    for(let i = 0; i < numbers.length; i++){
        if(numbers[i] % 2 != 0){
            output.push(numbers[i]);
        }
    }
    return "Odd numbers are: " + output;
}
    else if(type === 'even'){
        for(let i = 0; i < numbers.length; i++){
        if(numbers[i] % 2 === 0){
            output.push(numbers[i]);
        }
    }
    return "Even numbers are: " + output;
}
}

console.log(findNumber(array, 'odd'));
console.log(findNumber(array, 'even'));


// second solution
// const array=[2,5,6,1,7,9,4]
// function findNumber(numbers,type){
//     let output=[];
//     for(let i=0; i <= numbers.length; i++){
//         if (numbers[i]%2 == 0 && type == "even"){
//             output.push(numbers[i]);
//         }
//         else if (numbers[i]%2 != 0 && type == "odd"){
//             output.push(numbers[i]);
//         }
//     }
//     console.log(`${type == "even"? "Even":"Odd"} numbers are: ${output}`);
// }
// findNumber(array,"odd");
// findNumber(array,"even");