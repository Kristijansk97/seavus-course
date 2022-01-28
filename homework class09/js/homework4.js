$(document).ready(function(){
    let number = parseInt(prompt("Please enter first number!"));
    let number1 = parseInt(prompt("Please enter second number!"));
    let number2 = parseInt(prompt("Please enter thrid number!"));
    if (isNaN(number)){
        alert("Incorrect input!");}
    else { if (isNaN(number1)){
        alert("Incorrect input!");}
        else { if (isNaN(number2)){
            alert("Incorrect input!");}
             };
    };
     $("button").click(function(){
       var h1 = document.createElement("h1");
       $("body").before(h1);
       var result = (number + number1 + number2) / 3;
       $(h1).html(result);
       if (result >= 10){
           $(h1).css("color", "green");
       }
       else 
          $(h1).css("color", "red");
     });
});