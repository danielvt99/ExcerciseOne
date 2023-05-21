// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

int[] list1 = new int[] { 1, 2, 3, 4, 5 };
int[] list2 = new int[] { 3, 4, 5, 6, 7 };

HashSet<int> set1 = new HashSet<int>(list1);
HashSet<int> set2 = new HashSet<int>(list2);

List<int> commonElements = new List<int>(set1.Intersect(set2));
List<int> uniqueElementsInList1 = new List<int>(set1.Except(set2));
List<int> uniqueElementsInList2 = new List<int>(set2.Except(set1));

//If the output is always expected as the distinct combinations of the common and unique combinations in list 1 and 2. 
//A hash set is the best option. Otherwise if you want to maintain duplicate entries a common list could be the better option.

//a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
 Console.WriteLine(string.Join(" ", commonElements));

//b. Show the elements from list 1, but is not found in list2. E.g 1 2"
Console.WriteLine(string.Join(" ", uniqueElementsInList1));

//c. Show the elements from list 2, but is not found in list1. E.g 6 7"
Console.WriteLine(string.Join(" ", uniqueElementsInList2));

Console.WriteLine("Press <ENTER> to continue");
Console.ReadLine();
