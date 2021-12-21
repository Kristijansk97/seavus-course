var myRadius = parseFloat(prompt("Enter the radius of your circle in cm:"));
MyArea(myRadius);

function calculateArea(myRadius) {
    return (Math.pow(myRadius,2) * Math.PI);
  }

function MyArea() {
    var area = calculateArea(myRadius); 
    console.log(("The area of the circle is:"),area);
  }
