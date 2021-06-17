using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;



namespace AtividadeAsp1.Models
{



    public class Produtos
    {
        [Required(ErrorMessage = "O campo Código é obrigatório")]
        [Remote("LoginUnico", "produtos", ErrorMessage = "Login existente.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres!")]
        public string Descricao { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor inválido")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório")]
        public string Categoria { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor inválido")]
        [Required(ErrorMessage = "O campo ValorUnit é obrigatório")]
        public string ValorUnitario { get; set; }



    }
}

