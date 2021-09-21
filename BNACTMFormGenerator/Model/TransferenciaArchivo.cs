using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;

namespace BNACTMFormGenerator.Model
{
    public enum TipoOrigen 
    { 
        HOST,
        XCOM,
        STAGING,
        Otro
    }

    class TransferenciaArchivo : DataErrorInfoBase {
        public TipoOrigen OrigenArchivos;
        
        public string ServidorTest;
        public string ServidorProd;

        public string RutaTest;
        public string RutaProd;

        public string ArchivoTest;
        public string ArchivoProd;

        public string FileOptionTest;
        public string FileOptionProd;

        public string RecordFormatTest;
        public string RecordFormatProd;

        public int LReclTest;
        public int LReclProd;

        public int BlkSizeTest;
        public int BlkSizeProd;

        public TransferenciaArchivo() {
            OrigenArchivos = TipoOrigen.Otro;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "OrigenArchivos",
            "ServidorTest",
            "ServidorProd",
            "RutaTest",
            "RutaProd",
            "ArchivoTest",
            "ArchivoProd",
            "FileOptionTest",
            "FileOptionProd",
            "RecordFormatTest",
            "RecordFormatProd",
            "LReclTest",
            "LReclProd",
            "BlkSizeTest",
            "BlkSizeProd",
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName) {
                case "ServidorTest":
                    error = IsStringMissing(ServidorTest) ? "El Servidor de Test es requerido" : null;
                    break;

                case "ServidorProd":
                    error = IsStringMissing(ServidorProd) ? "El Servidor de Prod es requerido" : null;
                    break;

                case "RutaTest":
                    if (OrigenArchivos != TipoOrigen.HOST) error = IsStringMissing(RutaTest) ? "La ruta de Test es requerida" : null;
                    break;

                case "RutaProd":
                    if (OrigenArchivos != TipoOrigen.HOST) error = IsStringMissing(RutaProd) ? "La ruta de Prod es requerida" : null;
                    break;

                case "ArchivoTest":
                    error = IsStringMissing(ArchivoTest) ? "El Archivo de Test es requerido" : null;
                    break;

                case "ArchivoProd":
                    error = IsStringMissing(ArchivoProd) ? "El Archivo de Prod es requerido" : null;
                    break;

                case "FileOptionTest":
                    if (OrigenArchivos == TipoOrigen.HOST) error = IsStringMissing(FileOptionTest) ? "Cuando el servidor es HOST, el FILE_OPTION de Test es requerido" : null;
                    break;
                
                case "FileOptionProd":
                    if (OrigenArchivos == TipoOrigen.HOST) error = IsStringMissing(FileOptionProd) ? "Cuando el servidor es HOST, el FILE_OPTION de Prod es requerido" : null;
                    break;
                
                case "RecordFormatTest":
                    if (OrigenArchivos == TipoOrigen.HOST) error = IsStringMissing(RecordFormatTest) ? "Cuando el servidor es HOST, el RECORD_FORMAT de Test es requerido" : null;
                    break;
                
                case "RecordFormatProd":
                    if (OrigenArchivos == TipoOrigen.HOST) error = IsStringMissing(RecordFormatProd) ? "Cuando el servidor es HOST, el RECORD_FORMAT de Prod es requerido" : null;
                    break;
                
                case "LReclTest":
                    if (OrigenArchivos == TipoOrigen.HOST) error = LReclTest == 0 ? "Cuando el servidor es HOST, el LRECL de Test es requerido" : null;
                    break;
                
                case "LReclProd":
                    if (OrigenArchivos == TipoOrigen.HOST) error = LReclProd == 0 ? "Cuando el servidor es HOST, el LRECL de Prod es requerido" : null;
                    break;
                
                case "BlkSizeTest":
                    if (OrigenArchivos == TipoOrigen.HOST) error = BlkSizeTest == 0 ? "Cuando el servidor es HOST, el BLKSIZE de Test es requerido" : null;
                    break;
                
                case "BlkSizeProd":
                    if (OrigenArchivos == TipoOrigen.HOST) error = BlkSizeProd == 0 ? "Cuando el servidor es HOST, el BLKSIZE de Prod es requerido" : null;
                    break;
            }

            return error;
        }

        override public bool IsValid {
            get {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null) return false;
                return true;
            }
        }

        public string ToStringFormat(string format){
            string str = null;

            if (format.ToUpper() == "TEST") {
                if (OrigenArchivos == TipoOrigen.HOST)
                    str = "Servidor: " + ServidorTest + "\nArchivo: " + ArchivoTest + "\nFILE_OPTION=" + FileOptionTest + "\nRECORD_FORMAT=" + RecordFormatTest + "\nLRECL=" + LReclTest + "\nBLKSIZE=" + BlkSizeTest;
                else 
                    str = "Servidor: " + ServidorTest + "\nRuta: " + RutaTest + "\nArchivos: " + ArchivoTest;
            }
            else if (format.ToUpper() == "PROD") {
                if (OrigenArchivos == TipoOrigen.HOST)
                    str = "Servidor: " + ServidorProd + "\nArchivo: " + ArchivoProd + "\nFILE_OPTION=" + FileOptionProd + "\nRECORD_FORMAT=" + RecordFormatProd + "\nLRECL=" + LReclProd + "\nBLKSIZE=" + BlkSizeProd;
                else
                    str = "Servidor: " + ServidorProd + "\nRuta: " + RutaProd + "\nArchivos: " + ArchivoProd;
            }

            return str;
        }
    }
}
