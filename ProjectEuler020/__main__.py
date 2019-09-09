def calculate_factorial(factorial):
    total = 1

    current_number = factorial
    while current_number > 1:
        total *= current_number
        current_number -= 1

    return total


def sum_factorial(factorial):
    total = 0
    factorial = str(factorial)

    for ch in factorial:
        total += int(ch)

    return total


print(sum_factorial(calculate_factorial(100)))
