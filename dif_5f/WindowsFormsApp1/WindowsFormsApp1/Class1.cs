using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public class Class1
    {
        List<string> listOfString = new List<string>();
        List<string> listOf = new List<string>();
        public string z(string path)
        {
            string str="";
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] s = line.Split(',');
                    for (int i = 0; i < s.Length; i++)
                    {
                        string s2 = s[i].Substring(0, 1);
                        listOfString.Add($"{s2}");
                        str += $"{s[i]}:{listOfString[i]}*";
                    }
                }
            }
            return $"{str}";
        }
        public string zp(string letter)//Удаление
        {
            string rez = "";
            string t = "info.txt";
            if (File.Exists(t))
            {
                var lines = File.ReadAllLines(t);
                foreach (string line in lines)
                {
                    string[] s = line.Split(',');
                    for (int i = 0; i < s.Length; i++)
                    {
                        listOf.Add($"{s[i]}");
                    }
                }
                Queue<string> listNum = new Queue<string>(listOf);
                List<string> list = new List<string>();
                foreach (var x in listNum)
                {
                    if (!(x.StartsWith(letter)))
                    {
                        list.Add(x);
                    }
                }
                listNum.Clear();
                listNum = new Queue<string>(list);
                foreach (var pers in listNum)
                {
               
                    rez += ($"{pers}*");
                   
                }
              
            }
            return rez;

        }
        public void s(string sl)//Добавление
        {
            string t = "info.txt";
            if (File.Exists(t))
            {
                var lines = File.ReadAllLines(t);
                listOfString.Add(sl);
                File.AppendAllLines(t, listOfString);
            }
        }
    }
}
