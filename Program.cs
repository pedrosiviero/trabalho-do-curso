using POO;
using System.Collections.Generic;
using System;

    class Program{

        static List<Cliente> listaCliente = new List<Cliente>();
        static List<Gerente> listaGerente = new List<Gerente>();
        static List<Vendedor> listaVendedor = new List<Vendedor>();
        static List<Produto> listaProduto = new List<Produto>();
        static List<Venda> listaVenda = new List<Venda>();
        static Venda venda = new Venda();

        static void Main(string[] args){
            MenuPrincipal();
        }

        public static void MenuPrincipal(){
            int profissa;
            do{
                Console.Clear();
                Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
                Console.WriteLine("|           ~    Menu   ~              |");
                Console.WriteLine("|  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ |");
                Console.WriteLine("| Digite 0 para sair                   |");
                Console.WriteLine("| Digite 1 para cliente                |");
                Console.WriteLine("| Digite 2 para gerente                |");
                Console.WriteLine("| Digite 3 para vendedor               |");
                Console.WriteLine("| Digite 4 para cadastrar produto      |");
                Console.WriteLine("| Digite 5 para fazer a venda          |"); 
                Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
                profissa = int.Parse(Console.ReadLine()); 
                
    
                if(profissa == 1){
                    CadastrarCliente();
                }
                if(profissa == 2){
                    CadastrarGerente();
                }
                if(profissa == 3){
                    CadastrarVendedor();
                }
                if(profissa == 4){
                    CadastrarProduto();
                }
                if(profissa == 5){
                    CadastrarVenda();
                }

            }while(profissa != 0);
        }

        public static void CadastrarCliente(){
            Cliente cliente = new Cliente();
            cliente.InformarDados();
            Endereco endereco = new Endereco();
            endereco.InformarDados();
            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("Você foi cadastrado:\nNome: " + cliente.GetNome() + "\nCpf: " + cliente.GetCpf() + "\nRg: " + cliente.GetRg() + "\nData de nascimento: " + cliente.GetDataNascimento());
            Console.WriteLine("Rua: " + endereco.GetRua() + "\nNúmero da casa: " + endereco.GetNumeroCasa() + "\nBairro: " + endereco.GetBairro() + "\nCep: " + endereco.GetCep() + "\nCidade: " + endereco.GetCidade() + "\nEstado: " + endereco.GetEstado()); 
            listaCliente.Add(cliente); 
            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
        }

        public static void CadastrarGerente(){
            Gerente gerente = new Gerente();
            gerente.InformarDados();
            Endereco endereco = new Endereco();
            endereco.InformarDados();
            Console.WriteLine("Você foi cadastrado: \nNome: " + gerente.GetNome() + "\nCpf: " + gerente.GetCpf() + "\nRg: " + gerente.GetRg() + "\nData de nascimento: " + gerente.GetDataNascimento());
            Console.WriteLine("Rua: " + endereco.GetRua() + "\nNúmero da casa: " + endereco.GetNumeroCasa() + "\nBairro: " + endereco.GetBairro() + "\nCep: " + endereco.GetCep() + "\nCidade: " + endereco.GetCidade() + "\nEstado: " + endereco.GetEstado()); 
            Console.WriteLine("Seu salário aumentou 20% e ficou em: R$" + gerente.salario * 0.20);
            listaGerente.Add(gerente);
            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
        }

        public static void CadastrarVendedor(){
            Vendedor funcionario = new Vendedor();
            funcionario.InformarDados();
            Endereco endereco = new Endereco();
            endereco.InformarDados();

            Console.WriteLine("Você foi cadastrado: \nNome: " + funcionario.GetNome() + "\nCpf: " + funcionario.GetCpf() + "\nRg: " + funcionario.GetRg() + "\nData de nascimento: " + funcionario.GetDataNascimento());
            Console.WriteLine("Rua: " + endereco.GetRua() + "\nNúmero da casa: " + endereco.GetNumeroCasa() + "\nBairro: " + endereco.GetBairro() + "\n" + endereco.GetCep() + "\nCidade: " + endereco.GetCidade() + "\nEstado: " + endereco.GetEstado()); 
            Console.WriteLine("Seu salário aumentou 15% e ficou em: R$" + funcionario.salario * 0.15);
            listaVendedor.Add(funcionario);
            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
            
        }
        public static void CadastrarProduto(){
            
            Produto produto = new Produto(); 
            produto.InformarDados();
            Console.WriteLine("Seu produto foi cadastrado\n" + produto.codigo + "\n" + produto.marca + "\n" + produto.descricao + "\n" + produto.valorUnidade); 
            listaProduto.Add(produto);
            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
        }
        public static void CadastrarVenda(){
            if( ! EscolherVendedor() || ! EscolherCliente() || ! EscolherProduto() ){
                System.Console.WriteLine("Venda cancelada!");
                return ;
            }

            listaVenda.Add(venda);
        }
        public static bool EscolherVendedor(){
            int contador = 0;
            int vend = 0;

            foreach (Vendedor funcionario in listaVendedor)
            {
                Console.WriteLine(funcionario.GetNome() + " - vendedor " + contador);
                contador++;
            }
            
            if(contador == 0){
                return false;
            }

            Console.WriteLine("Escolha um vendedor de acordo com seu número");
            
            do{
                vend = int.Parse(Console.ReadLine());
                if( vend <= contador ){
                    Console.WriteLine("Seu vendedor é o(a) " + vend + "º vendedor");
                }else{
                    Console.WriteLine("vendedor invalido!");
                }
            }while(vend > contador);
            
            venda.SetVendedor(listaVendedor.ElementAt(vend));
            Console.WriteLine( listaVendedor.ElementAt(vend).GetNome() );

            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
            return true;
        }
        public static bool EscolherProduto(){
            int contador = 0;
            int vend = 1;
            

            foreach (Produto produto in listaProduto)
            {
                Console.WriteLine(produto.GetDescricao() + " - produto " + contador);
                contador++;
            }
            
            
            Console.WriteLine("Escolha um produto de acordo com seu número");
            
            do{
                vend = int.Parse(Console.ReadLine());
                if( vend <= contador ){
                    Console.WriteLine("Seu produto é o(a) " + vend + "º produto");
                }else{
                    Console.WriteLine("produto invalido!");
                }
            }while(vend > contador);
            venda.SetProduto(listaProduto.ElementAt(vend));
            Console.WriteLine( listaProduto.ElementAt(vend).GetDescricao() );

            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
            return true;
        }
         public static bool EscolherCliente(){
            int contador = 0;
            int vend = 1;
            

            foreach (Cliente cliente in listaCliente)
            {
                Console.WriteLine(cliente.GetNome() + " - cliente " + contador);
                contador++;
            }
            if(contador == 0){
                return false;
            }
            
            Console.WriteLine("Escolha um cliente de acordo com seu número");
            
            do{
                vend = int.Parse(Console.ReadLine());
                if( vend <= contador ){
                    Console.WriteLine("Seu cliente é o(a) " + vend + "º cliente");
                }else{
                    Console.WriteLine("Cliente invalido!");
                }
            }while(vend > contador);
            venda.SetCliente(listaCliente.ElementAt(vend));
            Console.WriteLine( listaCliente.ElementAt(vend).GetNome() );

            Console.WriteLine("*  - - - - - - - - - - - - - - - - - - *");
            Console.WriteLine("| Pressione qualquer tecla para sair.  |");
            Console.WriteLine("*  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ *");
            Console.ReadKey();
            return true;
        }
    }