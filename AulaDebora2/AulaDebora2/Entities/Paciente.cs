using System;
using System.Text;


namespace AulaDebora2.Entities
{
    internal class Paciente
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public int numeroDeDependentes { get; set; }
        public string endereço { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public int tempoDeEmpresa { get; set; }
        public double salario { get; set; }
        public bool doencas { get; set; }
        public string infoEs, infoTe, infoSa, InfoDo;

        StringBuilder sb = new StringBuilder();
        
        public Paciente(string nome, int idade,int numeroDeDependentes, string endereço, string cep, string estado, int tempoDeEmpresa, double salario, bool doencas)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereço = endereço;
            this.cep = cep;
            this.estado = estado;
            this.tempoDeEmpresa = tempoDeEmpresa;
            this.salario = salario;
            this.doencas = doencas;
            this.numeroDeDependentes = numeroDeDependentes;
        }
        
        public Paciente()
        {

        }

        public override string ToString()
        {
            if (estado != "SP")
            {
                infoEs = "Não oferecemos cobertura para outros estados.";
            }
            else
            {
                infoEs = "Area dentro de cobertura.";
            }
            if(tempoDeEmpresa < 2)
            {
                infoTe = "Infelizmente seu tempo é menor que 2 anos e não oferecemos cobertura.";
            }
            else
            {
                infoTe = "Cobertura disponível.";
            }
            if(salario < 1500)
            {
                infoSa = "Salário insuficiente ";
            }
            if(1500 < salario && salario< 3000)
            {
                infoSa = "Cliente Gold";
            }
            else
            {
                infoSa = "Cliente Platinum";
            }
            if(doencas == true)
            {
                InfoDo = "Sujeito à análise";
            }
            else
            {
                InfoDo = "Análise não necessária";
            }
            sb.AppendLine("--------------------------------------------------------------------------------------------------------------------");
            sb.AppendLine("Informações do paciente: ");
            sb.Append($"| Nome: {nome} | Idade: {idade} | Número de dependentes: {numeroDeDependentes} | Endereço: {endereço} | Cep: {cep} | Estado: {estado}\n| Tempo de empresa: {tempoDeEmpresa} | Salario: {salario} | Doenças pré-existentes: {doencas}\n");
            sb.AppendLine("--------------------------------------------------------------------------------------------------------------------");
            sb.AppendLine("Informações de serviços:");
            sb.Append($"| Info estado: {infoEs} |\n| Info tempo de empresa: {infoTe} |\n| Info salario: {infoSa} |\n| Info doenças pré-existentes: {InfoDo} |\n");
                       
            
            return sb.ToString();
        }
    }
}
