using System;
using System.Globalization;
using System.Linq.Expressions;

namespace YouTube_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //a = 5;
            //Console.WriteLine(a);

            //string data;
            //data = Console.ReadLine();
            //Console.WriteLine("Hi "+ data);


            //int a, b;
            //Console.WriteLine("Please, input the first number");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please, input the second number");
            //b = Convert.ToInt32(Console.ReadLine());
            //int result = a + b;
            //Console.WriteLine("The summ of this numbers - " + result);

            //string str = "1/3";
            //NumberFormatInfo numberFormat = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = "/"
            //};
            //double c = Convert.ToDouble(str, numberFormat);
            //Console.WriteLine(c);

            //string str = "5/7";
            //NumberFormatInfo numberFormat = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = "/"
            //};
            //double a = double.Parse(str, numberFormat);

            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //}
            //catch { 
            //    Console.WriteLine("An error while converting");
            //}

            //string str = "5fg";
            //int a;
            //bool result = int.TryParse(str, out a); // Закинет новое значение в a, если успешно
            //// Если не успешно - в а будет 0
            ////result - переменная успеха выполнения операции
            //Console.WriteLine(a + " " + result);

            /*----------ДЗ Среднее арифметическое 2х чисел---------*/
            //int a, b;
            //Console.WriteLine("Input first number");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input second number");
            //b = int.Parse(Console.ReadLine());
            //double result = (double) (a + b) / 2;
            //Console.WriteLine("The adv is - " + result);


            /*----------ДЗ Сумма и произведение 3х чисел---------*/
            //int a, b, c;
            //Console.WriteLine("Input first number");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input second number");
            //b = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Input therd number");
            //c = int.Parse(Console.ReadLine());
            //int sum = a + b + c;
            //int mult = a * b * c;

            //Console.WriteLine("The sum is - " + sum);
            //Console.WriteLine("The mult is - " + mult);


            /*----------ДЗ Конвертер валют---------*/
            //double input;
            //Console.WriteLine("Input amount of money in rubbls");
            //input= double.Parse(Console.ReadLine());
            ////Console.WriteLine("Choose valut /t IS - chekel /t US - dollar /t EU - euro");
            ////string valut = Console.ReadLine();
            ////switch (valut) {}
            //double curs = 17.2;
            //double output = input / curs;
            //Console.WriteLine("You will resive " + output + " shekels");

            /*----------ДЗ Проверка на четность---------*/
            //int a = 0;
            //bool checker = true;
            //Console.WriteLine("Input a number");
            //while (checker)
            //{
            //    try
            //    {
            //        int iside_a = int.Parse(Console.ReadLine());
            //        checker = false;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("You make a mistake, please make an input one time more");
            //        if (e.InnerException != null)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            continue;
            //        }

            //    }
            //}

            //if(a % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //} else
            //{
            //    Console.WriteLine("th number is not even");
            //}



            /*----------ДЗ Калькулятор---------*/
            //Console.WriteLine("Input a first number");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input a second number");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input an oprator: + - * /");
            //string oper = Console.ReadLine();
            //double result;
            //switch(oper) {
            //    case "*":
            //        result = a * b;
            //        Console.WriteLine("The result of multiplying is - " + result);
            //        break;
            //    case "+":
            //        result = a + b;
            //        Console.WriteLine("The result of adding is - " + result);
            //        break;
            //    case "-":
            //        result = a - b;
            //        Console.WriteLine("The result of sustracting is - " + result);
            //        break;
            //    case "/":
            //        result = (double)a / b;
            //        Console.WriteLine("The result of dividing is - " + result);
            //        break;
            //    default:
            //        Console.WriteLine("You make a wrong choice");
            //        break;
            //}


            /*----------ДЗ Массив с клавиатуры---------*/
            //int[] myArr = new int [5];
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    myArr[i]=int.Parse(Console.ReadLine()); 
            //}
            /*----------ДЗ Массив в обартном порядке---------*/
            //for (int i = myArr.Length -1 ; i >= 0; i--)
            //{
            //    Console.WriteLine("The reverse element - " + myArr[i]);
            //}
            /*----------ДЗ Массив в обартном порядке---------*/
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    if (myArr[i]%2 == 0)
            //    {
            //        Console.WriteLine(myArr[i]);
            //    }
            //}
            /*----------ДЗ Массив наименьший эл-т---------*/
            //int min = myArr[0];
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    if (myArr[i] < min)
            //    {
            //        min = myArr[i];
            //    }
            //}
            //Console.WriteLine(min);


            /*----------ДЗ Метод вывода знака нужное кол-во раз---------*/
            //Console.WriteLine("Input an element");
            //char elem = char.Parse(Console.ReadLine());
            //Console.WriteLine("Input an quntity");
            //int qunt = int.Parse(Console.ReadLine());
            //Console.WriteLine("The result:");
            //PrintMeth(elem, qunt);

            /*----------ДЗ Метод поиска индекса значения в массиве---------*/
            //int[] myArr = new int[5];

            //for (int i= 0; i<myArr.Length; i++)
            //{
            //    Console.WriteLine("Input an element " + i);
            //    myArr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Input an element to find");
            //int elem = int.Parse(Console.ReadLine());
            //FindElem(myArr, elem);

            /*----------ДЗ Метод изменяющий кол-во эл-тов в массиве---------*/
            //int[] arr = new int[10];
            //Console.WriteLine("Please, input the number");
            //int count = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, choose the direction: +/-");
            //string direction = Console.ReadLine();

            //Resize(ref arr, count, direction);



            /*----------ДЗ Метод добавляющий эл-т в массив---------*/
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine("Please, input the number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, input the index");
            //int ind = int.Parse(Console.ReadLine());


            //arr = AddToArr(arr, num, ind);
            //arr = DelFromArr(arr, num, ind);


            /*----------ДЗ Вывод и сумма эл-в массива с помощью рекурсии---------*/
            //int[] arr = { 1, 2, 3, 4 };
            //PrintAndSum(arr);


            /*----------ДЗ сумма цифра числа с помощью рекурсии---------*/
            int num = 561;
            SumNumber(num);

            Console.ReadLine();







        }

        /*----------ДЗ Метод вывода знака нужное кол-во раз---------*/
        //static void PrintMeth (char _elem, int _qunt)
        //{
        //    for (int i = 0; i < _qunt; i++)
        //    {
        //        Console.Write(_elem);
        //    }
        //}


        /*----------ДЗ Метод поиска индекса значения в массиве---------*/
        /// <summary>
        /// Some text
        /// </summary>
        /// <param name="_myArr"></param>
        /// <param name="_elem"></param>
        //static void FindElem(int[] _myArr, int _elem)
        //{
        //    int index = -1;
        //    for (int i=0;i<_myArr.Length;i++)
        //    {
        //        if (_myArr[i] == _elem)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    if(index > 0)
        //    {
        //        Console.WriteLine("The index of" + _elem + "is" + index);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No such element in the array");
        //    }
        //}


        /*----------ДЗ Метод изменяющий кол-во эл-тов в массиве---------*/
        //static void Resize(ref int[] _arr, int _count, string _direction)
        //{
        //    int new_count = _arr.Length;
        //    switch (_direction)
        //    {
        //        case "+":
        //            new_count += _count;
        //            break;
        //        case "-":
        //            new_count -= _count;
        //            break;
        //    }
        //    _arr = new int[new_count];
        //}


        /*----------ДЗ Метод добавляющий эл-т в массив---------*/
        //static int[] AddToArr(int[] _arr, int _num, int _ind)
        //{
        //    int[] new_arr = new int[_arr.Length + 1];
        //    for(int i = 0, j = 0; i < new_arr.Length; i++, j++)
        //    {
        //        if (i == _ind)
        //        {
        //            new_arr[i] = _num;
        //            j--;
        //            continue;
        //        }
        //        new_arr[i] = _arr[j];

        //    }
        //    return new_arr;
        //}

        //static int[] DelFromArr(int[] _arr, int _num, int _ind)
        //{
        //    int[] new_arr = new int[_arr.Length - 1];
        //    for (int i = 0, j = 0; j < _arr.Length; i++, j++)
        //    {
        //        if (i == _ind)
        //        {
        //            j++;
        //            new_arr[i] = _arr[j];
        //            continue;
        //        }
        //        new_arr[i] = _arr[j];

        //    }
        //    return new_arr;
        //}


        /*----------ДЗ Вывод и сумма эл-в массива с помощью рекурсии---------*/
        //static void PrintAndSum(int[] _arr, int _index = 0, int _sum = 0)
        //{

        //    if (_index < _arr.Length)
        //    {
        //    Console.WriteLine("The " + _index + " element is " + _arr[_index]);
        //    _sum += _arr[_index];
        //    _index++;
        //    if(_index == _arr.Length)
        //        {
        //            Console.WriteLine("The sum is " + _sum);
        //        }
        //    PrintAndSum(_arr, _index, _sum);
        //    }
        //    return;
        //}


        /*----------ДЗ сумма цифра числа с помощью рекурсии---------*/
        static void SumNumber(int _num, int _index = 0, int _sum = 0)
        {
            string arr = _num.ToString();

            if (_index < arr.Length)
            {
                char a = arr[_index];
                int elem = Convert.ToInt32(char.GetNumericValue(arr[_index]));
                _sum += elem;
                _index++;
                if (_index == arr.Length)
                {
                    Console.WriteLine("The sum is " + _sum);
                }
                SumNumber(_num, _index, _sum);
            }
            return;
        }



    }
}
