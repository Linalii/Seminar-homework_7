int[,] myMatrix = new int[8, 8];
            Random rand = new Random();
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    myMatrix[i, j] = rand.Next(0, 100);
                }
            }
            Console.WriteLine("Изначальная матрица");
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
            }
          
            int minValue = myMatrix[0, 0];
            int minIndex = 0;
            for (int i = 1; i < myMatrix.GetLength(0); i++)
            {
                if (myMatrix[i, i] < minValue)
                {
                    minValue = myMatrix[i, i];
                    minIndex = i;
                }
            }
            Console.WriteLine("Минимальный элемент = {0}", minValue);
            Console.WriteLine("Индекс мин.элемента  [{0},{0}]", minIndex);

            int[,] myMatrixNew = new int[myMatrix.GetLength(0) - 1, myMatrix.GetLength(1) - 1];
            for (int i = 0; i < myMatrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1)-1; j++)
                {
                    if (i < minIndex && j < minIndex)
                        myMatrixNew[i, j] = myMatrix[i, j];
                    if (i >= minIndex && j < minIndex)
                        myMatrixNew[i, j] = myMatrix[i + 1, j];
                    if (i < minIndex && j > minIndex)
                        myMatrixNew[i, j] = myMatrix[i, j + 1];
                    if (i >= minIndex && j > minIndex)
                        myMatrixNew[i, j] = myMatrix[i + 1, j + 1];
                }
            }
            myMatrix = myMatrixNew;

            Console.WriteLine("Матрица после");
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
