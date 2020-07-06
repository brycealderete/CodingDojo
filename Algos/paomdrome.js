// Write a function that takes a string, and returns a boolean based on 
// whether or not the string is a palindrome.

// EXAMPLE: "tacocat" is a palindrome because it is the same backwards and forwards.

// Challenge: ignore spaces, so "taco cat" would still return true
function isPalindrome(string) {
    var newstring='';
    for (var i=0; i<string.length;i++){
        if (string[i] !=" "){
        newstring= newstring+ string[i];
        }
    }
    for (var i=0; i<Math.floor(newstring.length/2);i++){
        if(newstring[i]!=newstring[newstring.length-1-i]){
            
            console.log ('Invalid');
            return false;
            

        }

    }
    console.log('Valid')
    return true;
    
    
    
}
console.log(isPalindrome("woiudhofui ikjd"));




// CHALLENGE ALGORITHM: Write a function that will find and return the longest palindrome within a string
// EXAMPLE: "the man ate a banana with his tacocat at dinner the other day" would return "tacocat"
function longestPalindrome(string) {
    var newstring=''
    for (var i=0; i<string.length;i++){
        newstring= newstring+ string[i];
        if () 
    }

}