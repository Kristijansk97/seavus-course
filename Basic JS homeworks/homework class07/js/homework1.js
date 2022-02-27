let animal = {
    name: "Black Panther",
    kind: "Leopard",
    speak: function(){
        let word = prompt(" ");
        document.write("The  " + this.name + " says: " + word);
    }
}
animal.speak();