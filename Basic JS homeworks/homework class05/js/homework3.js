const arr=[2,5,5,1,6,7,8,2,5]
function findNumber(array, number){
   let count=0;
   for (let i=0; i <= array.length; i++){
      if(array[i] === number){
         count++;
      }
   }
   console.log(`There are ${count} occurrences of number ${number} in the array`);
}
findNumber(arr,5);
findNumber(arr,2);
findNumber(arr,8);
