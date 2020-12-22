sum_of_answered_yes = 0

with open("input.txt", "r") as f:
    lines = [line.rstrip() for line in f.readlines()]
    answered_yes_group = []
    for line in lines:
        #print(line)
        if line == "":
            sum_of_answered_yes += len(set.intersection(*answered_yes_group))
            answered_yes_group = []
            continue

        answered_yes_group.append(set(line))

sum_of_answered_yes += len(set.intersection(*answered_yes_group))
answered_yes_group = []

print(f"\nWhat is the sum of those counts? {sum_of_answered_yes}")
