class PalindromeCheck
    {
        bool solution(string inputString)
        {

            char[] temp = inputString.ToCharArray();
            Array.Reverse(temp);
            string inStr = new string(temp);

            if (inputString.ToLower().Equals(inStr.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
