using System;

namespace Calculadora
{
    class Program
    {
        public double somar(double a, double b)
        {
            Console.WriteLine("Resultado: " + (a + b));
            double result = 0.0;
            result = a + b;


            return result;
        }
        public double dividir(double a, double b)
        {
            double result = 0.0;
            Console.WriteLine("Resultado: " + (a / b));
            result = a / b;
            return result;
        }

        public double multiplicar(double a, double b)
        {
            double result = 0.0;

            Console.WriteLine("Resultado: " + (a * b));
            result = a * b;
            return result;
        }
        public double subtrair(double a, double b)
        {
            double result = 0.0;
            if (b < 0)
            {
                Console.WriteLine("Resultado: " + 0);
                return 0;
            }
            else
            {
                Console.WriteLine("Resultado: " + (a - b));
                result = a - b;

                return result;
            }
        }
        public double seguinteOpe(double a)
        {
            double b = 0.0;
            int auxiliar = 0;
            Console.WriteLine("Digite o outro numero que sera usado na operacao");
            b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Agora escolha a operacao");
            Console.WriteLine("\n 1: Soma");
            Console.WriteLine("\n 2: Subtracao");
            Console.WriteLine("\n 3: Multiplicacao");
            Console.WriteLine("\n 4: Divisao");
            Console.WriteLine("\n 5: Exponenciacao");
            Console.WriteLine("\n 6: Raiz quadrada");
            auxiliar = Convert.ToInt32(Console.ReadLine());


            if (auxiliar == 1)
            {
                a = somar(a, b);

            }
            else if (auxiliar == 2)
            {
                a = subtrair(a, b);
            }
            else if (auxiliar == 3)
            {
                a = multiplicar(a, b);
            }
            else if (auxiliar == 4)
            {
                a = dividir(a, b);
            }
            else if (auxiliar == 5)
            {
                a = exponenciacao(a, b);
            }
            else if (auxiliar == 6)
            {
                a = raiz(a, b);
            }
            else
            {
                Console.WriteLine("Operacao Invalida");
            }
            return a;
        }
        public double alteraResult(double a)
        {
            double valorReal = 0.0;
            valorReal = valorReal + a;

            Console.WriteLine("Resultado: " + valorReal);
            return valorReal;
        }


        public double exponenciacao(double a, double b)
        {
            Console.WriteLine("Resultado: " + Math.Pow(a, b));
            return Math.Pow(a, b);
        }
        public double raiz(double a, double b)
        {
            int leitor = 0;
            double result = 0.0;

            Console.WriteLine("A raiz de: " + a + "=" + Math.Sqrt(a) + " e a raiz de " + b + "= " + Math.Sqrt(b));
            Console.WriteLine("Deseja retornar algum dos dois  resultados? ");
            Console.WriteLine("1: SIM! ");
            Console.WriteLine("2 NAO! ");
            leitor = Convert.ToInt32(Console.ReadLine());
            if (leitor == 1)
            {
                Console.WriteLine("1º ou 2º resultado? ");
                Console.WriteLine("Digite 1 para escolher o 1º e 2 para escolher o 2º ");
                leitor = Convert.ToInt32(Console.ReadLine());
                if (leitor == 1)
                {
                    result = Math.Sqrt(a);
                }
                else if (leitor == 2)
                {
                    result = Math.Sqrt(b);
                }
                else
                    Console.WriteLine("Opcao Invalida! ");


            }
            else
            {
                return 0.0;
            }
            Console.WriteLine("Resultado: " + result);

            return result;
        }

        public double confirmaOpe(double var)
        {
            int operacao = 0;
            Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
            Console.WriteLine("1: SIM! ");
            Console.WriteLine("2: NAO! ");
            operacao = Convert.ToInt32(Console.ReadLine());
            if (operacao == 1)
            {

                var = seguinteOpe(var);


                Console.WriteLine("Resultado123: " + var);
                return var;

            }
            else
            {
                Console.WriteLine("Resultado: " + var);
                return var;
            }

        }


        static void Main(string[] args)

        {

            Program p = new Program();
            double x = 0.0;
            Boolean ativa = true;
            double valor = 0.0;
            double a = 0.0;
            double b = 0.0;
            int salva = 0;
            int escolha = 0;
            int cont = 0;
            int operacao = 0;
            do
            {

                Console.WriteLine("*********************");
                Console.WriteLine("Escolha a operacao");
                Console.WriteLine("\n 1: Soma");
                Console.WriteLine("\n 2: Subtracao");
                Console.WriteLine("\n 3: Multiplicacao");
                Console.WriteLine("\n 4: Divisao");
                Console.WriteLine("\n 5: Exponenciacao");
                Console.WriteLine("\n 6: Raiz quadrada");
                Console.WriteLine("\n 0: Finalizar ");

                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o 1º nmr");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite 0 2º nmr ");
                            b = Convert.ToDouble(Console.ReadLine());



                            if (cont < 1)
                            {
                                p.somar(a, b);

                            }
                            else
                            {
                                valor = p.somar(a, b);

                                while (ativa == true)
                                {
                                    Console.WriteLine("Deseja salvar o resultado? ");
                                    Console.WriteLine("1: SIM! ");
                                    Console.WriteLine("2: NAO! ");
                                    salva = Convert.ToInt32(Console.ReadLine());
                                    if (salva == 1)
                                    {

                                        p.alteraResult(valor);
                                        Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
                                        Console.WriteLine("1: SIM! ");
                                        Console.WriteLine("2: NAO! ");
                                        operacao = Convert.ToInt32(Console.ReadLine());
                                        if (operacao == 1)
                                        {

                                            valor = p.seguinteOpe(valor);

                                        }
                                        else
                                        {
                                            ativa = false;
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        ativa = false;
                                        break;
                                    }

                                }


                            }



                            cont = cont + 1;
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Digite o 1º nmr");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite 0 2º nmr ");
                            b = Convert.ToDouble(Console.ReadLine());



                            if (cont < 1)
                            {
                                p.subtrair(a, b);

                            }
                            else
                            {
                                valor = p.subtrair(a, b);

                                while (ativa == true)
                                {
                                    Console.WriteLine("Deseja salvar o resultado? ");
                                    Console.WriteLine("1: SIM! ");
                                    Console.WriteLine("2: NAO! ");
                                    salva = Convert.ToInt32(Console.ReadLine());
                                    if (salva == 1)
                                    {

                                        p.alteraResult(valor);
                                        Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
                                        Console.WriteLine("1: SIM! ");
                                        Console.WriteLine("2: NAO! ");
                                        operacao = Convert.ToInt32(Console.ReadLine());
                                        if (operacao == 1)
                                        {

                                            valor = p.seguinteOpe(valor);

                                        }
                                        else
                                        {
                                            ativa = false;
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        ativa = false;
                                        break;
                                    }

                                }


                            }

                            cont = cont + 1;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Digite o 1º nmr");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite 0 2º nmr ");
                            b = Convert.ToDouble(Console.ReadLine());



                            if (cont < 1)
                            {
                                p.multiplicar(a, b);

                            }
                            else
                            {
                                valor = p.multiplicar(a, b);

                                while (ativa == true)
                                {
                                    Console.WriteLine("Deseja salvar o resultado? ");
                                    Console.WriteLine("1: SIM! ");
                                    Console.WriteLine("2: NAO! ");
                                    salva = Convert.ToInt32(Console.ReadLine());
                                    if (salva == 1)
                                    {

                                        p.alteraResult(valor);
                                        Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
                                        Console.WriteLine("1: SIM! ");
                                        Console.WriteLine("2: NAO! ");
                                        operacao = Convert.ToInt32(Console.ReadLine());
                                        if (operacao == 1)
                                        {

                                            valor = p.seguinteOpe(valor);

                                        }
                                        else
                                        {
                                            ativa = false;
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        ativa = false;
                                        break;
                                    }

                                }


                            }
                            cont = cont + 1;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Digite o 1º nmr");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite 0 2º nmr ");
                            b = Convert.ToDouble(Console.ReadLine());



                            if (cont < 1)
                            {
                                p.dividir(a, b);

                            }
                            else
                            {
                                valor = p.dividir(a, b);

                                while (ativa == true)
                                {
                                    Console.WriteLine("Deseja salvar o resultado? ");
                                    Console.WriteLine("1: SIM! ");
                                    Console.WriteLine("2: NAO! ");
                                    salva = Convert.ToInt32(Console.ReadLine());
                                    if (salva == 1)
                                    {


                                        p.alteraResult(valor);
                                        Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
                                        Console.WriteLine("1: SIM! ");
                                        Console.WriteLine("2: NAO! ");
                                        operacao = Convert.ToInt32(Console.ReadLine());
                                        if (operacao == 1)
                                        {

                                            valor = p.seguinteOpe(valor);

                                        }
                                        else
                                        {
                                            ativa = false;
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        ativa = false;
                                        break;
                                    }

                                }


                            }
                            cont = cont + 1;
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Digite o 1º nmr");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite 0 2º nmr ");
                            b = Convert.ToDouble(Console.ReadLine());



                            if (cont < 1)
                            {
                                p.exponenciacao(a, b);

                            }
                            else
                            {
                                valor = p.exponenciacao(a, b);

                                while (ativa == true)
                                {
                                    Console.WriteLine("Deseja salvar o resultado? ");
                                    Console.WriteLine("1: SIM! ");
                                    Console.WriteLine("2: NAO! ");
                                    salva = Convert.ToInt32(Console.ReadLine());
                                    if (salva == 1)
                                    {

                                        p.alteraResult(valor);
                                        Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
                                        Console.WriteLine("1: SIM! ");
                                        Console.WriteLine("2: NAO! ");
                                        operacao = Convert.ToInt32(Console.ReadLine());
                                        if (operacao == 1)
                                        {

                                            valor = p.seguinteOpe(valor);

                                        }
                                        else
                                        {
                                            ativa = false;
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        ativa = false;
                                        break;
                                    }

                                }


                            }
                            cont = cont + 1;
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Digite o 1º nmr");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite 0 2º nmr ");
                            b = Convert.ToDouble(Console.ReadLine());



                            if (cont < 1)
                            {
                                p.raiz(a, b);

                            }
                            else
                            {
                                p.raiz(a, b);

                                while (ativa == true)
                                {
                                    Console.WriteLine("Deseja salvar o resultado? ");
                                    Console.WriteLine("1: SIM! ");
                                    Console.WriteLine("2: NAO! ");
                                    salva = Convert.ToInt32(Console.ReadLine());
                                    if (salva == 1)
                                    {


                                        p.alteraResult(valor);
                                        Console.WriteLine("Deseja fazer outra operacao com este resultado? ");
                                        Console.WriteLine("1: SIM! ");
                                        Console.WriteLine("2: NAO! ");
                                        operacao = Convert.ToInt32(Console.ReadLine());
                                        if (operacao == 1)
                                        {

                                            valor = p.seguinteOpe(valor);

                                        }
                                        else
                                        {
                                            ativa = false;
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        ativa = false;
                                        break;
                                    }

                                }


                            }
                            cont = cont + 1;
                            break;
                        }

                }
            } while (escolha != 0);
        }
    }
}
