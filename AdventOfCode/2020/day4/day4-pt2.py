passports_valid = 0

default_value_passport = {
    'byr': None,
    'iyr': None,
    'eyr': None,
    'hgt': None,
    'hcl': None,
    'ecl': None,
    'pid': None,
    'cid': None
}
passport = None

def is_valid(passport):
    valid = None
    valid_for = None
    for key, value in passport.items():
        #print(f"key: {key}, value: {value}")
        if key == 'cid':
            continue
        
        if value == None:
            valid_for = False

            if valid == None:
                valid = valid_for

            valid = False
            continue

        if key == 'byr':
            value = int(value)

            valid_for = value >= 1920 and value <= 2002
        elif key == 'iyr':
            value = int(value)

            valid_for = value >= 2010 and value <= 2020
        elif key == 'eyr':
            value = int(value)

            valid_for = value >= 2020 and value <= 2030
        elif key == 'hgt':
            if "cm" in value:
                value = int(value.replace("cm", ""))

                valid_for = value >= 150 and value <= 193
            elif "in" in value:
                value = int(value.replace("in", ""))

                valid_for = value >= 59 and value <= 76
            else:
                valid_for = False
        elif key == 'hcl':
            valid_for = value[0] == "#" and len(value[1:]) == 6 
        elif key == 'ecl':
            valid_for = value in ("amb", "blu", "brn", "gry", "grn", "hzl", "oth")
        elif key == 'pid':
            valid_for = len(value) == 9 and value.isdigit()

        #print(f"valid_for: {valid_for}")

        if valid == None:
            valid = valid_for

        if not valid_for:
            valid = False

    return valid

with open("input.txt", "r") as f:
    lines = f.readlines()    
    for line in lines:
        #print(f"line: {line}")
        if line == '\n':
            if is_valid(passport):
                passports_valid += 1
            
            passport = None
            continue
        
        if passport is None:
            passport = dict(default_value_passport)

        line = line.split()
        for key_value in line:
            key, value = key_value.split(':')
            #print(f"key: {key}, value: {value}")
            passport[key] = value

#print(passport)
if is_valid(passport):
    passports_valid += 1

print(f"How many passports are valid? {passports_valid}")
