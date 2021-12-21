var price = parseFloat(prompt("Enter the price of the phone:"));
myPrice(price);

function calculatePrice(price) {
       return (price * 30)
  }

function myPrice() {
    var newPrice = calculatePrice(price); 
    console.log(("Price is:"),newPrice);
  }

var tax = parseFloat(prompt("Enter the tax:"));
  myTax(tax);
  
  function calculateTax(tax) {
         return (price * 30 * tax)
    }
  
  function myTax() {
      var newTax = calculateTax(tax); 
      console.log(("Tax is:"),newTax);
  }
