namespace Frecuencia_Acidentes
{
    public class frecuencia
    {
        private string ciudad {get; set;}
        private int cantidad_accidente {get; set;}
        private int anio {get; set;}

        static int tf01=0, tf02=0, tf03=0, tf04=0,tf05=0,tf06=0;
        public frecuencia()
        {
            ciudad= "";
            cantidad_accidente = 0;
            anio = 0;

        }
        public void agregar_reporte(int anio_p,string ciudad_p, int cantidad_p)
        {
            ciudad= ciudad_p;
            cantidad_accidente = cantidad_p;
            anio = anio_p;

            switch(cantidad_accidente)
            {
                case >=0 and <=99:
                    frecuencia01.Add(ciudad+"\t"+cantidad_accidente+"\t"+anio);
                    tf01++;
                break;  
                case >=100 and <=199:
                    frecuencia02.Add(ciudad+"\t"+cantidad_accidente+"\t"+anio);
                    tf02++;
                break;  
                case >=200 and <=299:
                    frecuencia03.Add(ciudad+"\t"+cantidad_accidente+"\t"+anio);
                    tf03++;
                break;  
                case >=300 and <=399:
                    frecuencia04.Add(ciudad+"\t"+cantidad_accidente+"\t"+anio);
                    tf04++;
                break; 
                case >=400 and <=499:
                    frecuencia05.Add(ciudad+"\t"+cantidad_accidente+"\t"+anio);
                    tf05++;
                break; 
                case >=500:
                    frecuencia06.Add(ciudad+"\t"+cantidad_accidente+"\t"+anio);
                    tf06++;
                break; 
            }
        }


        public void imprimir_reportes()
        {
             Console.WriteLine("CIUDAD"+"\t"+"ACCIDENTES"+"\t"+"AÑO");
            foreach(var item in frecuencia01)
            {
                Console.WriteLine(item);
            }
            foreach(var item in frecuencia02)
            {
                Console.WriteLine(item);
            }
            foreach(var item in frecuencia03)
            {
                Console.WriteLine(item);
            }
            foreach(var item in frecuencia04)
            {
                Console.WriteLine(item);
            }
            foreach(var item in frecuencia05)
            {
                Console.WriteLine(item);
            }
            foreach(var item in frecuencia06)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================");
            Console.WriteLine("LA FRECUENCIA DE 0 -99 TIENE "+tf01 +" REGISTROS");
            Console.WriteLine("LA FRECUENCIA DE 100 -199 TIENE "+tf02 +" REGISTROS");
            Console.WriteLine("LA FRECUENCIA DE 200 -299 TIENE "+tf03 +" REGISTROS");
            Console.WriteLine("LA FRECUENCIA DE 300 -399 TIENE "+tf04 +" REGISTROS");
            Console.WriteLine("LA FRECUENCIA DE 400 -499 TIENE "+tf05 +" REGISTROS");
            Console.WriteLine("LA FRECUENCIA DE 500 - MAS TIENE "+tf06 +" REGISTROS");
        }

        List<string> frecuencia01 = new List<string>(); //0 -99
        List<string> frecuencia02 = new List<string>(); // 100-199
        List<string> frecuencia03 = new List<string>();//200-299
        List<string> frecuencia04 = new List<string>();//300-399
        List<string> frecuencia05 = new List<string>();//400-499
        List<string> frecuencia06 = new List<string>();//500 - mas


    }
}