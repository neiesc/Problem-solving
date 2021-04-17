def jaro_winkler_distance(s1, s2):
    jaro_dist = jaro_distance(s1, s2)
    if (jaro_dist > 0.7):
        prefix = get_prefix(s1, s2)
        prefix = min(4, prefix)
        jaro_dist += 0.1 * prefix * (1 - jaro_dist)
    
    return jaro_dist

def jaro_distance(s1, s2):
    if s1 == s2:
        return 1.0
    
    len_s1 = len(s1)
    len_s2 = len(s2)

    min_max_s = get_min_max_s(s1, s2)

    match = get_match(*min_max_s)
    print(match)

    if match == 0:
        return 0
    
    print(get_transpositions(*min_max_s))
    t = get_transpositions(*min_max_s) // 2

    return 1/3 * (match / len_s1 + match / len_s2 + (match - t) / match)

def get_min_max_s(s1, s2):
    s = [list(s1), list(s2)]
    s.sort(key=lambda x: len(x))
    min_s, max_s = s
    
    return (min_s,max_s)

def get_match(min_s, max_s):
    min_s, max_s = list(min_s), list(max_s)

    match = 0
    for i in range(len(min_s)):
        for j in range(len(max_s)):
            if min_s[i] == max_s[j]:
                match += 1
                max_s.remove(max_s[j])
                break

    return match

def get_transpositions(min_s, max_s):
    min_s, max_s = list(min_s), list(max_s)

    transpositions = 0
    for i in range(len(min_s)):
        if not min_s[i] == max_s[i]:
            transpositions += 1

    return transpositions

def get_prefix(s1, s2):
    prefix = 0

    for i in range(min(len(s1), len(s2))):
        if (s1[i] == s2[i]):
            prefix += 1
        else:
            break
    
    return prefix

s1, s2 = input(), input()
print(jaro_winkler_distance(s1, s2))