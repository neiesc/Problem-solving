def solve_path(lydia_path):
    lydia_path = list(lydia_path)
    for move_position in range(len(lydia_path)):
        if lydia_path[move_position] == 'S':
            lydia_path[move_position] = 'E'
        else:
            lydia_path[move_position] = 'S'
    return "".join(lydia_path)

t = int(input())
for x in range(t):
    n = int(input())
    lydia_path = input()
    my_path = solve_path(lydia_path)
    print("Case #{:d}: {:s}".format(x + 1, my_path))
