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
            // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        ///
        // Intialize a list to store the multiples
        List<double> multiples = new List<double>();
        // Loop from 1 to length
        for (int i =1; i <= length; i++)
        {
            // Calculate the multiple and add it.
            multiples.Add(number * i);
        }
        // Convert the list to an array and return it

        return multiples.ToArray(); // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Calculate which index the rotation should start on 
        int rotateIndex = data.Count - amount;

        // Extract the elements to be rotated from the end of the list
        List<int> extractedElements = data.GetRange(rotateIndex, amount);
        // Insert extracted elements to the beginning of the list
        data.RemoveRange(rotateIndex, amount);
        data.InsertRange(0, extractedElements);

    }
}
