var text = "Merhaba, Tobeto";
console.log(text);
text = 50;
console.log(text);
text = true;
console.log(text);

// EcmaScript => EC6 (2015)
// let % const

console.log("*********");

console.log(hello);
var hello = "Merhaba";

//

// var number = 10;
// if(number > 5)
// {
//     var newVariable = "Hello";
// }
// console.log(newVariable);

// console.log(hello);
// let hello = "Merhaba";

// let number = 10;
// if(number > 5)
// {
//     let newVariable = "Hello";
// }
// console.log(newVariable);

// ES6 2015 - ES2016 - ES2017 - ES2018

console.log("*******");

function topla(sayi1, sayi2) 
{
    return sayi1 + sayi2;
}

// console.log(topla(5,10));
// console.log(topla()); // Not a Number
// console.log(topla(1));
// console.log(topla(1, "5"));
// console.log(topla("5", 1, 5, 2, 6, 3, 6, 2));

// Arrow function

let toplaFunction = (sayi1, sayi2) => {
    return sayi1 + sayi2;
}
console.log(toplaFunction(1,5))

let toplaFunction2 = (sayi1, sayi2) => sayi1 + sayi2;
console.log(toplaFunction2(1,5))

//
const PI = 3.14;
// PI = 5;

// toplaFunction=5;
// console.log(toplaFunction);

console.log("***********");

// CB (callback) Function

let list = [5, 10, 15, 20];

list.forEach((element, index, array) => {
    console.log(element, index, array)
    // list.filter(() =>...)
});


// list.forEach((_, i, a) => { // burada kaçış karakteri olan _'yi kullansak bile ilk karakteri almadan diğerlerini alamıyoruz
//     console.log(_, i, a)
//     // list.filter(() =>...)
// });

// map - filter - reduce

// mapping
let newList = list.map((element) => {return element * 2});
console.log(newList);
console.log(list);

// U[] -> generic

// predicate
let filteredList = list.filter((element) => element > 10);
console.log(filteredList);

let filteredList2 = list.filter((element) => { return element >= 10 });
console.log(filteredList2);

// reduce 
// [5, 10, 15, 20]
const listSum = list.reduce((previous, next) => {
    console.log(previous, next);
    return previous + next;
}, 0); //initial value!
console.log(listSum);