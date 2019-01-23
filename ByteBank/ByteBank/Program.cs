using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.IO;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {


            CarregarContas();

            Console.WriteLine("Execução finalizada, tecle enter para sair");

            Console.ReadLine();


        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;

            try
            {
                leitor = new LeitorDeArquivo("contas.txt");
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

            }
            catch(IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }
                
            }
                       
        }

        private static void TesteInnerException()
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(524, 988);
                ContaCorrente conta2 = new ContaCorrente(454, 878);

                conta2.Transferir(1000, conta);
                Console.WriteLine(conta.Saldo);


            }
            catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }

        /*
        catch(ArgumentException ex)
        {
            if (ex.ParamName == "numero")
            {
                Console.WriteLine("Agumento com problema: " + ex.ParamName);

            }


            Console.WriteLine("Ocorreu uma exceção do tipo argumentexception");
            Console.WriteLine(ex.Message);
        }
        catch(SaldoInsuficienteException ex)
        {
            Console.WriteLine(ex.ValorSaque);
            Console.WriteLine(ex.Saldo); 

            Console.WriteLine(ex.Message);
            Console.WriteLine("Exceção de SaldoInsuficienteException");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        */



        /*
        try
        {
            Metodo();
        }
        catch(NullReferenceException erro)
        {
            Console.WriteLine("Não foi definido corretamente!");
            Console.WriteLine(erro.Message);
        }
        catch (Exception erro)
        {
            Console.WriteLine("Aconteceu um erro!");
            Console.WriteLine(erro.Message);
            Console.WriteLine(erro.StackTrace);
        }

        Console.ReadLine();

        // ---------------------- Definindo Exceções -----------------------
        /*
        ContaCorrente conta = new ContaCorrente(348, 78844587);

        ContaCorrente Jorge = new ContaCorrente(789, 45454998);
        */
        /*
        Console.WriteLine(ContaCorrente.TaxaOperacao);


        Console.ReadLine();

        ////---------------------------- Defnindo Interface e Herança ------------------------
        /*
        SistemaInterno sistemaInterno = new SistemaInterno();

        Diretor Matheus = new Diretor("467.653.758-76");
        Matheus.Nome = "Matheus";

        Matheus.Senha = "abc";

        sistemaInterno.Logar(Matheus, "abc");

        GerenteDeConta Camila = new GerenteDeConta("987.462.791-35");

        Camila.Senha = "123";
        sistemaInterno.Logar(Camila, "123");

        ParceiroComercial Lucas = new ParceiroComercial("967.982.791 - 35");

        Lucas.Senha = "gg";
        sistemaInterno.Logar(Lucas, "gg");
        */



        // GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

        //Funcionario Matheus = new Diretor("467.653.758-76");
        // Matheus.Nome = "Matheus";

        //Funcionario Camila = new GerenteDeConta("987.462.791-35");
        //Camila.Nome = "Camila";

        //Funcionario Jonas = new Designer("258.456.753-19");
        //Jonas.Nome = "Jonas";

        //Funcionario Carlos = new Auxiliar("749.124.946-27");
        //Carlos.Nome = "Carlos";

        //gerenciador.Registrar(Matheus);
        //gerenciador.Registrar(Camila);
        //gerenciador.Registrar(Jonas);
        //gerenciador.Registrar(Carlos);

        //Console.WriteLine("Total bonificação:  " + gerenciador.GetTotalBonificacao());
        //Console.ReadLine();


        /*
        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção com numero = " + numero + " e divisor=" + divisor);
                throw;
            }
            
        }

        static void Metodo()
        {
                TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
        */
    }

}
