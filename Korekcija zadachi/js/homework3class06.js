// function recipePage() {
//     let recipe = prompt('Enter the name of the recipe:');

//     let title = document.createElement('h2');
//     title.innerHTML = recipe;
//     document.body.appendChild(title);

//     let number = prompt("Enter the number of ingredients: ");

//     var arr = [];
//     for(let i = 0; i < number; i++){
//    arr.push(prompt("Enter the name of the ingredients: "));}
//    var ul = document.createElement("ul");
//    document.body.appendChild(ul);
//       for (let i = 0; i < arr.length; i++) {
//    var li = document.createElement("li");
//    li.innerHTML=arr[i];
//    ul.appendChild(li);
//    }
// }
// document.body.addEventListener('load', recipePage());

function addTable() {
 var myTableDiv = document.getElementById("myDynamicTable");
   
 var table = document.createElement('TABLE');
 table.border='1';
 
 var tableBody = document.createElement('TBODY');
 table.appendChild(tableBody);

 let recipe = prompt('Enter the name of the recipe:');
 var th = document.createElement('THEAD');
 th.appendChild(document.createTextNode(recipe));
 tableBody.appendChild(th);
 
 let number = prompt("Enter number of ingredients: ");
 for (var i=0; i < number; i++){
    var tr = document.createElement('TR');
    tableBody.appendChild(tr);
 let name = prompt("Enter name of ingredients: ");   
 var td = document.createElement('TD');
        td.width='75';
        td.appendChild(document.createTextNode(name));
        tableBody.appendChild(td);
    
 }
 myTableDiv.appendChild(table);
 
}
