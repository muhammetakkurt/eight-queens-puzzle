using System;

namespace _8vezir
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Random r = new Random();
            char[,] tahta = new char[8, 8];
            string a = "";
            string[] b = new string[10000000];
            int x = 0, y;
            int sayac = 0, stc = 0, s = 0,olmaz=1;
            int sayi = 0;
            int son=0;
            int sn = 0;
            for (int u = 0; u < 10000000; u++)
            {
                for (x = 0; x < 8; x++)
                {
                    y = r.Next(8);
                    while (true)
                    {

                        if (tahta[x, 0] == '.' && tahta[x, 1] == '.' && tahta[x, 2] == '.' && tahta[x, 3] == '.' && tahta[x, 4] == '.' && tahta[x, 5] == '.' && tahta[x, 6] == '.' && tahta[x, 7] == '.')
                        {
                            olmaz++;
                            for (int p = 0; p < 8; p++)
                            {
                                for (int w = 0; w < 8; w++)
                                {
                                    if (tahta[p, w] != 'a')
                                    {
                                        tahta[p, w] = ' ';
                                        x = 0;
                                    }
                                }

                                Console.Write("\n");
                            }
                            s = 0;
                            sayac = 0;
                        }
                        else if (tahta[x, y] == '.')
                        {
                            y = r.Next(0, 8);
                            stc++;
                        }
                        else
                        {
                            
                            tahta[x, y] = '!';
                            sayac++;
                            s++;
                            
                            break;
                        }
                    }

                    int q = 1;
                    int l = 1;
                    int nnn = 0;
                    if (tahta[x, y] == '!')
                    {
                        q = y - 1;
                        nnn = y + 1;
                        l = x + 1;
                        while (q >= 0 && l < 8) // to left bottom
                        {
                            tahta[l, q] = '.';

                            q--;
                            l++;
                        }
                        q = y - 1;
                        while (q >= 0) // to left
                        {
                            tahta[x, q] = '.';
                            q--;
                        }
                        l = x + 1;
                        while (nnn < 8 && l < 8) // to rgiht bottom
                        {
                            tahta[l, nnn] = '.';

                            l++;
                            nnn++;
                        }
                        nnn = y + 1;
                        while (nnn < 8) // to right
                        {
                            tahta[x, nnn] = '.';
                            nnn++;
                        }
                        l = x + 1;
                        while (l < 8) // to bottom
                        {
                            tahta[l, y] = '.';
                            l++;
                        }
                    }
                    
                    }
                   
                        int m;
                        int n = 0;
                        int k = 1, o;
                        Console.Clear();
                        for (int p = 0; p < 8; p++)
                        {
                           
                            
                            o = k;
                            for (int w = 0; w < 8; w++)
                            {
                               
                                if (tahta[p, w] == '!')
                                {
                                    m = w;
                                    m++;
                                    n = p;
                                    n++;
                                    a += Convert.ToString("[" + m + "],");
                                }
                            }
                            
                        }
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if ((i + j) % 2 == 0)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(tahta[i, j] + " ");
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(tahta[i, j] + " ");
                                }
                            }
                            Console.WriteLine();
                        }

                        for (int snc = 0; snc < sayi; snc++)
                        {
                            if (b[snc] != null)
                            {
                                son++;
                                if (son == 93)
                                {
                                   
                                }
                                Console.WriteLine("\n"+b[snc]+"    "+son);
                                if (b[snc] == a)
                                {
                                    Console.WriteLine("Aynı İhtimal");
                                    b[sayi] = b[snc];
                                    b[snc] = null;
                                    
                                    break;
                                }
                                else if (b[snc] != a)
                                {
                                    sn++;
                                } 
                            }

                            
                        }
                        b[sayi] = a;
                        sayi++;
                       Console.WriteLine("\nVezirlerin yeri : " + a + "\nDoğruyu bulmak için baştan " + olmaz + " kere denedi.");
                        Console.Write("Bilgisayar 8 Adet vezirini birbirlerini yemeyecek \nşartıyla yerleştirdi. " + sn);
                        son = 0;
                        sn = 0;
                        Console.WriteLine(" Devam etmek için bir tuşa basın . .");


                        Console.ReadKey();
                            Console.Clear();
                            for (int p = 0; p < 8; p++)
                            {
                                for (int w = 0; w < 8; w++)
                                {
                                    if (tahta[p, w] != 'a')
                                    {
                                        tahta[p, w] = ' ';
                                        x = -1;
                                        sayac = 0;
                                        olmaz = 1;
                                        a = "";
                                    }

                                }
                        }
                  }
                  
        }
    }
}


