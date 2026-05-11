function varconcept() {
    var x = 5;
    console.log(x);
    var x = 25;  //redeclaration is possible
    var x = "AAA";  //reassigning is also possible
    console.log(x);
}
//let
function Concepts() {
    let x = 25;
    if (x == 25) {
        let y = 10;
        console.log(y);
        y = 100;  // reassigning or updation is possible
        //   let y = 50; // redeclaration not possible
        console.log(y);
    }
}
function letconcepts() {
   //  console.log(y1); // cannot access before initialization
    let y1 = 6;  
    console.log(y1);
    

    //with objects
    let { cname, age } = { cname: "Infinite Ltd.", age: 20 }
    console.log(cname, age);
}

//const
function constantconcepts() {
    const c = 'a';
    const c1 = 10;
    console.log(c, c1);
    //const with objects and arrays
    const cobj = { cname: "Infinite Ltd." };
    console.log(cobj.cname);
    cobj.cname = "New Infinite Ltd.";
    console.log(cobj.cname);
}

    //hoisting behaviour of var, let and const

    function HoistingFunc() {
        console.log(x);  // undefined 
        var x = 15;

        console.log(y);  // reference error, since variables with let remain in Temporarily dead zone (TDZ)
        let y = 10;

        console.log(z);  // reference error, since variables with let remain in Temporarily dead zone (TDZ)
        const z = 5;
}

    const carr = [2, 4, 6, 8];
    carr.push(10);
   console.log(carr); //will display [2,4,6,8,10]
  //  carr = [7, 8];  // not possible to reassign


//global variables

let pname = "Dhoni" // global variable
function myFunction() {
    let color = 'Red'; // considered global
    console.log(typeof pname + " " + "Cricketer name is " + pname + " wears jersey of  " + color);
    color = 'Blue'; //local variable
}

//operators

console.log(15 > 10);  //true
console.log(15 == "15"); //true
console.log(15 === "15"); //false


//ternary operator
function ternary() {
    const age = 18;
    const righttovote = age >= 18 ? "Yes Adult" : "No Minor";
    console.log(righttovote);
}