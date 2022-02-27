let animal = {
    name: prompt("Enter name: "),
    kind: prompt("Enter kind:"),
    speak: function(greeting){
        greeting = " says hello!!!";
        document.write(animal.name + greeting);
    }
}
animal.speak(animal.greeting);