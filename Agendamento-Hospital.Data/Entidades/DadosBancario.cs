﻿using System;
using System.Collections.Generic;

namespace Agendamento_Hospital.Data.Entidades;

public partial class DadosBancario
{
    public int IdDadosBancarios { get; set; }

    public string NumeroBanco { get; set; } = null!;

    public string? CodigoPix { get; set; }

    public string? Agencia { get; set; }

    public string? NumeroConta { get; set; }

    public bool? Poupanca { get; set; }

    public int IdProfissional { get; set; }

    public virtual Profissional IdProfissionalNavigation { get; set; } = null!;
}
