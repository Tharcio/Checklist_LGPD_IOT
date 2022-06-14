using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades.Entidade
{
    public enum Resposta
    {
        [Display(Name = "Sim")]
        Sim = 0,
        [Display(Name = "Não")]
        Nao = 1,
        [Display(Name = "Não se Aplica")]
        NAplica = 2
    }
}
