
namespace exercise2
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string gdr = "";
            string _base = "";
            string[] strSplit;


            if (str1.Length >= str2.Length)
            {
                _base = str2;
                for (int i = 0; i < str2.Length; i++)
                {
                    strSplit = str1.Split(_base);
                    if (!strSplit.Any(str => str != ""))
                        gdr = _base;

                    _base = _base.Remove(_base.Length - 1);
                }
            }
            else
            {
                _base = str1;
                for (int i = 0; i < str1.Length; i++)
                {
                    strSplit = str2.Split(_base);
                    if (!strSplit.Any(str => str != ""))
                        gdr = _base;

                    _base = _base.Remove(_base.Length - 1);
                }
            }

            return gdr;
        }

    }
}