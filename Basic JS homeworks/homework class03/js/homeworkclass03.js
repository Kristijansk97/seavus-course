//homework part1
let myYear = prompt("Enter your year:");
let ChineseZodiac = (myYear - 4) % 12;
switch(ChineseZodiac){
    case 0: 
       console.log("Rat");
       break;

    case 1: 
       console.log("Ox");
       break;
      
    case 2: 
       console.log("Tiger");
       break;
    case 3: 
       console.log("Rabbit");
       break;
    
    case 4: 
       console.log("Dragon");
       break;
       
    case 5: 
       console.log("Snake");
       break;
       
    case 6: 
       console.log("Horse");
       break;
       
    case 7: 
       console.log("Goat");
       break;
       
    case 8: 
       console.log("Monkey");
       break;
       
    case 9: 
       console.log("Rooster");
       break;
       
    case 10: 
       console.log("Dog");
       break;
       
    case 11: 
       console.log("Pig");
       break;
}

//homework part2
     function parameters(a,b,c){
      console.log(typeof a);
      console.log(typeof b);
      console.log(typeof c);
}

parameters('Fiat','Ford','Seat');

     function parameters1(d,e,f){   
      console.log(typeof d);
      console.log(typeof e);
      console.log(typeof f);
}

parameters1((10>5),(5*2==6),(2==1));
   
      function parameters2(a1,b1,c1){
         console.log(typeof a1);
         console.log(typeof b1);
         console.log(typeof c1);
}

parameters2(18,10,25);


      function parameters3(d1,e1,f1){
         console.log(typeof d1);
         console.log(typeof e1);
         console.log(typeof f1);
}

parameters3(null,null,null);

       function parameters4(h,i,j){
         console.log(typeof h);
         console.log(typeof i);
         console.log(typeof j);
}

parameters4();

//homework part3
var humanYears =parseInt(prompt("Enter human years:"));
dogYears(humanYears);
function convertDogYears(humanYears){
    return (humanYears * 7);
}
function dogYears(){
    var NN = convertDogYears(humanYears);
    console.log(("The age of your dog is:"),NN);
}


//bonus1 part3
var dogYears1 = parseInt(prompt("Enter dog years:"));
humanYears1(dogYears1);
function convertHumanYears(dogYears){
    return (dogYears / 7);
}
function humanYears1(){
    var NN = convertHumanYears(dogYears1);
    console.log(("The age of the human is:"),NN);
}

//homework part4
function Team(a,b) {
   if (a < 10) {
   console.log("There are 0"+ a + " girls in the team and there are " + b + " boys in team.");
}  else if (b < 10) {
   console.log("There are " + a + " girls in the team and there are 0" + b + " boys in the team.")
}  else if (a >= 10 && b >= 10 ) {
   console.log("There are "+ a + " girls in the team and there are " + b + " boys in team.");
    }
}

Team(10,15);
Team(5,20);
Team(15,8);

//homework part5
var birthYear = parseInt(prompt("Enter your birth year:"));
var currentYear =parseInt(prompt("Enter current year:"));
age(birthYear);
function calculateAge(birthYear){
    return (currentYear - birthYear);
}
function age(){
    var myAge = calculateAge(birthYear);
    console.log(("You are " + myAge + " years old."));
}

//homework part5 bonus
var birthYear = parseInt(prompt("Enter your birth year:"));
var currentYear = new Date().getFullYear();
age(birthYear);
function calculateAge(birthYear){
    return (currentYear - birthYear);
}
function age(){
    var myAge = calculateAge(birthYear);
    console.log(("You are " + myAge + " years old."));
}


//homework part6
var balance = 500.0;

	function get_balance() {
		alert("Your current balance is: "+balance);
		atm();
	}

	function make_withdrawal() {
		var withdrawal = parseFloat(prompt("How much would you like to withdraw?"));
		if (isNaN(withdrawal) || withdrawal === "") {
			alert("Error: please enter a number!");
			make_withdrawal();
		} else if (balance < withdrawal){
         alert("Not enough money!");
         make_withdrawal();
      } else if (withdrawal <= balance){
         alert("Successful withdrawal!");
      }
		}

	function exit() {
		var confirm_leave = confirm("You have selected exit.");
		if (confirm_leave) {
			window.close();
		} else {
			atm();
		}
	}

	function atm() {

		var choice = parseInt(prompt("Select a choice 1.) Balance  2.) Withdrawal 3.) Exit"));

		if (choice === 1) {
			get_balance();
		} else if (choice === 2) {
			make_withdrawal();
		} else if (choice === 3) {
			exit();
		} else {
			error();
		}
	}

	atm();
