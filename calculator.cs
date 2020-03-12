class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("1. Penjumlahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");
            Console.Write("Pilihan anda: ");
            int pilihan = Int32.Parse(Console.ReadLine());
            int a, b;
            

            switch (pilihan)
            {
                case 1:
                    Console.Write("input nilai a: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Write("input nilai b: ");
                    b = Int32.Parse(Console.ReadLine());
                    Console.Write("\nnilai {0} + {1} = {2}", a, b, penjumlahan(a, b));
                    break;
                case 2:
                    Console.Write("input nilai a: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Write("input nilai b: ");
                    b = Int32.Parse(Console.ReadLine());
                    Console.Write("\nnilai {0} - {1} = {2}", a, b, pengurangan(a, b));
                    break;
                case 3:
                    Console.Write("input nilai a: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Write("input nilai b: ");
                    b = Int32.Parse(Console.ReadLine());
                    Console.Write("\nnilai {0} x {1} = {2}", a, b, perkalian(a, b));
                    break;
                case 4:
                    Console.Write("input nilai a: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Write("input nilai b: ");
                    b = Int32.Parse(Console.ReadLine());
                    Console.Write("\nnilai {0} : {1} = {2}", a, b, pembagian(a, b));
                    break;
                default:
                    Console.Write("\nMaaf menu yang anda pilih tidak tersedia");
                    break;
            }
           
        }
        
        static int penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
