using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using API_Folha.Validations;
using System.Text.Json.Serialization;

namespace API.Models
{
    //Data Annotations
    public class Folha
    {
        public int Id { get; set; }
        public int ValorHora { get; set; }
         public int SalarioBruto { get; set; }
         public int ImpostoDeRenda { get; set; }
         public int ImpostoINSS { get; set; }
         public int ImpostoFGTS { get; set; }
         public int SalarioLiquido { get; set; }
        public DateTime FuncionarioCriadoEm { get; set; }
        public int QuantidadeDeHoras { get; set; }
         public Funcionario Funcionario  { get; set; }
        public int FuncionarioId { get; set; }
        public string FuncionarioCpf { get; set; }
    }
}