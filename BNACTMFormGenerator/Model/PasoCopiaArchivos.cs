﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNACTMFormGenerator.Model
{
    class PasoCopiaArchivos : Paso {
        public TransferenciaArchivo Origen;
        public TransferenciaArchivo Destino;
        public string Observaciones;

        public PasoCopiaArchivos() {
            TipoDePaso = TipoPaso.Copia_Archivos;
            NroPaso = 1;
            TextoPaso = "Transferencia de archivos";
            Observaciones = "";
            Origen = new TransferenciaArchivo();            
            Destino = new TransferenciaArchivo();
        }

        public override string ToStringFormat(string format) {
            return "PASO " + NroPaso + "\n" + TextoPaso + "\nOrigen\n" + Origen.ToStringFormat(format) + "\nDestino\n" + Destino.ToStringFormat(format) 
                           + (Observaciones.Length > 0 ? "\nObservaciones: " + Observaciones : "\n");
        }

        static readonly string[] ValidatedProperties = 
        { 
            "Origen",
            "Desino",
            "Observaciones",
        };

        override public bool IsValid {
            get {
                return Origen.IsValid && Destino.IsValid;
            }
        }
    }
}
