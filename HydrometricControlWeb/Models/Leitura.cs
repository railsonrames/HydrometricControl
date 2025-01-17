﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hidro.Web.Models
{
    public class Leitura
    {
        public Guid Id { get; set; }
        [Display(Name = "Realizada em")]
        public DateTime RealizadaEm { get; set; }
        [Display(Name = "M³")]
        public int MetrosCubicos { get; set; }
        public int HidrometroAtual { get; set; }
        public int HidrometroAnterior { get; set; }
        [Display(Name="Imagem")]
        public string NomeDaImagem { get; set; }
        public string Observacao { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool ExclusaoLogica { get; set; }

        [Display(Name="Unidade")]
        public Guid IdUnidade { get; set; }
        public Unidade Unidade { get; set; }

        [Display(Name="Imposto")]
        public Guid IdImposto { get; set; }
        public Imposto Imposto { get; set; }
    }
}
