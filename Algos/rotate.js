// Write a function that is given a string and a number, and returns the string rotated to the 
// right that many times

// EXAMPLE: rotate("hello world", 3) would return "rldhello wo", because you've essentially
// shifted the string to the right 3 times, and the text at the end "wrapped around" for the
// rotation
function rotate(string, num){
    function rotate(string, num){
        var temp = ''
        for(i = 0; i<string.length-num; i++){
            temp += string[i];
        }
        for(i =string.length-1; i >string.length-num-1; i--){
            temp = string[i] + temp;
        }
        return temp
    }
    
    console.log(rotate('i love lamp', 3))
}


// Write a function that will take 2 strings (oString and tString, for original string and test string),
// and return a boolean based on whether or not tString is a rotated version of oString

// EXAMPLE: isRotation("hello world", "rldhello wo") would return true, because, as we saw in the previous
// algorithm, "hello world", rotate right 3 spots, returns "rldhello wo"
function isRotation(oString, tString){
    function isRotation(oString, tString){
        if(oString.length == tString.length){
            for(var i=1; i<oString.length, i++){
                if(newstr == tString){
                    return true
                }
            }
            return false
        }
            
    
    }
    
    console.log(isRotation("hello world", "rldhello wo"))
