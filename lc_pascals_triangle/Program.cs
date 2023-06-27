


Solution.Generate(5);


public class Solution
{
    static public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> pascalsTriangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        // for each row
        {
            IList<int> newRow = new List<int>();
            newRow.Add(1); // first element in row is always 1

            for (int j = 1; j < i; j++)
            // for each element in row
            {
                newRow.Add(pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j]);
            }
            
            if (i > 0)
            // if not the first row
            {
                newRow.Add(1); // last element in row is always 1
            }

            pascalsTriangle.Add(newRow); // add new row to triangle
        }

        return pascalsTriangle;
    }
}