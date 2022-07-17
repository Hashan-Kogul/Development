# Count to n and print each number
n = int(input("Enter the value of n: "))
def count_to_n(x = n):
    for i in range(1, x + 1):
        print(i, end=' ')
    print()

print("Going to count to {} . . .".format(n))
count_to_n(n)