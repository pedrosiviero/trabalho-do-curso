namespace POO{

    public abstract class Funcionario : Pessoa{
        public double salario = 0;

        public double GetSalario(){
            return salario; 
        }
        public void SetSalario(double salario){
            this.salario = salario; 
        }

        public void InformarDados(){
            base.InformarDados();
            Console.WriteLine("Digite o salario:");
            salario = double.Parse(Console.ReadLine());
        }

        public abstract void AumentarSalario();

        /*if(profissao == 2 || profissao == 3){
                cliente1.SetSalario(salario);
            }*/
            
        
    }
}