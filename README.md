# Codility-Fish
You are given two non-empty arrays A and B consisting of N integers.</br>
Arrays A and B represent N voracious fish in a river, ordered downstream along the flow of the river.</br>
The fish are numbered from 0 to N − 1.</br> 
If P and Q are two fish and P < Q, then fish P is initially upstream of fish Q.</br>
Initially, each fish has a unique position.</br>
Fish number P is represented by A[P] and B[P].</br> 
Array A contains the sizes of the fish.</br> 
All its elements are unique.</br> 
Array B contains the directions of the fish.</br> 
It contains only 0s and/or 1s, where:</br>
0 represents a fish flowing upstream,</br> 
1 represents a fish flowing downstream.</br>
If two fish move in opposite directions and there are no other (living) fish between them,</br> 
they will eventually meet each other.</br> 
Then only one fish can stay alive − the larger fish eats the smaller one.</br> 
More precisely, we say that two fish P and Q meet each other when P < Q, B[P] = 1 and B[Q] = 0,</br> 
and there are no living fish between them.</br> 

After they meet:</br>
If A[P] > A[Q] then P eats Q, and P will still be flowing downstream,</br>
If A[Q] > A[P] then Q eats P, and Q will still be flowing upstream.</br>
We assume that all the fish are flowing at the same speed.</br> 
That is, fish moving in the same direction never meet.</br> 
The goal is to calculate the number of fish that will stay alive.</br>

For example, consider arrays A and B such that:</br>
A[0] = 4    B[0] = 0</br>
A[1] = 3    B[1] = 1</br>
A[2] = 2    B[2] = 0</br>
A[3] = 1    B[3] = 0</br>
A[4] = 5    B[4] = 0</br>
Initially all the fish are alive and all except fish number 1 are moving upstream.</br> 
Fish number 1 meets fish number 2 and eats it, then it meets fish number 3 and eats it too.</br> 
Finally, it meets fish number 4 and is eaten by it.</br> 
The remaining two fish, number 0 and 4, never meet and therefore stay alive.

Write a function:</br>
class Solution { public int solution(int[] A, int[] B); }</br>
that, given two non-empty arrays A and B consisting of N integers,</br> 
returns the number of fish that will stay alive.</br>
For example, given the arrays shown above, the function should return 2, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer within the range [0..1,000,000,000];</br>
each element of array B is an integer that can have one of the following values: 0, 1;</br>
the elements of A are all distinct.
