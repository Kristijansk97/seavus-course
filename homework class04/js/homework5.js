function sum(){
    let numbers=[3,5,2,8,11];
    let max=0;
    let min= numbers[0];
    let sum=0;
    for (let i=0;i<numbers.length;i++) {
       if (numbers[i]>max)
        max=numbers[i];
        else if (numbers[i] < min)
        min=numbers[i];
        sum = max + min;
     }
     console.log("Maximum: " + max);
     console.log("Minimum: " + min);
     console.log("Sum: " + sum);
}

sum();