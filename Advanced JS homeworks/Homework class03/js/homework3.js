$(document).ready(function(){
    $("button").click(function(){
        fetch('https://dog.ceo/api/breed/hound/images')
        .then(response => response.json())
        .then(data => {
            data.message.forEach(picture => {
            let img = document.createElement('img');
            img.src = picture;
            document.getElementById('container').appendChild(img);
         })
     })
})
});