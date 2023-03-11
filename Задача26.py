def degree(A,B):
   if B == 0:
        return 1
   else:
        return A*degree(A,B-1)
   
result = degree(2,3)
print(result)