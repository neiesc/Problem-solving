def find_result_diferent_four(x):
    for a in range(x, 0, -1):
        for b in range(x, 0, -1):
            if ((a + b) == x) and ("4" not in str(a) and "4" not in str(b)):
                return (a, b)

t = int(input())
for x in range(t):
    n = int(input())
    a, b = find_result_diferent_four(n)
    print("Case #{:d}: {:d} {:d}".format(x + 1, a, b))
