def X(x, k):
    return 3 * x + k

def Y(y, x):
    return x + y

def sum(maxk, k, x, y, sum1):
    if k != maxk:
    	return sum(maxk, k+1, X(x,k), Y(y,x), sum1 + x + y)
    else:
        return sum1 + x + y
         

k = int(input())
print(sum(k,1,0,0,0))
