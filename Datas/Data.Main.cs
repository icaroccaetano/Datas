using Datas.Dominio;


namespace Program
{
    public class DatasMain
    {
        public static void Main(string[] args)
        {
            DataConfiguracao data = new();

            data.ConfigurarFormato();
            data.EscolherDataTecnologia();
            data.ImprimirDataFinal();


        }
    }
}