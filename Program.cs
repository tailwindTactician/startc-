
// //Task1
/* int even(int a)
 {
     int count = 0;
     int even = 0;
     while (a > 0)
     {
         count = a % 10;
         if (count % 2 == 0)
         {
             even++;
         }
         a = a / 10;
     }
     return even;
 }
 int odd(int a)
 {
     int count = 0;
     int odd = 0;
     while (a > 0)
     {
         count = a % 10;
         if (count % 2 != 0)
         {
             odd++;
         }
         a = a / 10;
     }
     return odd;
 }
 int digit(int a)
 {
     int count = 0;
     int digit = 0;
     while (a > 0)
     {
         count = a % 10;
         digit++;
         a = a / 10;
     }
    return digit;
 }
 int sum(int a)
 {
     int count = 0;
     int sum = 0;
     while (a > 0)
     {
         count = a % 10;
         sum += count;
         a = a / 10;
     }
     return sum;
 }
 int a = Convert.ToInt32(Console.ReadLine());
     System.Console.WriteLine($"Even: {even(a)}");
     System.Console.WriteLine($"Odd: {odd(a)}");
     System.Console.WriteLine($"Digit: {digit(a)}");
     System.Console.WriteLine($"Sum: {sum(a)}");*/
// //Task2

// int sum(int a, int b)
//{
//    int sum = a + b;
//    return sum;
//}
// int sub(int a, int b)
//    {
//        int sub = a - b;
//        return sub;
//    }
// int mul(int a, int b)
//    {
//        int mul = a * b;
//        return mul;
//    }
// int div(int a, int b)
// {
//     int div = a / b;
//     return div;
// }
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Add: {sum(a,b)}");
// System.Console.WriteLine($"Subtract: {sub(a,b)}");
// System.Console.WriteLine($"Multiply: {mul(a,b)}");
// System.Console.WriteLine($"Division: {div(a,b)}");

//Task3

// int mn(int n)
// {
//     int cnt = 0;
//     int mn = 999999999;
//     while (n > 0)
//     {
//         cnt = n % 100;
//         if (cnt < mn)
//             mn = cnt;

//        n = n / 10;
//     }
//      return mn;
// }
// int mx(int n)
// {
//     int cnt = 0;
//     int mx = -999999999;
//     while (n > 0)
//     {
//         cnt = n % 10;
//         if (cnt > mx)
//             mx = cnt;

//         n = n / 10;
//     }
//      return mx;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{mn(n)} + {mx(n)} = {mn(n) + mx(n)}");


//Task4

// int pow(int x, int y)
//{
//    int cnt = 1;
//    for (int i = 0; i < y; i++)
//    {
//        cnt *= x;
//    }
//    return cnt;
//}
// System.Console.Write("x = ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("y = ");
//int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(pow(x, y));
//Task5

// void swap (ref int a, ref int b)
// {
//     int cnt = 0;
//     cnt = a;
//     a = b;
//     b = cnt;
//     System.Console.WriteLine($"X = {a}");
//     System.Console.WriteLine($"Y = {b}");
// }

// System.Console.Write("X = ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Y = ");
// int b = Convert.ToInt32(Console.ReadLine());
// swap(ref a, ref b);


//Task6
// void div(int a)
// {
//     int cnt = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         if (a % i == 0)
//         {
//             System.Console.Write(i + " ");
//         }
//     }   
// }
// int a = Convert.ToInt32(Console.ReadLine());
// div(a);
//task8
//int MinNumber(int a, int b, int c, int d)
//{
//    int minn = a;
//    if (b < minn)
//        minn = b;
//    if (c < minn)
//        minn = c;
//    if (d < minn)
//        minn = d;
//    return minn;
//}
//
//int a = Convert.ToInt16(Console.ReadLine());
//int b = Convert.ToInt16(Console.ReadLine());
//int c = Convert.ToInt16(Console.ReadLine());
//int d = Convert.ToInt16(Console.ReadLine());
//System.Console.WriteLine(MinNumber(a, b, c, d));


//Task9
//
//void mn(int a, int b)
//{
//    if (a > b)
//        System.Console.WriteLine(b);
//    else
//        System.Console.WriteLine(a);
//}
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//mn(a, b);