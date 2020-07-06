def biggie(list):
    for i in range(0,len(list),1):
        if list[i]>0:
            list[i]='Big'
    return list
print(biggie([-1, 3, 5, -5]))

def count(list):
    sum =0
    for i in range(len(list)):
        if list[i]>0:
            sum = sum +1
    list[len(list)-1]=sum
    return list
print(count([1,6,-4,-2,-7,-2]))

def sumtotal(list):
    sum=0
    for i in range(len(list)):
        sum= sum+list[i]
    return sum
print(sumtotal([1,2,3,4]))

def avg(list):
    sum=0
    avg=0
    for i in range(len(list)):
        sum= sum+list[i]
    avg=sum/len(list)
    return avg
print (avg([1,2,3,4]))

def length(list):
    return len(list)
print(length([37,2,1,-9]))

def minimum(list):
    if len(list)==0:
        return False
    min=list[0]
    for i in range(len(list)):
        if list[i]<=min:
            min=list[i]
    return min
print (minimum([]))

def maximum(list):
    if len(list)==0:
        return False
    max=list[0]
    for i in range(len(list)):
        if list[i]>=max:
            max=list[i]
    return max
print (maximum([])

def ultimate(list):
    length=len(list)
    sum=0
    avg=0
    max=list[0]
    min=list[0]
    for i in range(len(list)):
        sum= sum+list[i]
        if list[i]>=max:
            max=list[i]
        elif list[i]<=min:
            min=list[i]
    avg=sum/len(list)
    return {'sumTotal': sum, 'average': avg, 'minimum': min, 'maximum': max, 'length': length }
print (ultimate([37,2,1,-9]))

def reverse(list):
    for i in range(len(list)//2):
        temp=list[len(list)-i-1]
        list[len(list)-i-1]=list[i]
        list[i]=temp
    return list
print (reverse([37,2,1,4,-9]))