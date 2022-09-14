using POO;

namespace POO{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("Digite 1 para cliente \nDigite 2 para gerente \nDigite 3 para vendedor "); 
            int profissa = int.Parse(Console.ReadLine()); 
 
            if(profissa == 1){
                Cliente cliente = new Cliente();
                cliente.InformarDados();
                Console.WriteLine("Você foi cadastrado\n" + cliente.nome + "\n" + cliente.cpf + "\n" + cliente.rg + "\n" + cliente.dataNascimento + "\n" + cliente.endereco + "\n" );
            }
            if(profissa == 2){
                    Gerente gerente = new Gerente();
                    gerente.InformarDados();
                    Console.WriteLine("Você foi cadastrado\n" + gerente.nome + "\n" + gerente.cpf + "\n" + gerente.rg + "\n" + gerente.dataNascimento + "\n" + gerente.endereco + "\n" );
                    Console.WriteLine("Seu salário aumentou 20% e ficou em: R$" + gerente.salario * 0.20);
            }
            if(profissa == 3){
                    Vendedor funcionario = new Vendedor();
                    funcionario.InformarDados();
                    Console.WriteLine("Você foi cadastrado\n" + funcionario.nome + "\n" + funcionario.cpf + "\n" + funcionario.rg + "\n" + funcionario.dataNascimento + "\n" + funcionario.endereco);
                    Console.WriteLine("Seu salário aumentou 15% e ficou em: R$" + funcionario.salario * 0.15);
            }

        }
    }
}
