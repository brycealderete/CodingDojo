// Write a function that performs a binary search recursively.

// As a reminder, binary search is where you start in the middle of a 
// sorted array, and check to see whether the number you're looking for is
//    1. That number
//    2. Greater than that number (in this case, search again on the right side)
//    3. Less than that number (in this case, search again on the left side)

// Return a boolean for whether or not the number is in the array
function rBinarySearch(array, num ) {
    var temp =(array.length-1)/2;
    temp=Math.floor(temp)
    if (array[temp/2]==num){
        return num;
    }
    else if (array[temp]<num){
        var arr=[]
        for(var i=(array.length-1)/2;i<array.length;i++){
            arr.push(array[i]);
            console.log(arr);
        }
    
        return rBinarySearch(arr, num );
    }
    else if (array[temp]>num){
        var arr1=[]
        for(var j=0;j<(array.length-1)/2;j++){
            arr1.push(array[j]);
            console.log(arr1);
    }
        return rBinarySearch(arr1, num );
    }
}
console.log( rBinarySearch([1,2,3,4,5,6,7,8,9,10],2))