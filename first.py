print('Введите трёхзначное число:')
a = int(input())
b = 10

c1 = a % b
a=a//10
c2=a%10
a=a//10
c3=a
sum=c1+c2+c3

print(f"Сумма цифр трёх1значного числа: {sum}")