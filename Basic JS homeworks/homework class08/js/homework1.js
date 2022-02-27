let animals = [];
function Animal(name, type, age){
  this.Name = name;
  this.Type = type;
  this.Age = age;
}

function showAnimals(animalssArr, element){
  element.innerHTML = "";
  for (let animals of animalssArr) {
    element.innerHTML += `<li><b>Name:</b> ${animals.Name}, <b>Type:</b> ${animals.Type}, 
    <b>Age:</b> ${animals.Age}</li>`;
  }
}
let animalsForm = document.getElementById("animalsForm");
let result = document.getElementById("result");

animalsForm.getElementsByTagName("button")[0].addEventListener("click", function(){
  let name = animalsForm.children[0].value;
  let type = animalsForm.children[1].value;
  let age = animalsForm.children[2].value;
  let newAnimal = new Animal(name, type, age);
  animals.push(newAnimal);
  showAnimals(animals, result.getElementsByTagName("ul")[0]);
  animalsForm.children[0].value = "";
  animalsForm.children[1].value = "";
  animalsForm.children[2].value = "";
});