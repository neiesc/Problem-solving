count_shiny_gold_bag = 0

rules = {}

with open("input.txt", "r") as f:
    lines = [line.rstrip() for line in f.readlines()]
    answered_yes_group = []
    for line in lines:
        line = line.split(" bags contain ")
        line[1] = line[1].split(",")
        bags = []
        for bag in line[1]:
            bag = bag.strip(" ")
            bags.append(bag.split(" "))
        contained_bags = []
        for bag in bags:
            bag = bag[1] + " " + bag[2]
            contained_bags.append(bag)
        if "other" in contained_bags[0]:
            contained_bags[0] = "None"
        rules[line[0]] = contained_bags

bags = ["shiny gold"]

for bag in bags:
    for rule in rules:
        if bag in rules[rule]:
            if rule not in bags:
                bags.append(rule)

print(f"\nHow many bag colors can eventually contain at least one shiny gold bag?  {len(bags) - 1}")
