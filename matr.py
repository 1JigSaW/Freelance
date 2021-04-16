def determinantOfMatrix(mat):
 
    # if given matrix is of order
    # 2*2 then simply return det
    # value by cross multiplying
    # elements of matrix.
    if(len(mat) == 2):
        value = mat[0][0] * mat[1][1] - mat[1][0] * mat[0][1]
        return value
 
    # initialize Sum to zero
    Sum = 0
 
    # loop to traverse each column
    # of matrix a.
    for current_column in range(len(mat)):
 
        # calculating the sign corresponding
        # to co-factor of that sub matrix.
        sign = (-1) ** (current_column)
 
        # calling the function recursily to
        # get determinant value of
        # sub matrix obtained.
        sub_det = determinantOfMatrix(getcofactor(mat, 0, current_column))
 
        # adding the calculated determinant
        # value of particular column
        # matrix to total Sum.
        Sum += (sign * mat[0][current_column] * sub_det)
 
    # returning the final Sum
    return Sum

print(determinantOfMatrix([[1, 2],[3,4]]))