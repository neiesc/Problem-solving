def is_tree(width, line, right):
    line_debug = list(line)
    line_debug[right % width] = "X" if line[right % width] == "#" else "O"
    #print(f"line: {''.join(line_debug)}")
    return line[right % width] == "#"

def total_tree(right, down):
    total_tree = 0

    with open("input.txt", "r") as f:
        right_current = 0
        down_current = 0
        lines = f.readlines()
        width = len(lines[0].rstrip())
        height = len(lines)
        while down_current < height:
            line = lines[down_current].rstrip()
            if is_tree(width, line, right_current):
                total_tree += 1
            right_current  += right
            down_current += down
            #print(f"right_current: {right_current}")
            #print(f"down_current: {down_current}")

    return total_tree

result = total_tree(1, 1)
result *= total_tree(3, 1)
result *= total_tree(5, 1)
result *= total_tree(7, 1)
result *= total_tree(1, 2)

print(f"result: {result}")
