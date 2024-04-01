namespace Datas.Dominio
{
    public class DataConfiguracao
    {
        int formatoData;
        public void ConfigurarFormato ()
        {
            DateTime dataagora = DateTime.Now;
            
            Console.WriteLine("Selecione o formato de data a ser usado:");
            Console.WriteLine("   1 - Formato padrao do sistema: " + dataagora.ToString());
            Console.WriteLine("   2 - Formato simples: " + string.Format("");
            Console.WriteLine("   3 - Formato padrao do sistema: " + dataagora.ToString());
            Console.WriteLine("   4 - Formato padrao do sistema: " + dataagora.ToString());
            Console.WriteLine("   5 - Formato padrao do sistema: " + dataagora.ToString());




        }
    }
}
