with open("input.txt", "r") as f:
    lines = f.readlines() 
    for line1 in lines:
        for line2 in lines:
            total = int(line1) + int(line2)
            if total == 2020:
                print("line1: " + line1)
                print("line2: " + line2)
                print(f"Multiply: {int(line1) * int(line2)}")