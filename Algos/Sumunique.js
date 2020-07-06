// Write a function that will take an array of numbers, and return the
// sum of all unique numbers in that array. Hint: Use a frequency table!

// A frequency table is a dictionary where, in each key-value pair, 
// the key is the item in the array, and the value is the number of times
// that thing appears

// EXAMPLE: [1,3,3,6,6,7,8,10] will return 26 because 1+7+8+10 = 26

function sumUniques(array) {
    var freq = {};
    var sum = 0;
    for(var i = 0; i<array.length; i++){
        if(array[i] in freq){
            if(freq[array[i]] == 1){
                sum-= array[i];
            }
            freq[array[i]] ++;
        }
        else{
            freq[array[i]] = 1;
            sum += array[i];
        }
    }
    return sum;
}

// Write a function that will take a string, and return a new string that contains
// the same words, but in reverse.

// EXAMPLE: "hello world my name is Cody" will return "Cody is name my world hello"
function reverseWordOrder(string) {
    var word = '';
    var newstring = '';
    for(var i = 0; i<string.length; i++){
        if(string[i] == ' '){
            newstring = word + ' ' + newstring;
            word = '';
        }
        else{
            word += string[i];
        }
    }
    newstring = word + ' ' + newstring;
    return newstring;
}