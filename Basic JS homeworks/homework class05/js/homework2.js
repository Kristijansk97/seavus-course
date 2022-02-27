function fullName(){
    let first=["Kristijan","David","Lazar","Vlatko"];
    let last=["Ilioski","Markovski","Petrovski","Dimitrov"]
    let text = "";
    let arr=[];
    for (i=0;i <= first.length;i++){
        arr.push(first[i] + " " + last[i]);
    }
    arr.forEach(numeric);
    function numeric(item, index) {
     numeric=text += " " + index + ": " + item ;
    }
    console.log(numeric);
}
fullName();
