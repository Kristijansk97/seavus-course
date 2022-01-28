$(document).ready(function(){
    $("button").click(function(){
        var h1 = document.createElement("h1");
        $("body").before(h1);
        $("input:first").val();
        $("input:last").val();
        $(h1).html($("input:first").val());
        $(h1).css("color", $("input:last").val());
      });
      $("button").click(function(){
        if($("input:first").val() == '') { 
          $("h3").append(" " + "Error, please enter text");
        }
        if($("input:last").val() == '#000000') {
          $("h3").append(" " +"Error,please select color");
        }
      });
});