namespace Text
{
    public class TextHelper
    {
        public string swapLastTwoCharacters(string str)
        {
            int strLength = str.Length;
           
            if(strLength < 2)
                return str;

            char lastChar = str[strLength - 1];
            char secondLastChar = str[strLength - 2];
            string notSwappedPart = str[..(strLength - 3)];

            return $"{notSwappedPart}{lastChar}{secondLastChar}";
        }
    }
}