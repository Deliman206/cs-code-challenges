# cs-code-challenges
c# code challenges for ASP.Net 401


# Insert and shift middle index of array
This method allows the user to input an array and and integer and get a new array back with that integer at the iddle index. Th shift refers to the array indicies after the middle index, because a new value is being added to the array, all indicies after the middle index must shift by one.

## Challenge
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

## Approach & Efficiency
Our approach was to create a solution array (the array that the method will return) and assign the values of the solution array to those of the input array. We used conditional logic to handle the events before, during and after the middle index of the loop iteration of the solution array.
Once they array is filled the method returns the solution array.

## Big O
Time: O(n) where n is the number of integers in the input array
  - this solution grows linearly as the amount of integers in the input array is never known ahead-of-time
Space: O(1) 
  - this solution is actually O(2) and that is because we have 2 arrays to save in memory, however we never need any more arrays than 2 and O(2) reduces to O(1)
  
## Solution
![insertShiftArray](wbInsertShiftArray.jpg)

# Binary Search
This method allows the user to find the index of an integar value in a sorted integar array as well as let the user know if it doesn't exist.

## Challenge
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Approach and Efficiency
The first approach I thought of was to use a for loop to find the value and simply return the loop counter when the value was found. However this was innefficient because in a worst case scenario (i.e. the value is not in the array) the Big O for time would be O(n). This is not the worst but I felt I could do better because I knew the method took a SORTED integar array. From their it was concluded the midpoint was going to pivotal in this algorithm and it was going to have to be a loop or recursive. Recursion takes more space than 0(1) so a while loop became the the choice.

## Solution
![binarySearch](WbBinarySearch.jpg)