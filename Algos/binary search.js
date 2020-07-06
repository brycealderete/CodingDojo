// Write a binary search function that, given a sorted array and a number, will 
// return whether the number exists in the array. 

// The idea of binary search is you start at the middle, check to see if the number
// given is equal to, greater than, or less than the element in the middle, and do
// one of the following:
// 1. If the element we're looking at is EQUAL to the number requested, return true
// 2. If the element we're looking at is GREATER than the number requested, find 
//    the element in the middle of the LEFT side of the current element and do the
//    same check again. 
// 3. If the element we're looking at is LESS than the number requested, find 
//    the element in the middle of the RIGHT side of the current element and do the
//    same check again. 

// EXAMPLE: binarySearch([1,3,4,5,6], 2) --> false, because 2 is not in the array
function binarySearch(array, num){
    function binarySearch(array, num){
        let searching = true;
        let size = array.length
        let i = Math.ceil(size/2)-1;
        while(searching){
            if(array[i]==num){
                return true;
            }
            else if(array[i]>num){
                size = Math.ceil(size/2);
                i -= Math.floor(size/2);
            }
            else if(array[i]<num){
                size = Math.ceil(size/2);
                i += Math.floor(size/2);
            }
            if(size == 0){
                searching = false;
            }
            console.log(size,i)
        }
        return false;
    }
    
    console.log(binarySearch([1,2,3,4,5,6], 5))
}