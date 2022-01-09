let element1 = document.getElementsByTagName("h1")[1]
element1.innerHTML = "hello"
let element2 = document.getElementsByTagName("h3")[0]
element2.innerHTML = "world"

let element3 = document.getElementsByClassName("paragraph")[0]
element3.innerHTML = "Changed paragraph"
let element4 = document.getElementsByClassName("paragraph second")[0]
element4.innerHTML = "Changed paragraph 2"

let element5 = document.getElementById("myTitle")
element5.innerHTML = "Changed Title"