// See https://aka.ms/new-console-template for more information
using TimeComplexity;

Console.WriteLine("Hello, World!");
// Instantiate an instance of an integer array of size 20000 elements
int[] array = new int[100];
BigOTimeComplexity timeComplexity = new BigOTimeComplexity();
// O(1) = Constant time to run the algorithm with respect to the size of the input; it doesn't take longer with more input
timeComplexity.BigO_01(array);

// O(n) = Scales linearly with respect to the amount of input; Twice the amount to data will take roughly twice as much time
timeComplexity.BigO_On(array);

// O(n^2) = Where n is the size of the array, the amount of time it will take this algorithm to run in this method will increase with response to n^2
timeComplexity.BigO_On2(array);

// O(log n) - This method executes a basic binary search algorithm
timeComplexity.BigO_Ologn(array);

Console.WriteLine("Press any key to exit the program ... ");
Console.ReadKey(true);
