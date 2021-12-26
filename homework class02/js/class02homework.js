//homework part1
let myName = prompt("Enter your name:");
let greetings = `Hello, i am ${myName}`;
console.log(greetings);

//homework part2
let myYear = prompt("Enter your year:");
let ChineseZodiac = (myYear - 4)%12;
if(ChineseZodiac == 0){
    console.log("Rat");
} else if(ChineseZodiac == 1){
    console.log("Ox");
} else if(ChineseZodiac == 2){
    console.log("Tiger");
} else if(ChineseZodiac == 3){
    console.log("Rabbit");
} else if(ChineseZodiac == 4){
    console.log("Dragon");
} else if(ChineseZodiac == 5){
    console.log("Snake");
} else if(ChineseZodiac == 6){
    console.log("Horse");
} else if(ChineseZodiac == 7){
    console.log("Goat");
} else if(ChineseZodiac == 8){
    console.log("Monkey");
} else if(ChineseZodiac == 9){
    console.log("Rooster");
} else if(ChineseZodiac == 10){
    console.log("Dog");
} else if(ChineseZodiac == 11){
    console.log("Pig");
}

//homework part3
let myNumber = prompt("Enter your number:");
let myNumber1 = prompt("Enter your number:");
let myNumber2 = prompt("Enter your number:");
let myNumber3 = prompt("Enter your number:");
let myNumber4 = prompt("Enter your number:");
let num = parseInt(myNumber);
let num1 = parseInt(myNumber1);
let num2 = parseInt(myNumber2);
let num3 = parseInt(myNumber3);
let num4 = parseInt(myNumber4);
if (num > num1 && num > num2 && num > num3 && num > num4){
    alert("Maximum number is:" + " " + num);
} else if (num1 > num && num1 > num2 && num1 > num3 && num1 > num4){
    alert("Maximum number is:" + " " + num1);
} else if (num2 > num && num2 > num1 && num2 > num3 && num2 > num4){
    alert("Maximum number is:" + " " + num2);
} else if (num3 > num && num3 > num1 && num3 > num2 && num3 > num4){
    alert("Maximum number is:" + " " + num3);
} else if (num4 > num && num4 > num1 && num4 > num2 && num4 > num3){
    alert("Maximum number is:" + " " + num4);
}

