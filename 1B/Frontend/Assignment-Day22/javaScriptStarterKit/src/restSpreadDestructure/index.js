
// Rest -> geriye kalan demek
// c# karşılığı params
let showProducts = function (id,...products) {
    console.log(id)
    console.log(products[0])
}

// console.log(typeof showProducts) // function
// showProducts() // çıktıyı kontrol et
// showProducts(10,"Elma","Armut","Karpuz")
// showProducts(10,["Elma","Armut","Karpuz"])



console.log("---------------")
// Spread -> ayrıştırmak demek

// console.log(Math.max(1,3,5,6,7,33))
// console.log(Math.max([1,3,5,6,7,33])) // NaN -> çünkü parametrede rest istiyor

// let points = [1,3,5,6,7,33]
// console.log(...points)
// console.log(Math.max(...points))
// console.log(..."ABC","D",..."EFG","H")


console.log("---------------")
// Destructuring
// for array 
let populations = [10000,20000,30000,[40000,100000]]
let [low,medium,high,[veryHigh,maximum]] = populations
console.log(low)
console.log(medium)
console.log(high)
console.log(veryHigh)
console.log(maximum)

function someFunction([lowTest,highTest],number) {
    console.log(lowTest,highTest);
}

someFunction(populations)

// for object
let category = {id:1,name:"İçecek"}
// console.log(category.id); // yaygın kullanım
// console.log(category["name"]);

let {id,name} = category
console.log(id);
console.log(name);