def convert(number):
    ret = ""
    if number % 3 == 0:
        ret += "Pling"
    if number % 5 == 0:
        ret += "Plang"
    if number % 7 == 0:
        ret += "Plong"
    if ret == "":
        ret = str(number)
    return ret
