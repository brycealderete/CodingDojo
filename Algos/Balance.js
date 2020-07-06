// Write a function that returns whether the given array has a balance point
// BETWEEN two indices, where one side's sum is equal to the other.

// EXAMPLE: balancePoint([1,2,3,4,10]) --> true because 1+2+3+4 = 10, 
// so the balance point is between tha 3 and 4 indices
function balancePoint(array){
    
    for (var i=0; i < array.length;i++){
        var sum1=array[i]
        if (sum1===sum2){
            return true;
        }
        else if(array[i]===array[i]){
            sum1=array[i]
        }
        else{
            sum1+=array[i]

        }
        
        for (var j=array.length-1; j >i ;j--){
            var sum2=0
            
            sum2+=array[j]

        }

    }

}
console.log(balancePoint([1,2,3,4,10]))




// For the Balance Index, the balance point resides ON an index, rather than
// BETWEEN two indices. So for this one, write a function that returns the balance 
// index where sums are equal on either side, and exclude its own value. Return -1
// if no such idex exists.

// EXAMPLE: balanceIndex([-2,5,7,0,3]) --> 2, because -2 + 5 = 0 + 3
// EXAMPLE 2: balanceIndex([1,4,2,2,4,1]) --> -1, because there's no index with an equal
// sum on both sides of it.
function balanceIndex(array){
    
}