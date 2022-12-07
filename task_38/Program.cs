//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76



double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)     //Метод создания массива и заполнения его случайными числами (вещественными)
{
    Console.Clear();

    Random rand = new Random();

    double[] arr = new double[size];                                                   // Объявление пустого массива

    for (int i = 0; i < arr.Length; i++)                                               // Цикл перебора значений массива
    {
        arr[i] = rand.Next(leftRange, rightRange) * rand.NextDouble();                 // Генерация случайного значения элемента массива в заданных границах (положительные)

        double sign = rand.NextDouble();                                                // Генерация случайного значения 

        if (sign > 0.5) arr[i] = arr[i] * -1;                                           // Присвоение случайного знака значению

        arr[i] = Math.Round(arr[i], 2);                                                 // Округление значения до двух знаков после запятой
    }

    return arr;
}

int FindMaxIndexInArray(double[] arr)                                                   // Метод поиска индекса максимального числа в массиве
{
    int maxIndex = 0;                                                                   // Переменная для хранения индекса максимального числа в массиве

    double maxNumber = arr[maxIndex];

    for (int i = 1; i < arr.Length; i++)                                                // Цикл перебора значений массива
    {
        if (arr[i] > maxNumber)                                                         // Проверка на максимальность элемента массива и изменение индекса максимального числа в массиве
        {
            maxIndex = i;

            maxNumber = arr[i];
        }
    }

    Console.WriteLine("В массиве: [" + string.Join("; ", arr) + "] индекс максимального числа в массиве  " + maxIndex);   //Вывод индекса максимального числа в массиве в консоль

    return maxIndex;
}

int FindMinIndexInArray(double[] arr)                                                    // Метод поиска индекса минимального числа в массиве
{
    int minIndex = 0;                                                                    // Переменная для хранения индекса минимального числа в массиве

    double minNumber = arr[minIndex];

    for (int i = 1; i < arr.Length; i++)                                                 // Цикл перебора значений массива
    {
        if (arr[i] < minNumber)                                                          // Проверка на минимальность элемента массива и изменение индекса минимального числа в массиве
        {
            minIndex = i;

            minNumber = arr[i];
        }
    }

    Console.WriteLine("В массиве: [" + string.Join("; ", arr) + "] индекс минимального числа в массиве  " + minIndex);   //Вывод индекса минимального числа в массиве в консоль

    return minIndex;
}

void ValueDifferenceMaxMinDigitalInArray(double[] arr, int max, int min)                  // Метод вычисления разницы между максимальным и минимальным значением элементов
{
    double difference = arr[max] - arr[min];

    difference = Math.Round(difference, 2);                                                 // Округление значения до двух знаков после запятой

    Console.WriteLine("В массиве: [" + string.Join("; ", arr) + "] разница между максимальным и минимальным значением элементов равна:  " + difference);   //Вывод разницы между максимальным и минимальным значением элементов
}

//----------------------------------------------------------

int size = 5;                                                                // Размер задаваемого массива
int lRange = 1;                                                              // Левая граница полуотрезка для заполнения массива 
int rRange = 10;                                                             // Правая граница полуотрезка для заполнения массива

double[] array = FillArrayWithRandomNumbers(size, lRange, rRange);           // Введение данных в метод создания и заполнения массива случайными числами

ValueDifferenceMaxMinDigitalInArray(array, FindMaxIndexInArray(array), FindMinIndexInArray(array));  // Введение данных в метод вычисления разницы между максимальным и минимальным значением элементов