var nodeList5 = new ListNode()
{
    val = 5,
};

var nodeList4 = new ListNode()
{
    val = 4,
    next = nodeList5
};

var nodeList3 = new ListNode()
{
    val = 3,
    next = nodeList4
};


var nodeList2 = new ListNode()
{
    val = 2,
    next = nodeList4
};

var nodeList1 = new ListNode()
{
    val = 1,
    next = nodeList2
};



var lista1 = nodeList1;
var lista2 = nodeList3;


var mergedList = MergeTwoLists(lista1, lista2);

while(mergedList.val < 5)
{
    Console.WriteLine(mergedList.val);

    mergedList = mergedList.next;

    if (mergedList.val == 4)
    {
        Console.WriteLine(mergedList.val);
        break;
    }
}


ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null) return list2;
    if(list2 == null) return list1;

    if(list1.val <= list2.val)
    {
        list1.next = MergeTwoLists(list1.next,list2);
        return list1;
    }

    list2.next = MergeTwoLists(list1,list2.next);
    return list2;

}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

