password_valids = 0

with open("input.txt", "r") as f:
    lines = f.readlines()
    for line in lines:
        min_max, word, password = line.split()

        min, max = min_max.split("-")
        min, max = int(min), int(max) # convert str to int
        word = word.replace(":", "")

        word_count = password.count(word)
        if word_count >= min and word_count <= max:
            password_valids+=1

print(f"password_valids: {password_valids}")
    