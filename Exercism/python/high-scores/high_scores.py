def latest(scores):
    return min([score for score in scores if score > 0])


def personal_best(scores):
    return max(scores)


def personal_top_three(scores):
    scores_sorted = sorted(scores)
    scores_sorted.reverse()
    return scores_sorted[:3]
