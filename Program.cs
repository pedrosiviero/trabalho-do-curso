using POO;
using System.Collections.Generic;
using System;

    class Program{

        static List<Cliente> listaCliente = new List<Cliente>();
        static List<Gerente> listaGerente = new List<Gerente>();
        static List<Vendedor> listaVendedor = new List<Vendedor>();
        static List<Produto> listaProduto = new List<Produto>();


        static void Main(string[] args){
            MenuPrincipal();
        }

        public static void MenuPrincipal(){
            int profissa;
            do{
                Console.Clear();
                Console.WriteLine("Digite 0 para sair \nDigite 1 para cliente \nDigite 2 para gerente \nDigite 3 para vendedor \nDigite 4 para cadastrar produto \nDigite 5 para escolher um vendedor: "); 
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
                    EscolherVendedor();
                }

            }while(profissa != 0);
        }

        public static void CadastrarCliente(){
            Cliente cliente = new Cliente();
            cliente.InformarDados();
            Endereco endereco = new Endereco();
            endereco.InformarDados();
            Console.WriteLine("Você foi cadastrado\n" + cliente.GetNome() + "\n" + cliente.GetCpf() + "\n" + cliente.GetRg() + "\n" + cliente.GetDataNascimento());
            Console.WriteLine("\n" + endereco.GetRua() + "\n" + endereco.GetNumeroCasa() + "\n" + endereco.GetBairro() + "\n" + endereco.GetCep() + "\n" + endereco.GetCidade() + "\n" + endereco.GetEstado()); 
            listaCliente.Add(cliente); 
        }

        public static void CadastrarGerente(){
            Gerente gerente = new Gerente();
            gerente.InformarDados();
            Endereco endereco = new Endereco();
            endereco.InformarDados();
            Console.WriteLine("Você foi cadastrado\n" + gerente.GetNome() + "\n" + gerente.GetCpf() + "\n" + gerente.GetRg() + "\n" + gerente.GetDataNascimento());
            Console.WriteLine("\n" + endereco.GetRua() + "\n" + endereco.GetNumeroCasa() + "\n" + endereco.GetBairro() + "\n" + endereco.GetCep() + "\n" + endereco.GetCidade() + "\n" + endereco.GetEstado()); 
            Console.WriteLine("Seu salário aumentou 20% e ficou em: R$" + gerente.salario * 0.20);
            listaGerente.Add(gerente);
        }

        public static void CadastrarVendedor(){
            Vendedor funcionario = new Vendedor();
            funcionario.InformarDados();
            Endereco endereco = new Endereco();
            endereco.InformarDados();

            Console.WriteLine("Você foi cadastrado\n" + funcionario.GetNome() + "\n" + funcionario.GetCpf() + "\n" + funcionario.GetRg() + "\n" + funcionario.GetDataNascimento());
            Console.WriteLine("\n" + endereco.GetRua() + "\n" + endereco.GetNumeroCasa() + "\n" + endereco.GetBairro() + "\n" + endereco.GetCep() + "\n" + endereco.GetCidade() + "\n" + endereco.GetEstado()); 
            Console.WriteLine("Seu salário aumentou 15% e ficou em: R$" + funcionario.salario * 0.15);
            listaVendedor.Add(funcionario);
            
        }
        public static void CadastrarProduto(){
            Venda venda = new Venda();
            venda.InformarDados();
            Produto produto = new Produto(); 
            produto.InformarDados();
            Console.WriteLine("Seu produto foi cadastrado\n" + venda.listaProdutos + "\n" + produto.codigo + "\n" + produto.marca + "\n" + produto.descricao + "\n" + produto.valorUnidade); 
            listaProduto.Add(produto);
        }
        public static void EscolherVendedor(){
            int contador = 0;
            int vend = 1;
            

            foreach (Vendedor funcionario in listaVendedor)
            {
                Console.WriteLine(funcionario.GetNome() + " - vendedor " + contador);
                contador++;

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
            
            Console.WriteLine( listaVendedor.ElementAt(vend).GetNome() );

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
            

        }
    }