/* *********************************************************
            THESE ALGOS ARE TO BE DONE RECURSIVELY
********************************************************* */

// Write a function that, given a number, returns its factorial

// Factorial: 7! = 7 * 6 * 5 * 4 * 3 * 2 * 1
// The ! does not mean the number is really excited!!

// EXAMPLE: factorial(3) returns 6 because 3 * 2 * 1 = 6
function factorial(num){
    if num ==1{
    return num;
    }
    return num * factorial(num-1);
}


//Write a function that, given a number, will return that element in the Fibonacci sequence

// Fibonacci Sequence: Each number in the sequence is the sum of the previous two numbers.

// 1 1 2 3 5 8 13 21 34 ...

// EXAMPLE: rFib(4) would return 3, because 3 is the 4th number in the fibonacci sequence!

// NOTE! You may need to have an additional parameter!!
function rFib(num) {
    
}