$(document).ready(function(){
  $("button:first").click(function(){
    $("input").val("Kristijan Ilioski");
  });
  $("button:last").click(function(){
    $(this).css("background","red");
  });
  $("h3").html("Testing Jquery");
  $("#randomText").html("Testing adding text");
  $("#randomText").append("Textind appending text");
});