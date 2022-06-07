console.log('Hello Node');

// A module is a piece of reusable code
// Specify it with imports and exports


function greeting(name){
    return `Hello my name is ${name}`
}


module.exports = greeting;
//when saved this module can be exported into any file that we import the helloNode.js into 