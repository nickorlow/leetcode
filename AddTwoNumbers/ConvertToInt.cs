/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        BigInteger numfin = 0;
        ListNode current = l1;
        for(BigInteger y = 0; y<2; y++)
        {
            List<BigInteger> num = new List<BigInteger>();
            for(BigInteger i = 0;current != null; i++)
            {
                num.Add(current.val);
                current = current.next;
            }
            num.Reverse();
            
            numfin += ArrayHeader(num);
            current = l2;
        }
     
        return ToLinkedList(numfin);
    }
    
    public BigInteger ArrayHeader(List<BigInteger> arr)
    {
        string final = "";
        foreach(BigInteger i in arr)
            final += i.ToString();

        return BigInteger.Parse(final);
    }
    
    public ListNode ToLinkedList(BigInteger num)
    {
        List<int> result = num.ToString().Select(o=> int.Parse(o.ToString())).ToList();
        ListNode fin = new ListNode(result[0]);
        result.RemoveAt(0);
        foreach (int i in result)
            fin = new ListNode(i, fin);

        return fin;
    }
}
