namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null)
                return 0;
            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }
            length = Math.Sqrt(length);

            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int amin = Math.Min(Q, P);
            int amax = Math.Max(Q, P);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > amin && array[i] < amax)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                int maxIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                        maxIndex = i;
                }

                if (maxIndex < array.Length - 1)
                {
                    int minIndex = maxIndex + 1;
                    for (int i = maxIndex + 2; i < array.Length; i++)
                    {
                        if (array[i] < array[minIndex])
                            minIndex = i;
                    }

                    if (array[minIndex] != array[maxIndex])
                    {
                        int temp = array[maxIndex];
                        array[maxIndex] = array[minIndex];
                        array[minIndex] = temp;
                    }
                }
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                int maxIndex = 0;
                for (int i = 2; i < array.Length; i += 2)
                {
                    if (array[i] > array[maxIndex])
                        maxIndex = i;
                }
                array[maxIndex] = maxIndex;
            }
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == P)
                    {
                        index = i;
                        break;
                    }
          
                }

            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                int maxIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                        maxIndex = i;
                }

                if (maxIndex > 0)
                {
                    for (int i = 0; i < maxIndex - 1; i += 2)
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array != null)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                   
                    if (array[i] >= 0)
                    {
                        count++;

                    }

                }
                answer = new int[count];
                int index = 0;
                for (int i = 0;i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        answer[index++] = array[i];
                    }
                }
            }

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int amin = array[i];
                int imin = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (array[k] > amin)
                    {
                        amin = array[k];
                        imin = k;
                    }
                }
                (array[i], array[imin]) = (array[imin], array[i]);
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here

            {
                int tepm, n = array.Length;
                for (int i = 0; i < n / 2; i++)
                {
                    tepm = array[i];
                    array[i] = array[n - i - 1];
                    array[n - i - 1] = tepm;

                }
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null)
            {
                C = new int[0];
            }
            else if (A == null)
            {
                C = new int[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    C[i] = B[i];
                }
            }
            else if (B == null)
            {
                C = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i];
                }
            }
            else
            {
                C = new int[A.Length + B.Length];
                int index = 0;
                int minLength = A.Length < B.Length ? A.Length : B.Length;

                
                for (int i = 0; i < minLength; i++)
                {
                    C[index] = A[i];
                    index++;
                    C[index] = B[i];
                    index++;
                }

                
                if (A.Length > minLength)
                {
                    for (int i = minLength; i < A.Length; i++)
                    {
                        C[index] = A[i];
                        index++;
                    }
                }
                else if (B.Length > minLength)
                {
                    for (int i = minLength; i < B.Length; i++)
                    {
                        C[index] = B[i];
                        index++;
                    }
                }
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n == 1 && a == b)
            {
                array = new double[] { a };
            }
            else if (n > 1 && a != b)
            {
                array = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw != null && raw.Length >= 3)
            {
                restored = new double[raw.Length];

                
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                }

                
                if (restored[0] == -1.0 && restored[1] != -1.0 && restored[raw.Length - 1] != -1.0)
                {
                    restored[0] = (restored[1] + restored[raw.Length - 1]) / 2.0;
                }

                
                if (restored[raw.Length - 1] == -1.0 && restored[0] != -1.0 && restored[raw.Length - 2] != -1.0)
                {
                    restored[raw.Length - 1] = (restored[0] + restored[raw.Length - 2]) / 2.0;
                }

                
                for (int i = 1; i < raw.Length - 1; i++)
                {
                    double prev = restored[i - 1];
                    double next = restored[i + 1];
                    if (restored[i] == -1.0 && prev != -1.0 && next != -1.0)
                    {
                        restored[i] = (prev + next) / 2.0;
                    }
                }
            }
            // end

            return restored;
        }
    }
}

