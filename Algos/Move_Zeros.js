// Moves zeros with keeping other number order
function moveZerosFast(arr){
    for(var i = 0; i < arr.length; i ++){
        if(arr[i] == 0){
            var temp = arr[i];
            arr.splice(i,0);
            arr.push(temp);
        }
    }
    console.log(arr)
    return arr;

}
moveZerosFast([1,2,0,5,6,0,7,9,0,1,3]) 

function moveZerosSlow(arr){
    for(var i = 0; i < arr.length; i ++){
        for(var j = 0; j<arr.length-1; j++){
            if(arr[j] == 0){
                arr[j]=arr[j+1];
                arr[j+1]=0;
            }
        }
    }
    console.log(arr)
    return arr;

}

moveZerosSlow([1,2,0,5,6,0,7,9,0,1,3])