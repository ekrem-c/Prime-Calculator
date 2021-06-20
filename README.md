# Prime-Calculator
This is a prime number calculator I am working on for CASA position.

the link I used to verify prime numbers: https://www.calculatorsoup.com/calculators/math/prime-number-calculator.php

It is a simple boolean function calculating if an integer is a prime number or not. I have followed the convention that all negative integers are non-prime.


WHERE IS THE CODE:
  The isPrime function is under PrimeCalculator/Program.cs file, and the unit tests are located under PrimeCalculatorTests/ProgramTests.cs file.
  

I have followed an iterative approach, as it would be the most simple one to approach this problem and still fairly efficient. To improve my time complexity,
  I noticed that if an integer is a non-prime number, it should have a factor that is smaller than its square root. In the worst case, they may be square numbers, and their
  smallest non-1 factor would be equal to their square root. Thus, I limited the loop in the square root. Since every non-2 even number is non-prime, I iterated odd numbers instead.
  I could argue my time complexity is O(sqrt(N)/2). Before writing any code, I first preferred to write unit tests to spot my mistakes easier. I recomment you to check my commit
  history to have a better idea  on my thought process.
  
  

I checked different approaches after I am done with the code, and saw this wikipedia article to realize all prime numbers follow a (6k +- 1) pattern. 
  link: https://en.wikipedia.org/wiki/Primality_test
  I did not know that all prime numbers were (6k +- 1) pattern. If you check the code on the wikipedia article, you may possibly reach O(sqrt(N)/6) time complexity. 
  I didn't think it would be fair for me to use it as I would not think of that before checking the article.
  
  
IF we needed to check a set of numbers' primality on a daily basis, I could have a boolean hash table and I could just store the values there after calculating. This would be
  dynamic programming approach. As we don't have such a requirement, and I did not follow a recursive approach, using dynamic programming for single prime checks wouldn't save us
  time in this situation.
  

