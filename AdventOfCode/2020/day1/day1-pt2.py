with open("input.txt", "r") as f:
    lines = f.readlines() 
    for line1 in lines:
        for line2 in lines:
            for line3 in lines:
                total = int(line1) + int(line2) + int(line3)
                if total == 2020:
                    print(f"line1: {line1}")
                    print(f"line2: {line2}")
                    print(f"line3: {line3}")
                    print(f"Multiply: {int(line1) * int(line2) * int(line3)}")