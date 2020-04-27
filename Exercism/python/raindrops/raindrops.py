raindrops = {3: "Pling", 5: "Plang", 7: "Plong"}
def convert(number):
    ret = ""
    
    for key, value in raindrops.items():
        if number % key == 0:
            ret += value

    if ret == "":
        ret = str(number)
    return ret
