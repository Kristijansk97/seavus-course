fetch("https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json")
    .then(res => res.json())
    .then(data  => {
        data.forEach(student => {
        //    getStudents(student);
        //    getFemaleStudents(student);
        // getStudentsSkopje(student);
        // averageGradeOfAllFemales(student);
        nameStarting(student);
        });
    });
    
const getStudents = student => {
     if (student.averageGrade > 3) 
     console.log(student.firstName + " " + student.lastName);
}

const getFemaleStudents = student =>{
     if (student.averageGrade === 5 && student.gender === 'Female')
      console.log(student.firstName + " " + student.lastName);
}

const getStudentsSkopje = student =>{
    if (student.city === "Skopje" && student.age > 18)
    console.log(student.firstName + " " + student.lastName);
}

const averageGradeOfAllFemales = student => {
    if (student.gender === "Female" && student.age > 24)
    console.log(student.averageGrade)
}

const nameStarting = student => {
    const string = student.firstName.split("");
    if (string[0] === 'B' && student.gender === "Male" && student.averageGrade > 2)
    console.log(student.firstName + " " + student.lastName);
}