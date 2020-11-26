﻿using System;
using System.Collections.Generic;

namespace Nyous.Domains
{
    public partial class Presenca
    {
        public int IdPresenca { get; set; }
        public bool? Confirmado { get; set; }
        public int? IdEvento { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Eventos IdEventoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
