// TASK 3

int[] array = [1, 5, 4, 3, 7, 7, 9];
void reversedArray(int[] array, int i = -1)
{
    if (!(i == array.Length-1))
    {
    reversedArray(array, i += 1);
    Console.Write($"{array[i]} ");
    }
}
reversedArray(array);