// predhodno reshenie
// let Book = {
//     title: prompt("Enter name of book:"),
//     author: prompt("Enter the author"),
//     readingStatus: parseInt(prompt("Select a choice 1. Yes 2. No")),
//     action: function(){
//         if(this.readingStatus == 1){
//             document.write("Already read " + this.title + " by " + this.author);
//         } else {
//             document.write("You still need to read " + this.title + " by " + this.author);
//         }
//         }
// }
// Book.action();

// novo reshenie
let library = [ 
    {
        title: "The Robots of dawn",
        author: "Isaac Asimov",
        readingStatus: true
    },
    {
        title: 'Mockingjay: The Final Book of The Hunger Games',
        author: 'Suzanne Collins',
        readingStatus: false
    }];

for (let i = 0; i < library.length; i++) 
   {
    var book = "'" + library[i].title + "'" + ' by ' + library[i].author + ".";
    if (library[i].readingStatus) {
      console.log("Already read " + book);
    } else
    {
     console.log("You still need to read " + book);
    };
   };