


Solution.Generate(2);


public class Solution
{
    static public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> pascalsTriangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        // for each row
        {
            IList<int> newRow = new List<int>();
            newRow.Add(1);

            // IF (i < 2)
            //      init newRow with (i + 1) 1's
            // ELSE
            //      

            pascalsTriangle[i] = newRow; // add new row to triangle
        }

        return pascalsTriangle;
    }
}