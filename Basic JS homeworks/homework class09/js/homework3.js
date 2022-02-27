$(document).ready(function(){
      
    function getTodos(){
        $.ajax({
            type: 'GET',
            url: 'https://jsonplaceholder.typicode.com/todos',
            success: function(result){
                console.log(result);
                for(let x of result){
                    console.log("ID: " + x.id);
                    console.log("Title: " + x.title);
                    if (x.completed == true){
                        console.log("Completed");}
                    else  {(x.completed == false)
                        console.log("Not Completed");
                    };
                };
                
                },
            
            error: function(err){
                console.log(err);
            },
            });
        };    

    $("button").click(function(){
        getTodos();
    });
});

