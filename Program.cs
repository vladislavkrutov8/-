string[] array1 = new string[8] { "hello", "23", "223", "world", "res", ":-)", "Kazan", "1" }; // Создаем массив из произвольных символов
string[] array2 = new string[array1.Length]; // Создаем второй массив, равный первому по длине 
void SecondArray(string[] array1, string[] array2) // Задаем метод, который будет отбрасывать строки с количестовм знаком >3
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
