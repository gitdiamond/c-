

print("Введите сумму чисел S:")
S=int(input())
print("Введите произведение чисел P:")
P=int(input())

d=S*S-4*P
sq=d**(0.5)
x1=(S+sq)/2
x2=(S-sq)/2

y1=S-x1
y2=S-x2

if x1+y1==S and x1*y1==P:
    int(print("Число Х и Y",x1,y1))
elif x2+y2==S and x2*y2==P:
    int(print("Число Х и Y",x2,y2))
