print("Введите общее количество журавликов:")
a=int(input())

if  a%3:
    print("Введите корректное общее количество жураликов")
    
else:
    petser=int((a/3)/2)
    print(f"Петя и серёжа сделали по {petser} журавликов")
    katy=int(a-petser*2)
    print(f"Катя сделала {katy} журавликов")

