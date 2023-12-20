// var, let, const
let sayi1 = 10
sayi1 = "Engin Demiroğ"
let student = {id:1, name:"Engin"}
// console.log(student)
// object notation


function save(student, points=10) {
    console.log(student.name + " : " + points)
}
// save(student)

// function save(points=10, student) {
//     console.log(student.name + " : " + points)
// }
// save(undefined, student)
// default parametreyi undefined ile kullanabiliriz


let students = ["Engin Demiroğ","Halit Kalaycı","Engin Toprak","Büşra"]
// console.log(students)
 
let students2 = [student, {id:2, name:"Halit"}, "Ankara", {city:"İstanbul"}]
// console.log(students2)


