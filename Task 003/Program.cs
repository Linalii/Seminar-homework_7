int[,,] array = new int[2,2,2] {{{12,54},{33,21}},{{62,23},{91,42}}};
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine(array[i, j, k]+" ("+i+","+j+","+k+")");
        }
    }
}