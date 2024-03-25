namespace AtividadeArray {
    internal class Program {
        static void Main(string[] args) {
            int[] array = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
            int op, valor;
            while (true) {
                op = -1;
                Console.WriteLine("Sequencia Atual:");
                MostrarValores(array);
                Console.WriteLine("\n\nInforme a opção desejada:");
                Console.WriteLine("1 - Mostrar o maior valor");
                Console.WriteLine("2 - Mostrar o menor valor");
                Console.WriteLine("3 - Mostrar o valor medio");
                Console.WriteLine("4 - Mostrar os 3 maiores valores");
                Console.WriteLine("5 - Mostrar os valores negativos");
                Console.WriteLine("6 - Remover um valor da sequencia");
                Console.WriteLine("0 - Sair");

                try {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception ex) {
                    Console.WriteLine("Apenas numeros podem ser digitados, por favor tente novamente");
                    Console.ReadLine();
                }
                switch (op) {
                    case 0: return;
                    case 1:
                        Console.WriteLine($"Maior valor é :{MaiorValor(array)}");
                        break;
                    case 2:
                        Console.WriteLine($"Menor valor é :{MenorValor(array)}");
                        break;
                    case 3:
                        Console.WriteLine($"Valor médio é :{ValorMedio(array)}");
                        break;
                    case 4:
                        Console.WriteLine("Os 3 maiores valores são: ");
                        MostrarValores(TresMaiores(array));
                        break;
                    case 5:
                        Console.WriteLine($"Os valores negativos são: ");
                        MostrarValores(ValoresNegativos(array));
                        break;
                    case 6:
                        Console.WriteLine("Informe o valor a ser removido: ");
                        try {
                            valor = int.Parse(Console.ReadLine());
                            array = RemoverItem(array, valor);
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Apenas numeros podem ser digitados");
                        }
                        break;

                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        #region 
        static int MaiorValor(int[] array) {
            int maior = array[0];
            foreach (int i in array) {
                if (i > maior)
                    maior = i;
            }
            return maior;
        }
        static int MenorValor(int[] array) {
            int menor = array[0];
            foreach (int i in array) {
                if (i < menor)
                    menor = i;
            }
            return menor;
        }
        static int ValorMedio(int[] array) {
            int media = 0;
            foreach (int i in array) {
                media += i;
            }
            return media / array.Length;
        }
        static int[] TresMaiores(int[] array) {
            int[] sequencia = new int[3];
            foreach (int i in array) {
                if (i > sequencia[0]) {
                    sequencia[2] = sequencia[1];
                    sequencia[1] = sequencia[0];
                    sequencia[0] = i;
                }
            }
            return sequencia;
        }
        static int[] ValoresNegativos(int[] array) {
            int n = 0;
            foreach (int i in array) {
                if (i < 0) {
                    n++;
                }
            }
            int[] negativos = new int[n];
            n = 0;
            foreach (int i in array) {
                if (i < 0) {
                    negativos[n] = i;
                    n++;
                }
            }
            return negativos;
        }
        static void MostrarValores(int[] array) {
            foreach (int i in array) {
                Console.Write($"{i}, ");
            }
        }
        static int[] RemoverItem(int[] array, int valor) {
            int[] aux = new int[array.Length - 1];
            int n = 0;
            foreach (int i in array) {
                if (i != valor) {
                    aux[n] = i;
                    n++;
                }
            }
            return aux;
        }
        #endregion
    }
}
