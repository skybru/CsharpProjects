/*

FIND-MAX-CROSSING-SUBARRAY (A, low, mid, high)
left-sum = 0
sum = 0
for i = mid downto low
    sum = sum + A[i]
    if sum > left-sum
        left-sum = sum
        max-left = i
right-sum = 0
sum = 0
for j = mid to high
    sum = sum + A[j]
    if sum > right-sum
        right-sum = sum
        max-right = j
return max-left, max-right, left-sum + right-sum


FIND-MAXIMUM-SUBARRAY(A, low, high)
if high == low
    return (low, high, A[low])
else
    mid = (low + high) / 2
    left-low, left-high, left-sum = FIND-MAXIMUM-SUBARRAY(A, low, mid)
    right-low, right-high, right-sum = FIND-MAXIMUM-SUBARRAY(A, mid + 1, high)
    cross-low, cross-high, cross-sum, = FIND-MAX-CROSSING-SUBARRAY (A, low, mid, high)
    if left-sum >= right-sum && left-sum >= cross-sum
        return left-low, left-high, left-sum
    else if right-sum >= left-sum && right-sum >= cross-sum
        return right-low, right-high, right-sum
    else
        return cross-low, cross-high, cross-sum

*/