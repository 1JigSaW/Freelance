from typing import List

class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
    	max1=0
        for i in accounts:
            if(sum(i)>max1):  
                max1=sum(i)
        return max1