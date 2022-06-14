 static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            /*
             Перебирает старый массив до тех пор пока мы не наталкнемся на элемент который мы должны
             удалить
             */
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            /*
             дописать в наш новый массив все элементы старого массива после элемента под индексом 
             который нам нужно игнорировать.
             Начальной точкой будет элемент индекса который мы хотим удалить +1 (отсутпить на 1 элемент вперед)
             */
            for (int i = index + 1; i < array.Length; i++)
            {
                /* 
                1 - newArray[i - 1] Потому-что в новом массиве у нас на 1 элемент меньше(мы его удалили)
                 соотвественно и индексы сдвигаются
                2 - Таким образом из нашего старого массива array[i] мы извлекаем элемент под индексом n
                а в newArray[i - 1] мы помещяем жлемент под индексом n-1 (смещяемся на 1 индекс назад)
                 */

                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
        static void RemoveFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }
        static void RemoveLast(ref int[] array)
        {
            // - 1 получим индекс самого последнего элемента. 
            /* В массиве 4 элемента индексы 0,1,2,3. Самый последний элемент под индексом 3, всего элементов 4
            и если мы всегда знаем кол-во элементов в нашем массиве отняв еденицу мы узнаем индекс последнего элемента  
            */
            RemoveAt(ref array, array.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2 };

            RemoveAt(ref myArray, 2);
        }
    }

=================================================================================================================================================================================

 class Program
    {
        static void Insert(ref int[] myArr, int value, int index)
        {
            // создадим новый массив + на 1 элемент больше исходного
            int[] newArr = new int[myArr.Length + 1];
            // поместим новый элемент
            newArr[index] = value;

            // перебрать все элементы, до того, как мы доберемся до индекса, где у нас уже новый элемент, который мы уже вставили
            for (int i = 0; i < index; i++)
            {
                // в наш новый массив по текущему индексу присваивать элементы старого массива
                newArr[i] = myArr[i];
            }

            /* 1 - Начинает свое движение от того индекса по которому мы вставляли новый элемент в массив 
               2 - И итерироваться этот цыкл будет до того момента пока не переберет все элементы старого массива  
                   (потому-что в нашем старом массиве ещё могут остаться те элементы которые были после элемента (index)
                    который мы присвоили по новому индексу) 
            */
            for (int i = index; i < myArr.Length; i++)
            {
                // сдвигаем индекс на одну единицу, чтобы старый не затирать
                newArr[i + 1] = myArr[i];
            }
            // в наш старый массив скопировать данные из нового
            myArr = newArr;

        }
        static void AddFirst(ref int[] myArr, int value)
        {
            Insert(ref myArr, value, 0);
        }

        static void AddLast(ref int[] myArr, int value)
        {
            Insert(ref myArr, value, myArr.Length);
        }
        static void Main(string[] args)
        {

            int[] arr = { 1, 4, 5, 6 };
            AddLast(ref arr, 7);
        }
    }

=================================================================================================================================================================================
        
static void Resize<T>(ref T[] array, int newSize)
        {
           // мы не можем скопировать старые данные в новые. Мы должны создать новый массив, это и делаем
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                // перебираем элементы старого массива и копируем в новый массив
                newArray[i] = array[i];
            }
            // заменяем ссылку старого массива (array) на новый (newArray)
            array = newArray;
        }
        static void Main(string[] args)
        {
            string[] arr = { "hello", "world", "2022"};

            Resize(ref arr, 10);

=================================================================================================================================================================================

static int IndexOf(int[] arr, int value)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        static int[] GetRandomArr(uint lenght, int minValue, int maxValue)
        {
            int[] arr = new int[lenght];
            Random rnd = new Random();  
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] myArr =GetRandomArr(10, -20, 10);
            int res = IndexOf(myArr, 1);
            Console.WriteLine(res);
        }

=================================================================================================================================================================================

class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // 4 ej 5 tox amen eji mej 
            int[][][] arr = new int[random.Next(4, 6)][][];

            for (int i = 0; i < arr.Length; i++)
            {
                // eji mej 2 sic sksac toxer u mijev 5 boy
                arr[i] = new int[random.Next(2, 6)][];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = new int[random.Next(3, 6)];

                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        arr[i][j][k] = random.Next(100);
                    }
                }
            }
            // перебирает страницы
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Page N " + (i + 1));
                // перебираем сами строки
                for (int j = 0; j < arr[i].Length; j++)
                {
                    // перебираем элементы в строке
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        Console.Write(arr[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

=================================================================================================================================================================================

class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] arr = new int[4, 3, 5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = random.Next(500);
                    }
                }
            }
            // перебирает страницы
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Page N " + (i + 1));
                // перебираем сами строки
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // перебираем элементы в строке
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(" ");
            }
        }
 
=================================================================================================================================================================================

// Один листочек нашей тетрадки
            int[,] arr = new int[3, 5];
            // трехмерный первое значение отвечает за лист | второе за строку | третье за столбец
            int[,,] arr2 = new int[4, 6, 7];
            // четырехмерное добавились полки. Первое значение кол-во полок в которых по второе значение и в каждом
            // втором значении есть поля на столько значения и в колонок(последнее значение)
            int[,,,] arr3 = new int[5, 4, 3, 2];

{
            int[][] arr = new int[3][];
            arr[0] = new int[10];
            arr[1] = new int[5];
            arr[2] = new int[2];

            Random rand = new Random(); 

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(100);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

=================================================================================================================================================================================

int[,] arr = new int[2,3];
            

            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.WriteLine($"Y : {y} || X : {x}");
                    arr[y, x] = int.Parse(Console.ReadLine());
                }
            }

Random r = new Random();

        for (int y = 0; y < arr.GetLength(0); y++)
        {
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                arr[y, x] = r.Next(0,2);
            }
        }
 int[,] arr =
            {
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 11,12,13,14,15},
                { 11,12,13,14,15},
                { 11,12,13,14,15}
            };

            // Y высота
            // X длина
            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.Write(arr[y, x] + "\t");
                }
                Console.WriteLine();
            }

=================================================================================================================================================================================
 
Console.WriteLine("Enter size array");

            int enumElements = int.Parse(Console.ReadLine());

            int[] arr = new int[enumElements];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter array index {i}");
                arr[i] = int.Parse(Console.ReadLine());
            }

Console.WriteLine("Array output");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

Console.WriteLine("Reverse array output");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

Console.WriteLine("Array output even numbers");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

Console.WriteLine("Array output odd numbers");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
 
         int count = 0;
 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count += arr[i];
                }
            }
 
 Console.WriteLine("Sum even numbers" + count);

            int[] arr = { 45, 65, 4, 87, 12, 6, 2, 45, 7, 7 };

            int minValue = arr[0];
            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    maxValue = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
          Console.WriteLine(minValue);
          Console.WriteLine(maxValue);
}
