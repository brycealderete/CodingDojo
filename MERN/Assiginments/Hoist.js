console.log(hello);                                   
var hello = 'world'; 

var hello;
console.log(hello);
hello="world"



var needle = 'haystack';
test();
function test(){
    var needle = 'magnet';
    console.log(needle);
}

var needle;
needle="haystack";
function test(){
    var needle;
    needle= "magnet";
    console.log(needle);
}
test();




var brendan = 'super cool';
function print(){
    brendan = 'only okay';
    console.log(brendan);
}
console.log(brendan);

var brendan;
brendan="super cool";
function print(){
    brendan = 'only okay';
    console.log(brendan);
}
console.log(brendan);






var food = 'chicken';
console.log(food);
eat();
function eat(){
    food = 'half-chicken';
    console.log(food);
    var food = 'gone';
}


var food; 
food ="chicken";
console.log(food);
function eat(){
    food = 'half-chicken';
    console.log(food);
    var food = 'gone';
}
eat();






// mean();
// console.log(food);
// var mean = function() {
//     food = "chicken";
//     console.log(food);
//     var food = "fish";
//     console.log(food);
// }
// console.log(food);

// not going to work as mean is not a function 





console.log(genre);
var genre = "disco";
rewind();
function rewind() {
    genre = "rock";
    console.log(genre);
    var genre = "r&b";
    console.log(genre);
}
console.log(genre);

var genre;
genre = "disco";
console.log(genre);
function rewind() {
    genre = "rock";
    console.log(genre);
    var genre = "r&b";
    console.log(genre);
}
rewind();
console.log(genre);

// why does it print rock, rnb,disco, disco








dojo = "san jose";
console.log(dojo);
learn();
function learn() {
    dojo = "seattle";
    console.log(dojo);
    var dojo = "burbank";
    console.log(dojo);
}
console.log(dojo);

var dojo;
dojo = "san jose";
console.log(dojo);
function learn() {
    dojo = "seattle";
    console.log(dojo);
    var dojo = "burbank";
    console.log(dojo);
}
learn();
console.log(dojo);




console.log(makeDojo("Chicago", 65));
console.log(makeDojo("Berkeley", 0));
function makeDojo(name, students){
    const dojo = {};
    dojo.name = name;
    dojo.students = students;
    if(dojo.students > 50){
        dojo.hiring = true;
    }
    else if(dojo.students <= 0){
        dojo = "closed for now";
    }
    return dojo;
}