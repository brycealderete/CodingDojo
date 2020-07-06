def countdown(num):
    newlist= []
    for i in range(num,-1,-1):
        newlist.append(i)
    return newlist
print(countdown(5))

def printreturn(list):
    print (list[0])
    return list[1]
print (printreturn([4,5]))

def firstplus(list):
    sum =list[0]+len(list)
    return sum
print(firstplus([1,3,54,67,87,56,7]))

def valuegreater(list):
    newlist = []
    for i in range(0,len(list),1):
        if list[i]> list[1]:
            newlist.append(list[i])
    print(len(newlist))
    return newlist
print(valuegreater([5,2,3,2,1,4]))

def thislength(size,value):
    newlist=[]
    for i in range(0,size,1):
        newlist.append(value)
    return newlist
print(thislength(8,10))