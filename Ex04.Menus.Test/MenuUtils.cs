namespace Ex04.Menus.Test
{
    public static class MenuUtils
    {
        public static bool IsEnglishOnly(string i_InputText)
        {
            bool isEnglishLettersOnly = true;

            foreach (char c in i_InputText)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' '))
                {
                    isEnglishLettersOnly = false;
                    break;
                }
            }

            return isEnglishLettersOnly;
        }

        public static int CountLowercaseEnglishLetters(string i_Text)
        {
            int lowercaseCount = 0;

            foreach (char c in i_Text)
            {
                if (char.IsLower(c) && c >= 'a' && c <= 'z')
                {
                    lowercaseCount++;
                }
            }

            return lowercaseCount;
        }
    }
}
