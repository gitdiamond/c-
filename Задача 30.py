def array(a1,d,n):
    arr=[0]*n
    arr[1]=a1
    for i in range(1,n):
        arr[i]=a1+(n-1)*d

    a=int(print())
    d1=int(print())
    n1=int(print())
    array(a,d1,n1)