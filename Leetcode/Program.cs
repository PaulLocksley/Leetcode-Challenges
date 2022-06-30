// See https://aka.ms/new-console-template for more information
var one = new Int32[2]{1, 2};
var two = new Int32[2]{3, 4};
var x = Leetcode.median_of_two_sorted_arrays.Solution.FindMedianSortedArrays(one, two);
Console.WriteLine((x == (double)2.5));
var three = new Int32[2]{1,3};
var four = new Int32[1]{2};
Console.WriteLine(Leetcode.median_of_two_sorted_arrays.Solution.FindMedianSortedArrays(three, four) == 2);
var five = new Int32[0]{};
var six = new Int32[2]{2,3};
double y = Leetcode.median_of_two_sorted_arrays.Solution.FindMedianSortedArrays(five, six);
Console.WriteLine(y);
