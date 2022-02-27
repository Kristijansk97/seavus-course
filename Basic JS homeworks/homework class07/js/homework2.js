let Book = {
    title: prompt("Enter name of book:"),
    author: prompt("Enter the author"),
    readingStatus: parseInt(prompt("Select a choice 1. Yes 2. No")),
    action: function(){
        if(this.readingStatus == 1){
            document.write("Already read " + this.title + " by " + this.author);
        } else {
            document.write("You still need to read " + this.title + " by " + this.author);
        }
        }
}
Book.action();