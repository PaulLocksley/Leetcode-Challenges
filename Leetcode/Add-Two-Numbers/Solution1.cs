using System.Numerics;

namespace Leetcode.Add_Two_Numbers;
/*var str = 342;
var st2 = 465;

var three = new Leetcode.Add_Two_Numbers.Solution();

var four = three.AddTwoNumbers(three.buildNode(str), three.buildNode(st2));*/

/*Runtime: 141 ms, faster than 42.64% of C# online submissions for Add Two Numbers.
    Memory Usage: 40.1 MB, less than 20.90% of C# online submissions for Add Two Numbers.*/
//takeaways: I am going through this the hard way and converting instead of using the list and carrying forward values. 
//Whilst this makes it easier to code it is not effiecient. 
public class Solution
{
    public  ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var number1 = getNumber(l1);
        var number2 = getNumber(l2);

        return buildNode(number1 + number2);
 
    }

    public  ListNode buildNode(BigInteger number)
    {
        var stringNumber = number.ToString();
        var node = new ListNode(val: stringNumber.First()-48);
        for (int i = 1; i < stringNumber.Length; i++)
        {
            node = new ListNode(val: stringNumber[i] - 48, next: node);
        }

        return node;
    }
    private  BigInteger  getNumber (ListNode initialNode)
    {
        var fullList = new Stack<int>();
        var workingNode = initialNode;
        while (workingNode.next != null)
        {
            fullList.Push(workingNode.val);
            workingNode = workingNode.next;
        }
        fullList.Push(workingNode.val); //last one
        
        var tempString = "";
        foreach (var str in fullList)
        {
            tempString += str.ToString();
        }
        
        return BigInteger.Parse(tempString);
    }
}