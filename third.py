print('Введите номер билета:')
a = input()

c=int(a[0])
c1=int(a[1])
c2=int(a[2])
c3=int(a[3])
c4=int(a[4])
c5=int(a[5])


sum=c+c1+c2
sum2=c3+c4+c5

if sum==sum2:
    print("У вас счастливый билетик!")
else: 
        print("У вас несчастлиый билетик...")
