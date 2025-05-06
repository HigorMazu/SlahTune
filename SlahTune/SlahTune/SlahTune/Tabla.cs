using System.Collections.Generic;

namespace SlahTune
{
    public class Tabla
    {
        public string[] tabString;
        public Tabla(List<int> notas)
        {
            tabString = new string[6];
            int[] ints = new int[7];
            for (int i = 0; i < 7; i++)
                ints[i] = 0;

            for (int i = 0; i < tabString.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        tabString[i] = "e | -";
                        break;
                    case 1:
                        tabString[i] = "B | -";
                        break;
                    case 2:
                        tabString[i] = "G | -";
                        break;
                    case 3:
                        tabString[i] = "D | -";
                        break;
                    case 4:
                        tabString[i] = "A | -";
                        break;
                    case 5:
                        tabString[i] = "E | -";
                        break;
                }
            }

            for(int i = 0; i < notas.Count; i++)
            {
                int notaAtual = notas[i];

                string notaString = notaAtual.ToString();

                int linha = int.Parse(notaString[0].ToString());
                int casa = int.Parse(notaString[1].ToString());

                switch (linha)
                {
                    case 1:
                        ints[linha]++;
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (i2 == linha - 1)
                            {
                                tabString[i2] += casa.ToString();
                            }
                            else if (ints[linha] < 8 && ints[linha] > 0)
                                tabString[i2] += "--";
                            else
                            {
                                if (ints[linha] == 8)
                                    ints[linha] = -4;
                                else
                                    ints[linha]++;
                            }
                        }
                        break;
                    case 2:
                        ints[linha]++;
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (i2 == linha - 1)
                            {
                                tabString[i2] += casa.ToString();
                            }
                            else if (ints[linha] < 8 && ints[linha] > 0)
                                tabString[i2] += "--";
                            else
                            {
                                if (ints[linha] == 8)
                                    ints[linha] = -4;
                                else
                                    ints[linha]++;
                            }
                        }
                        break;
                    case 3:
                        ints[linha]++;
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (i2 == linha - 1)
                            {
                                tabString[i2] += casa.ToString();
                            }
                            else if (ints[linha] < 8 && ints[linha] > 0)
                                tabString[i2] += "--";
                            else
                            {
                                if (ints[linha] == 8)
                                    ints[linha] = -4;
                                else
                                    ints[linha]++;
                            }
                        }
                        break;
                    case 4:
                        ints[linha]++;
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (i2 == linha - 1)
                            {
                                tabString[i2] += casa.ToString();
                            }
                            else if (ints[linha] < 8 && ints[linha] > 0)
                                tabString[i2] += "--";
                            else
                            {
                                if (ints[linha] == 8)
                                    ints[linha] = -4;
                                else
                                    ints[linha]++;
                            }
                        }
                        break;
                    case 5:
                        ints[linha]++;
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (i2 == linha - 1)
                            {
                                tabString[i2] += casa.ToString();
                            }
                            else if (ints[linha] < 8 && ints[linha] > 0)
                                tabString[i2] += "--";
                            else
                            {
                                if (ints[linha] == 8)
                                    ints[linha] = -4;
                                else
                                    ints[linha]++;
                            }
                        }
                        break;
                    case 6:
                        ints[linha]++;
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (i2 == linha - 1)
                            {
                                tabString[i2] += casa.ToString();
                            }
                            else if (ints[linha] < 8 && ints[linha] > 0)
                                tabString[i2] += "--";
                            else
                            {
                                if (ints[linha] == 8)
                                    ints[linha] = -4;
                                else
                                    ints[linha]++;
                            }
                        }
                        break;
                    default:
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                           tabString[i2] += "--";
                        }
                        break;
                }
            }
        }
    }
}