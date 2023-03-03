print("Введите 1 набор целых чисел:")

list_1=list()
for i in range(5):
    n=int(input())
    list_1.append(n)

print("Введите 2 набор целых чисел:")
list_2=list()
for i in range(5):
    n=int(input())
    list_1.append(n)

list_c=list_1+list_2
ls=set(list_1)
print()
print(ls)