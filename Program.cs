﻿int[] nums = { 1, 1, 1, 1 };
int[] tmp = new int[nums.Length + 1];
tmp[0] = 0;
tmp[1] = nums[0];
for(int i = 1; i < nums.Length; i++)
{
    tmp[i+1] = Max(tmp[i], tmp[i-1] + nums[i]);
}
return tmp[nums.Length];

static int Max(int a, int b)
{
    return a > b ? a : b;
}

