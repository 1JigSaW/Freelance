

import numpy as np
with open('input.txt', 'r') as inp_f:
    m, n, x, y = map(int, inp_f.read().split())
board=np.zeros((m,n), dtype=int)

def allowPath(X,Y, board, currentStep=1):
#    print('currentStep=',currentStep)
    if X<0 or X>=len(board):
        return False
    if Y<0 or Y>=len(board[0]):
        return False
    if board[X,Y]!=0:
        return False
    
    board[X,Y]=currentStep
    #print('X=',X, 'Y=', Y, 'currentStep=',currentStep, 'board=\n', Newboard)
    if (len(board[board==0])==0):
        return True
    
    NewStep=currentStep+1
    
    def NextStep(X,Y,variant):
        operation = {
            0: lambda X, Y: (X+1, Y+2),
            1: lambda X, Y: (X+2, Y+1),
            2: lambda X, Y: (X+2, Y-1),
            3: lambda X, Y: (X+1, Y-2),
            4: lambda X, Y: (X-1, Y-2),
            5: lambda X, Y: (X-2, Y-1),
            6: lambda X, Y: (X-2, Y+1),
            7: lambda X, Y: (X-1, Y+2),
        }
        return operation[variant](X,Y)
    
    for StepVariant in range(8):
        NewX, NewY=NextStep(X,Y,StepVariant)
        if allowPath(NewX, NewY, board, NewStep):
            return True
    else:
        board[X,Y]=0
        print('Шаг fail', currentStep)
        return False
        return False
 
res=allowPath(x, y, board)
print(res,'Board=\n', board)
with open('output.txt', 'w') as out_f:
    if res != 0:
            out_f.write(res)
    else:
        out_f.write("Маршрут не существует \n")