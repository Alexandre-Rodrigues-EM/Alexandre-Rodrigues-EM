using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EM.Domain
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class EnumAttr : Attribute
    {
        public EnumAttr()
        {
        }
    }
    //public enum EnumeradorSexo
    //{
    //    Masculino = 0,
    //    Feminino = 1
    //}

    public class EnumeradorSexo
    {
        public EnumeradorSexo(int indice, string descricao)
        {
            Indice = indice;
            Descricao = descricao;
        }

        public object Indice { get; private set; }
        public object Descricao { get; private set; }

        public int Masculino { get; private set; } = 0;
        public int Feminino { get; private set; } = 1;

        public enum Sexo
        {
            Masculino = 0,
            Feminino = 1
        }

    }

    //public class EnumeradorSexo
    //{
    //    public int Masculino = 0;
    //    public int Feminino = 1;

    //    public enum Sexo
    //    {
    //        Masculino = 0,
    //        Feminino = 1
    //    }

    //    public static int ConversorStringInt(string sexo)
    //    {
    //        if (sexo == "Masculino")
    //            return 0;
    //        else if (sexo == "Feminino")
    //            return 1;

    //    }
    //}





}
