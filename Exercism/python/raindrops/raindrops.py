def convert(number):
    raindrops = ((3, "Pling"), (5, "Plang"), (7, "Plong"))
    
    raindrop_result = [raindrop[1] for raindrop in raindrops if number % raindrop[0] == 0]

    return "".join(raindrop_result) or str(number)