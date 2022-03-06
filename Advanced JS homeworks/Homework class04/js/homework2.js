let names = ["Kristijan", "David", "Bojan", "Anastas", "Marko"];
let surnames = ["Markovski", "Davidovski", "Trpcevski", "Simonovski", "Mandzukovski"];

for (let i = 0; i < names.length; i++){
    (() => {
        console.log(`${names[i]} ${surnames[i]}`);
    })(); 
};