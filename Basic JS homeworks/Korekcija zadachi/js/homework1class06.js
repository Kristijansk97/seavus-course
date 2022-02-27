const array = [2, 4, 2, 6, 5]
var equation = [" "];
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
var suma1 = document.createElement("p");
suma1.innerHTML = (`${array[0]} + ${array[1]} + ${array[2]} + ${array[3]} + ${array[4]} = ${sum}`);
li.appendChild(suma1);



