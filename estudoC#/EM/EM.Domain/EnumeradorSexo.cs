using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    //public class EnumeradorSexo
    //{
    //    public EnumeradorSexo(int indice, string descricao)
    //    {
    //        Indice = indice;
    //        Descricao = descricao;
    //    }

    //    public object Indice { get; private set; }
    //    public object Descricao { get; private set; }

    //    public int Masculino { get; private set; } = 0;
    //    public int Feminino { get; private set; } = 1;

    //    EnumeradorSexo Masculino 


    //}
    public class EnumeradorSexo : EnumAttr
    {
        public EnumeradorSexo(int indice, string descricao)
        {
            Indice = indice;
            Descricao = descricao;
        }

        public object Indice { get; private set; }
        public object Descricao { get; private set; }

        public static EnumeradorSexo Masculino = new(0, "Masculino");

        public static EnumeradorSexo Feminino = new(1, "Feminino");

        public override string ToString()
        {
            return base.ToString();
        }

        public enum Sexo
        {
            [EnumeradorSexo(0, "Masculino")]
            Masculino,
            [EnumeradorSexo(1, "Feminino")]
            Feminino
        }

    }

    



}
