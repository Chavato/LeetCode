
namespace exercise2
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string gdr = "";
            string _base = "";
            string[] strSplit1;
            string[] strSplit2;


            if (str1.Length >= str2.Length)
            {
                _base = str2;
                for (int i = 0; i < str2.Length; i++)
                {
                    strSplit1 = str1.Split(_base);
                    strSplit2 = str2.Split(_base);
                    if (!strSplit1.Any(str => str != "") && !strSplit2.Any(str => str != ""))
                    {
                        gdr = _base;
                        break;
                    }

                    _base = _base.Remove(_base.Length - 1);
                }
            }
            else
            {
                _base = str1;
                for (int i = 0; i < str1.Length; i++)
                {
                    strSplit1 = str1.Split(_base);
                    strSplit2 = str2.Split(_base);
                    if (!strSplit1.Any(str => str != "") && !strSplit2.Any(str => str != ""))
                    {
                        gdr = _base;
                        break;
                    }

                    _base = _base.Remove(_base.Length - 1);
                }
            }

            return gdr;
        }
    }
}