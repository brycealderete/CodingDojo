import random
def randInt(min=0   , max=100   ):
    max=max-min
    num = random.random()*max+min
    return int(num)
print(randInt())