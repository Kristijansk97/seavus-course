function recipePage() {
    let recipe = prompt('Enter the name of the recipe:');

    let title = document.createElement('h2');
    title.innerHTML = recipe;
    document.body.appendChild(title);

    let number = prompt("Enter the number of ingredients: ");

    var arr = [];
    for(let i = 0; i < number; i++){
   arr.push(prompt("Enter the name of the ingredients: "));}
   var ul = document.createElement("ul");
   document.body.appendChild(ul);
      for (let i = 0; i < arr.length; i++) {
   var li = document.createElement("li");
   li.innerHTML=arr[i];
   ul.appendChild(li);
   }
}
document.body.addEventListener('load', recipePage());

