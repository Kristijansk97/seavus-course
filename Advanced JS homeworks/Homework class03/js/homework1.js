$(document).ready(function(){
      
    function getPokemon(){
        $.ajax({
            type: 'GET',
            url: 'https://pokeapi.co/api/v2/pokemon',
            success: function(response){
                console.log(response);
                for(let i=0;i<10;i++){
                    $("#info").append(`<li>${(response.results[i].name + " " + response.results[i].url)}</li>`);
                }
                },
            
            error: function(err){
                console.log(err);
            },
            });
        };    

    $("button").click(function(){
        getPokemon();
    });
});



