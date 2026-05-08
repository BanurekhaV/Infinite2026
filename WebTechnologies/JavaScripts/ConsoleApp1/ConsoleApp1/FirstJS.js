function varconcept() {
    var x = 5;
    console.log(x);
    x = 10;  // reassigning possible
    var x = 25;  // redeclaration is possible
    var x = "AAA";  // redeclaration and reassigning possible
    console.log(x);
}

//let
function Concepts() {
    let x = 25;
    if (x == 25) {
        let y = 10;
        console.log(y);
        y = 100;  // reassigning or updating is possible
        let y = 50;  //redeclartion is not possible
        console.log(y);
    }
}

function letConcepts() {
    console.log(z);
    let z = 5;
    console.log(z);
}

//with objects
let { cname, age } = { cname: "Infinite Ltd.", age: 20 }
console.log(cname, age);

//const
function constantconcepts() {
    const c = 'a';
    const c1 = 10;
    console.log(c, c1);

    const cobj = { cname: "Infinite Ltd." };
    console.log(cobj.cname);
    cobj.cname = "New Infinite Ltd.";
    console.log(cobj.cname);

    const arr = [2, 4, 6, 8];
    arr.push(10);
    console.log(arr);
}

//global variables
let pname = "Dhoni"; // global variable
function myFunction() {
    let color = 'Yellow';  
    console.log(typeof pname + " " + "Cricketers name is " + pname + " wears jersey " + color);
    color = 'Blue'; 
}

console.log(15 > 10);
console.log(15 == "15");
console.log(15 === "15");

//ternary operator
function ternary() {
    const age = 18;
    const righttovote = age >= 18 ? "Yes" : "No";
    console.log(righttovote);
}