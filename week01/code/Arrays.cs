public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        var array = new double[length];
        for (double i = 1; i <= length; i++){
            double multiple = number * i;
            int index = (int)(i-1);
            array[index] = multiple;
        }

        return array;

        //Plan and Steps:
        //Step 1: Create a For loop that will increment by 1 each iteration, set as 1 initially.
        //Step 2: Multiply input initial number by each increment to get our multiple.
        //Step 3: Set the condition to 'less than or equal to' the size of the number of multiples(length) needed.
        //Step 4: Create an empty array with the size of the length param outside of the loop.
        //Step 5: Convert the double number to an int as the current index and set that as index of the array and populate it with the current multiple.
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        if (amount >= data.Count){
            int index = amount % data.Count;
            List<int> toAppend = data.GetRange(data.Count - index, index);
            data.RemoveRange(data.Count - index, index);
            data.InsertRange(0,toAppend);
        } else{
            List<int> toAppend = data.GetRange(data.Count - amount, amount);
            data.RemoveRange(data.Count - amount, amount);
            data.InsertRange(0,toAppend);
        }
       
    }

    //Plan and Steps to create
    //Understand the logic of rotating. To simplify, moving the first index 3 places means moving the numbers that would go out of bounds to the start of the list. By taking time to understand this process, we can make simply rearrangement of the list.
    //Step 1. Get the modulus of the length/count of the list, so that we either get the number back itself or the remainder if it is divided by itself.
    //Step 2. Create an if statement that takes the values that would be pushed away if the array was to move to the right. Using list.Count and subtracting it with the amount to move. Store these in a list using GetRange so we can append them later.
    //Step 3. Delete from the initial list the range that we stored using GetRange, using RemoveRange.
    //Step 4. Insert this range at index 0 of the initial list.
}
