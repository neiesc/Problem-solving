total_tree = 0

with open("input.txt", "r") as f:
    line_number = 0
    lines = f.readlines()    
    for line in lines:
        if line_number == 0:
            line_number+=1
            continue

        if (line_number * 3) >= len(line):
            line = line.replace("\n", "") * (int((line_number * 4) / len(line)) + 1) + "\n"

        if line[line_number * 3] == "#":
            total_tree+=1

        #print(line_number * 3)
        #print(line)
        #print(line[line_number * 3])

        line_number+=1

print(f"total_tree: {total_tree}")
