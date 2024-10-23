using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexertask1
{
     class ListInt
    {
        int[] arrs = new int[4];
        public int this[int index]
        {
            get
            {
                return arrs[index];
            }
            set
            {
                arrs[index] = value;
            }
        }

        public void Resize(int arrSize)
        {
            int[] arrs2 = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                arrs2[i] = arrs[i];
            }
            arrs = arrs2;
        }
        public void Add(int num)
        {
            Resize(num);
            arrs[arrs.Length - 1] = num;

        }
        public void Add(params int[] nums)
        {
            int currentLength = arrs.Length;
            Array.Resize(ref arrs, arrs.Length + nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                arrs[currentLength + i] = nums[i];
            }

        }
        public bool Contains(int num)
        {
            bool IsStatus = false;
            for (int i = 0; i < arrs.Length; i++)
            {
                if (num == arrs[i])
                {
                    Console.WriteLine(!IsStatus);
                    break;
                }
                else
                {
                    Console.WriteLine(IsStatus);
                    break;
                }
            }
            return IsStatus;
        }

        public int Pop()
        {
            int num = arrs[arrs.Length - 1];
            Array.Resize(ref arrs, arrs.Length - 1);
            Console.WriteLine($"Silinmis eded:{num}");
            return num;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < arrs.Length; i++)
            {
                sum += arrs[i];
            }
            Console.WriteLine($"cem:{sum}");
            return sum;
        }
        public override string ToString()
        {
            if (arrs.Length == 0)
            {
                return string.Empty;
            }
            string Line = "";
            for (int i = 0; i < arrs.Length; i++)
            {
                Line += arrs[i].ToString();

                if (i < arrs.Length - 1)
                {
                    Line += "-";
                }
            }
            return Line;
        }

        public int IndexOf(int num)
        {
            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrs.Length; i++)
            {
                if (value == arrs[i])
                {
                    Console.WriteLine($"Eded {i} siradadi");
                }
                else
                {
                    Console.WriteLine("Daxil edilen deyer Arrayda movcud deyil !");
                    break;
                }
            }
            return value;
        }
        //public void LastIndexOf(int num)
        //{
        //    for (int i = 0; i < arrs.Length; i++)
        //    {
        //        i=arrs.Length-1;
        //        if (arrs[i] == num)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;

        //} ?
        // LastIndexOf(int num) - Göndərilən elementin sonuncu indeksini geri qaytarır
    }
}

