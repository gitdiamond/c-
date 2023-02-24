print("Введите число N:")
N=int(input())
i=0

while i<N:
    if 2**i<N:
        print(2**i)
    i+=1