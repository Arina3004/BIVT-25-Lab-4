namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i] * vector[i];
            }
            length = Math.Sqrt(sum);
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
                int imax = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[imax])
                        imax = i;
                }

                if (imax < array.Length - 1)
                {
                    imax = imax + 1;
                    for (int i = imax + 2; i < array.Length; i++)
                    {
                        if (array[i] < array[imax])
                            imax = i;
                    }

                    if (array[imax] != array[imax])
                    {
                        int temp = array[imax];
                        array[imax] = array[imax];
                        array[imax] = temp;
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
                int imax = 0;
                for (int i = 2; i < array.Length; i += 2)
                {
                if (array[i] > array[imax])
                {
                    imax = i;
                }  
            
                    array[imax] = imax;
                }
            }
        }
            // end

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
                 int imax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                {
                    imax = i;
                }
                if (imax > 0)
                    {
                    for (int j = 0; j < imax - 1; j += 2)
                        {
                            int temp = array[j];
                            array[j] = array[j +1];
                            array[j + 1] = temp;
                        }
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
                for (int i = 0; i < array.Length; i++)
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
            for (int i = 0; i < array.Length - 1;i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }

                }

            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = array[n - 1 - i];
            }
            return;
          
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
          if (A == null && B == null) 
          {
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
          }
        
            // end
        
            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b && n == 1)
            {
                return new double[] {a};
            }
            else if (n > 1 && a != b)
            {
                array = new double[n];
                double jamp = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * jamp;
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