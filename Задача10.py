
print("Введите число монет:")
n=int(input())
count1=0
count2=0
c=[]
print("Введите монеты:")
for i in range(n):
    new_element=int(input())
    c.append(new_element)
    if c[i]==1: 
        count1+=1
    elif c[i]==0:
        count2+=1

if count1>count2: 
    print("Минимальное число монет, которые нужно перевернуть:",count2)
else: 
    print("Минимальное число монет, которое нужно перевернуть:",count1)