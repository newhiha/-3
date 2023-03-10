// See https://aka.ms/new-console-template for more information
//Задание 1
//int[] mas = new int[5] {1,5,8,-3,6};
//for (int i=0; i < 5; i++)
//{
//    Console.WriteLine($"mas[{i}]=");
//    Console.WriteLine(mas[i]);
//}

//int max =mas[0];
//foreach(int i in mas)
//    if ( i> max) max = i;
//Console.WriteLine("max="+max);

//Задание 2
//int[] mas = new int[3] { -1, 5, 10 };

//for ( int i= 0; i < mas.Length; i++)
//{
//    Console.WriteLine($"mas[{i}]=");
//    Console.WriteLine(mas[i]); 
//} 

//int max= mas[0];
//foreach (int i in mas)
//    if (i > max) max=i;
//Console.WriteLine("max="+max);

//int min = mas[1];
//foreach (int j in mas)
//    if (j < min) min = j;
//Console.WriteLine("min=" + min);

//Задание 3
//int[] mas = new int[5] { 1, 5, 6, 7, 4, };

//for(int i=0;i< mas.Length;i++)
//{
//    Console.WriteLine($"mas[{i}]=");
//    Console.WriteLine(mas[i] + " ");
//}
//Console.WriteLine(" ");

//int max = 0, min = 0;

//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] > mas[max])
//        max = i;
//    if (mas[i] < mas[min])
//        min = i;
//}

//Console.WriteLine("min : array[" + min + "] = " + mas[min]);
//Console.WriteLine("max : array[" + max + "] = " + mas[max]);

//int prod = 1, mol= Math.Min(min, max) + 1, bg = Math.Max(min, max) - 1;
//for (int i = mol; i <= bg; i++)
//{
//    prod *= mas[i];
//}

//Console.WriteLine("prod from " + mol + " to " + bg + " : " + prod);// интернет помог( сам не знал)
//Задание 4
//int[] mas = new int[5];

//for (int i = 0; i <=4; i++)
//{
//    Console.WriteLine($"mas[{i}]=");
//    mas[i] = int.Parse(Console.ReadLine());
//}



//int max = mas[0];
//foreach (int i in mas)
//    if (i > max) max = i;
//Console.WriteLine("max=" + max);

//for (int i = 0; i <= 4; i++)
//{
//    mas[i] += max;
//}

//for (int i = 0; i <= 4; i++)
//{
//    Console.WriteLine($"mas[{i}]={mas[i]}");    
//}
//Console.ReadKey();





