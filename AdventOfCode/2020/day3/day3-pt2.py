def is_tree(width, line, right):
    print(f"line: {line}")
    print(f"right % width: {right % width}")
    if line[right % width] == "#":
        return True

    #print(line[line_number * 3])
    #print(line)
    #print(line_number * 3)

    return False

def total_tree(right, down):
    total_tree = 0

    with open("input_test.txt", "r") as f:
        right_current = right
        down_current = down
        lines = f.readlines()
        width = len(lines[0])
        height = len(lines)
        while down_current < height:
            line = lines[down_current].replace("\n", "")
            if is_tree(width, line, right_current + 1):
                total_tree += 1
            right_current  += right
            down_current += down
            print(f"right_current: {right_current}")
            print(f"down_current: {down_current}")

    return total_tree

# result = total_tree(1, 1)
result = total_tree(3, 1)
# result *= total_tree(5, 1)
# result *= total_tree(7, 1)
# result *= total_tree(1, 2)

print(f"result: {result}")
