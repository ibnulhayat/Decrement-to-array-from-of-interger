# Decrement-to-array-from-of-interger

Suppose given a integer number like as 102 and decrease value is 3. if you want to easily find out the result, result is 99.
Nou you think, this numer conver a integer array [1,0,2] and decrease value is 3 and tell you decrease the value from array and return the result as array like of [0,9,9].
But you can't use convertion integer to string or any buield function.

Example 1: 
  input: [1,0,2] value = 3
  output: [0,9,9]
  
Example 2: 
  input: [8,8,8] value = 7
  output: [8,8,1]

Example 3: 
  input: [1,0,7,6] value = 27
  output: [1,0,4,9]
  
  
# Solve 
Approach One: Schollbook Subtraction
  Let's subtraction numbers in a schoolbook way, column by column. For example, to sub 102 and 3, we sub 2-3 but 2 is smaller then 3, so we can't proper value then we add 10 value with 2, now 12-3 = 9 but you have to carry 1 into the next column and following this method others column and get final result is 099.


  
