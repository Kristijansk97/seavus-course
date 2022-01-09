function numbersSum(){
    const numbers=[2,5,1,7,6];
    let sum=0;
    for (let i=0; i < numbers.length; i++) {
        sum += numbers[i];}
    console.log(sum);
}
numbersSum();

function validateNumber(){
    const numbers=['Proba',5,1,7,6];
    for (let i=0; i < numbers.length; i++) {
        if (isNaN(numbers[i]))
        return console.log("Error");
        else 
        console.log(numbers[i]);    
    }
}

validateNumber();