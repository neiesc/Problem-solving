password_valids = 0

with open("input.txt", "r") as f:
    lines = f.readlines()
    for line in lines:
        position, word, password = line.split()

        position1, position2 = position.split("-")
        position1, position2 = int(position1), int(position2) # convert str to int
        word = word.replace(":", "")

        if position1 == 0:
            pass


        word_position1 = password[position1 - 1]
        word_position2 = password[position2 - 1]
        
        is_position1 = word_position1 == word
        is_position2 = word_position2 == word

        if not (is_position1 and is_position2) and (is_position1 or is_position2):
            password_valids+=1

print(f"password_valids: {password_valids}")
