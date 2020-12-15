using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace эвм7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Равно: "+File.ReadAllText("input.txt").Split(' ','.','\n').Count(s => s.Length <= 4 && s.Length>1)+"\n");
            char[] A = "BCDFGHJLKMNPQRSTVWXZ".ToCharArray();
            char[] a = "bcdfghjlkmnpqrstvwxz".ToCharArray();
            string[] slova = File.OpenText("input.txt").ReadToEnd().Replace("\r\n", " ").Split(' ');
            string[] slova2 = File.OpenText("input.txt").ReadToEnd().Replace("\r\n", " ").Split(' ');
            int count = 2;
            //int count = 2;
            //foreach (var p in slova2)
            //{
            //    char[] b = p.ToCharArray();
            //    int count1 = 0;
            //    if (p.Length <= 4 && p.Length > 1)
            //    {
            //        for (int o = p.Length; o > 0; o--)
            //            if (b[o] > 57)
            //                count1++;
            //        if(count1<=4 && count1!=0)
            //            count++;
            //    }        
            //}
            //Console.WriteLine(count);
            foreach (var s in slova)
            {
                char[] b=s.ToCharArray();
                int n = 0;
                while(n<20)
                {
                    if (b[0] == A[n])
                    {
                        b[0] = a[n];
                        break;
                    }
                    n++;
                }
                for(int g=0;g<s.Length;g++)
                    Console.Write(b[g]);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            string[] predlosenie = File.OpenText("input.txt").ReadToEnd().Replace("\r\n", " ").Split('.');
            foreach (var s in predlosenie)
            {
                char[] b = s.ToCharArray();int i = 0;
                for (i = 0; i < s.Length; i++)
                {
                    if (b[i] == ':')
                        goto loop;
                }

                if (s == predlosenie[predlosenie.Length-1])
                    Console.WriteLine(s);
                else
                    Console.Write(s + ".");
            loop:;
            }

            Console.WriteLine();
            string[] predlosenie2 = File.OpenText("input.txt").ReadToEnd().Replace("\r\n", " ").Split('.',';');
            string[] x = new string[2];
            for(int i=1,j=0;i>-1;i--,j++)
            {
                x[j] = predlosenie2[i];
            }
            for(int i=0;i<2;i++)
            {
                Console.Write(x[i] + ". ");
            }
            Console.WriteLine("\n");
            string[] u = File.OpenText("input.txt").ReadToEnd().Split('\n');
            foreach(var s in u)
            {
                char[] P = s.ToCharArray();
                for(int i=0;i<s.Length;i++)
                {
                    if (P[i] > 47 && P[i] < 58 && P[i + 1] > 47 & P[i + 1] < 58 && (P[i-1]>58 || P[i-1]<47) && (P[i+2]>58 || P[i+2]<47))
                        Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
	}
}
