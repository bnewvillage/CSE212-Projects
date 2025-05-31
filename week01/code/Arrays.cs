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

        //To get the multiple of a number at a set amount.
        //We need to only multiply it by a certain length increasing in 1 each iteration.
        //Step 1: Create and empty array with the size of length param.
        //Step 2: Create a for loop that increments in one as long as i or iteration is less than or equal to the length param.
        //Step 3: Set everything to double to match the param, we will convert it to int later on.
        //Step 4: intialize a 'multiple' by multiplying number param by the current iteration or index.
        //Step 5: initialize an index valuable that is i minus one to match the array indexing.
        //Step 6: Array of currrent index value set to the current multiple.
        //Step 7. Return the array.

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