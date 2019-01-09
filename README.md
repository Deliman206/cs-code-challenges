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
![insertShiftArray](assests/wbInsertShiftArray.jpg)
