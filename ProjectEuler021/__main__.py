import time


def build_divisor_sums(limit):
    # Create a dictionary of divisors
    divisors = {

    }

    # Calculate and store a number and the sum of its divisors
    for num in range(2, limit + 1):
        total = 0
        i = 1
        while i < num:
            if num % i == 0 and i != num:
                total += i
            i += 1
        divisors.update({i: total})
    return divisors


def find_amicable_pairs(divisors):
    # Create an array of amicable pairs
    pairs = []
    for key_a, val_a in divisors.items():
        for key_b, val_b in divisors.items():
            if val_a == 1 or val_b == 1:
                continue
            else:
                if key_a != key_b:
                    if val_a == key_b and val_b == key_a:
                        pairs.append(key_a)
    return pairs


def solve():
    # Build divisors and find the amicable pairs
    divisors = build_divisor_sums(10000)
    pairs = find_amicable_pairs(divisors)

    # Add pairs for total
    total = 0
    for pair in pairs:
        total += pair
    return total


# Solve!
start = time.time()

print(solve())

elapsed = time.time() - start
print('Time Taken: ' + str(elapsed))
