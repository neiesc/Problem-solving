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
    for key, value in passport.items():
        if key == 'cid':
            continue
        if value is None:
            return False
    
    return True

with open("input.txt", "r") as f:
    lines = f.readlines()    
    for line in lines:
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
