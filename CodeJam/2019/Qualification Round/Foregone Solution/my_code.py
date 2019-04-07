def solve(n):
    a, b = '', ''
    n = list(n)
    for i in n:
        if i == '4':
            a = a + '3'
            b = b + '1'
        else:
            a = a + i
            b = b + '0'
    return int(a), int(b)

t = int(input())
for x in range(t):
    n = input()
    a, b = solve(n)
    print("Case #{:d}: {:d} {:d}".format(x + 1, a, b))
