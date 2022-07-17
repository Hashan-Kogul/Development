# efficiently using the improved version of the code using sqrt function from math module. 
from math import sqrt
from time import perf_counter
max_value = 10000
count = 0
value = 2 # Smallest prime number
start = perf_counter() # Start the stopwatch
while value <= max_value:
    # See if value is prime
    is_prime = True # Provisionally, value is prime
    # Try all possible factors from 2 to value - 1
    trial_factor = 2
    root = sqrt(value)
    while trial_factor <= root:
        if value % trial_factor == 0:
            is_prime = False # Found a factor
            break # No need to continue; it is NOT prime
        trial_factor += 1 # Try the next potential factor
    if is_prime:
        count += 1 # Count the prime number
    value += 1 # Try the next potential prime number
elapsed = perf_counter() - start # Stop the stopwatch
print("Count:", count, " Elapsed time:", elapsed, "sec")