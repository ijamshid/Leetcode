public class Solution
{
    public int MinMaxDifference(int num)
    {

        string number = num.ToString();
        char a = ' ';
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] != '9')
            {
                a = number[i];
                break;
            }
        }
        string MaxNum = "";
        string MinNum = "";
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == a)
            {
                MaxNum += "9";
            }

            else
            {
                MaxNum += number[i];
            }

        }
        a = number[0];
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == a)
            {
                MinNum += "0";
            }

            else
            {
                MinNum += number[i];
            }

        }
        int max = Convert.ToInt32(MaxNum);
        int min = Convert.ToInt32(MinNum);
        return max - min;
    }
}
