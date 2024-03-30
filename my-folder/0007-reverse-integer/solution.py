import sys

class Solution(object):
    def reverse(self, x):
        is_negative = x < 0
        x = -x if is_negative else x
        
        reversed = 0
        while x != 0:
            last_digit = x % 10
            reversed = (reversed * 10) + last_digit
            x //= 10
        
        if abs(reversed) > pow(2, 31) - 1:
            return 0
        
        return -reversed if is_negative else reversed
