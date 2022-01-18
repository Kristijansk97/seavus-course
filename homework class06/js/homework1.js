const array = [2, 4, 2, 6, 5]
var sum = 0;
var ul = document.createElement("ul");
document.body.appendChild(ul);
for (let i = 0; i < array.length; i++) {
    var li = document.createElement("li");
    li.innerHTML=array[i];
    ul.appendChild(li);
    sum += array[i];
}
var suma = document.createElement("p");
suma.innerHTML = sum;
li.appendChild(suma);


