using System;
using System.Linq;

namespace Cards_Logic_LuhnsAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] A_E = { "34", "37"};
            string[] M_C = { "51", "52", "53", "54", "55"};
            string[] V_C = { "4" };

            double number_org;
            bool input_t = false;
            int[] Digits;
            int odd_sum=0;
            int even_sum=0;
            bool switchh= true;
            Console.WriteLine("Enter you card number");
            do
            {

            
            try
            {
                 number_org = Convert.ToDouble(Console.ReadLine());
                    string a = number_org.ToString();
                    Digits = new int[a.Length];
                    for (int i = 0; i < a.Length; i++)
                    {
                        int temp = Convert.ToInt32(a[i].ToString());

                        if (switchh == true)
                        {
                            string Temp_N = (temp * 2).ToString();
                            foreach (var item in Temp_N)
                            {
                                odd_sum += Convert.ToInt32(item.ToString());
                            }
                            
                            
                            switchh=false;
                            continue;

                        }
                        even_sum += (temp );
                        switchh = true;
                        

                    }

                    string total = (even_sum + odd_sum).ToString();

                   char Last = total[total.Length - 1];
                    string StartDigits = ""+a[0]+""+ a[1]+"";
                    if (Last =='0')
                    {
                        Console.WriteLine("Valid Number");

                        if (a.Length == 15 && (A_E.Contains(StartDigits)))
                        {
                            Console.WriteLine("American Express Card");
                        }
                        else if (((a.Length == 13)|| (a.Length == 16)) && (M_C.Contains(StartDigits)))
                        {
                            Console.WriteLine("Master Card");
                        }
                        else { Console.WriteLine("Visa Card"); }



                    }
                    
                   
                    input_t = true;
            }
            catch (Exception)
            {

                Console.WriteLine("Only Enter Neumeric Digits");

            }
            
            } while (input_t == false);

            

        }
    }
}
