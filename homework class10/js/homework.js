$(document).ready(function(){
     $("button").click(function(){
  fetch("https://jsonplaceholder.typicode.com/todos") 
  .then(response => {
      debugger
      response.json()
      .then(data => {
          console.log(data);
          for (let x of data){
          console.log("ID: " + x.id);
          console.log("Title: " + x.title);
          if (x.completed == true) {
            console.log("Completed");}
            else { (x.completed == false) 
              console.log("Not completed");
            };
          };
       });
  })
  .catch(err=>{
      console.log(err);
    });
  });
});

