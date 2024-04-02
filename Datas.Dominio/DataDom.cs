namespace Datas.Dominio
{
    public class DataConfiguracao
    {
        public int formatoData, dataTecnologia;
        /*
         * FormatosData => 1) Padrao Sistema; 2) Simples; 3) Longo; 4) Longo Personalizado; 5) RFC1123 pattern
         * DataTecnologia => 1) ENIAC; 2) RFC1; 3) Alan Turing 
        */
        private List<DateTime> ListaDatasTecnologia()
        {
            List<DateTime> list = new List<DateTime>()
           {
                new DateTime(1946, 8, 15),
                new DateTime(1969, 4, 17),
                new DateTime(1912, 6, 23)
           };
           return list;
        }


        public void ConfigurarFormato()
        {

            DateTime dataAgora = DateTime.Now;
            Boolean aux = true;

            while (aux)
            {
                Console.WriteLine("Selecione o formato de data a ser usado:");
                Console.WriteLine($"1- Utilizar minha configuração de sistema: {dataAgora.ToString()}");
                Console.WriteLine($"2- Formato simples: {string.Format("{0:dd-MM-yy}", dataAgora)}");
                Console.WriteLine($"3- Formato longo {dataAgora.ToLongDateString()}");
                Console.WriteLine($"4- Formato longo personalizado {string.Format("{0:dd-MM-yyyy hh:mm:ss}", dataAgora)}");
                Console.WriteLine($"5- Formato RFC1123 pattern {string.Format("{0:r}", dataAgora)}");

                formatoData = int.Parse(Console.ReadLine());

                if (formatoData > 5 || formatoData < 1)
                {
                    Console.WriteLine("Erro: Formato deve ser um valor de 1 a 5 como especificado.");
                    Console.WriteLine();
                }
                else
                {
                    aux = false;
                }
            }
            Console.WriteLine();
        }

        public void EscolherDataTecnologia()
        {
            Boolean aux = true;

            while (aux)
            {
                Console.WriteLine("Selecione a data a ser usada:");
                Console.WriteLine("1- ENIAC");
                Console.WriteLine("2- RFC1");
                Console.WriteLine("3- Alan Turing");

                dataTecnologia = int.Parse(Console.ReadLine());

                if (dataTecnologia > 3 || dataTecnologia < 1)
                {
                    Console.WriteLine("Erro: A data deve ser um valor de 1 a 3 como especificado.");
                    Console.WriteLine();
                }
                else
                {
                    aux = false;
                }
            }
            Console.WriteLine();
        }

        public void ImprimirDataFinal()
        {
            List<DateTime> datas = ListaDatasTecnologia();

            // Definicao da Data
            switch (dataTecnologia)
            {
                case 1: // ENIAC
                    switch (formatoData)
                    {
                        case 1: // Padrao Sistema
                            Console.WriteLine($"(ENIAC) - {datas[1].ToString()} No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                            break;
                        case 2: // Simples
                            Console.WriteLine($"(ENIAC) - {string.Format("{0:dd-MM-yy}", datas[1])} No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                            break;
                        case 3: // Longo 
                            Console.WriteLine($"(ENIAC) - {datas[1].ToLongDateString()} No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                            break;
                        case 4: // Longo Personalizado
                            Console.WriteLine($"(ENIAC) - {string.Format("{0:dd-MM-yyyy hh:mm:ss}", datas[1])} No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                            break;
                        case 5: // Padrao RFC1123
                            Console.WriteLine($"(ENIAC) - {string.Format("{0:r}", datas[1])} No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2: // RFC1
                    switch (formatoData)
                    {
                        case 1: // Padrao Sistema
                            Console.WriteLine($"(RFC1) - {datas[2].ToString()} Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                            break;
                        case 2: // Simples
                            Console.WriteLine($"(RFC1) - {string.Format("{0:dd-MM-yy}", datas[2])} Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                            break;
                        case 3: // Longo 
                            Console.WriteLine($"(RFC1) - {datas[2].ToLongDateString()} Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                            break;
                        case 4: // Longo Personalizado
                            Console.WriteLine($"(RFC1) - {string.Format("{0:dd-MM-yyyy hh:mm:ss}", datas[2])} Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                            break;
                        case 5: // Padrao RFC1123
                            Console.WriteLine($"(RFC1) - {string.Format("{0:r}", datas[2])} Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                            break;
                        default:
                            break;
                    }
                    break;
                case 3: //Alan Turing
                    switch (formatoData)
                    {
                        case 1: // Padrao Sistema
                            Console.WriteLine($"(Alan Turing) - {datas[3].ToString()} Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                            break;
                        case 2: // Simples
                            Console.WriteLine($"(Alan Turing) - {string.Format("{0:dd-MM-yy}", datas[3])} Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                            break;
                        case 3: // Longo 
                            Console.WriteLine($"(Alan Turing) - {datas[3].ToLongDateString()} Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                            break;
                        case 4: // Longo Personalizado
                            Console.WriteLine($"(Alan Turing) - {string.Format("{0:dd-MM-yyyy hh:mm:ss}", datas[3])} Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                            break;
                        case 5: // Padrao RFC1123
                            Console.WriteLine($"(Alan Turing) - {string.Format("{0:r}", datas[3])} Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
