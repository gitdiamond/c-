import random

def rast(n):
    arr=[0]*n
    for i in range(n):
        arr[i]=random.randint(0,100)   
        print(arr[i],end = ' ')

    g1=int(input("Введите первую границу для поиска:"))
    g2=int(input("Введите вторую границу для поиска:"))

    arr2 = []
    for i in range(n):
       if arr[i]>=g1 and arr[i]<=g2: arr2.append(i)
    return arr2

n=int(input("Введите размер массива для генерации:"))
print(rast(n))
