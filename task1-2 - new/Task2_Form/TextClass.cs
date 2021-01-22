using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Task2_Form
{
    public class TextClass
    {
        public string textFromFile;

        public TextClass(string textFromFile)
        {
            this.textFromFile = textFromFile;
        }
        
        private Boolean CheckEl(char el, char[] mat)
        {
            for (int i = 0; i < mat.Length; i++)
            {
                if (el == mat[i])
                {
                    return false;
                }
            }

            return true;
        }

       
        
        public  string ConvertInStr(List<char> mas)
        {
            string str="";
            for (int i = 0; i < mas.Count; i++)
            {
                str+= mas[i] + " ";
            }

            return str;
        }
        

        private List<char> InList(char[] outList)
        {
            List<char> answer=new List<char>();
            for (int i = 0; i < outList.Length; i++)
            {
                answer.Add(outList[i]);
            }

            return answer;
        }
        
        public  List<char> Function3(char[] text)
        {
            List<char> answer = new List<char>();
            
            char[] outList=new char[text.Length];
            int k = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (CheckEl(text[i], outList))
                {
                    answer.Add(text[i]);
                    outList[k] = text[i];
                    k++;
                }
            }
         
            return answer;
        }

        public List<char> Function1(char[] text)
        {
            char[] outList=new char[Function3(text).Count];
            int n = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (CheckEl(text[i], outList))
                {
                    outList[n] = text[i];
                    n++;
                }
            }
            
            for (int i = 0; i < outList.Length - 1; i++)
            {
                for (int k = i + 1; k < outList.Length; k++)
                {
                    if (outList[i] > outList[k])
                    {
                        char t;
                        t = outList[i];
                        outList[i] = outList[k];
                        outList[k] = t;

                    }
                }
            }

            List<char> answer = InList(outList);
          
            return answer;
        }
        
        public List<char> Function2(char[] text)
        {
            char[] outList=new char[Function3(text).Count];
            int n = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (CheckEl(text[i], outList))
                {
                    outList[n] = text[i];
                    n++;
                }
            }
            
            for (int i = 0; i < outList.Length - 1; i++)
            {
                for (int k = i + 1; k < outList.Length; k++)
                {
                    if (outList[i] < outList[k])
                    {
                        char t;
                        t = outList[i];
                        outList[i] = outList[k];
                        outList[k] = t;

                    }
                }
            }

            List<char> answer = InList(outList);
          
            return answer;
        }
        

       /* public void TextMain()
        {
            char[] text = textFromFile.ToCharArray();
            List<char> ans=new List<char>();
            switch (function)
            {
                case 1:
                    ans = Function1(text);
                    break;
                case 2:
                    ans = Function2(text);
                    break;
                case 3:
                    ans = Function3(text);
                    break;
                default:
                    Console.Write("Неизвестная команда");
                    break;

            }
            string an = ConvertInStr(ans);
            Console.Write(an);
            System.IO.File.WriteAllText(@"C:\Users\HP\RiderProjects\tasks\taskOne\output.txt", ConvertInStr(ans));
        }*/
    }
}