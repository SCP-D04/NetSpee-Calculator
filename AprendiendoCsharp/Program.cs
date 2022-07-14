using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CREADO POR SCP-D04";
            Console.WriteLine("#######   ######   ######            ######  #######  ##   ##");
            Console.WriteLine("#     #   #    #   #    #            #    #  #######  ##   ##");
            Console.WriteLine("#         #        #    #            #    #  ##   ##  ##   ##");
            Console.WriteLine("#######  ##       #######  #######  ##    #  ##   ##  # #####");
            Console.WriteLine("#    ##  ##       ##                ##    #  ##   ##       ##");
            Console.WriteLine("#    ##  ##    #  ##                ##    #  #######       ##");
            Console.WriteLine("#######  #######  ##                #######  #######       ##");
            Thread.Sleep(1500);
            Console.Title = "Calculadora de tiempo de subida/carga.";
            Console.Clear();

            Console.WriteLine("Por favor la unidad del peso. Ej.: Mb,MB,MiB...");
            string opcionPeso = "xd";
            string opcionVelo = "xd";
            ulong fM = 0;
            ulong fD = 0;
            ulong pesoArchivo = 0;
            ulong velocidadDescarga = 0;

            while (fM == 0)
            {
                opcionPeso = Console.ReadLine();
                switch (opcionPeso)
                {
                    // Unidades Kilo
                    case "Kb":
                        fM = 1000;
                        break;
                    case "KB":
                        fM = 8000;
                        break;
                    case "KiB":
                        fM = 8192;
                        break;
                    // Unidades Mega
                    case "Mb":
                        fM = 1000000;
                        break;
                    case "MB":
                        fM = 8000000;
                        break;
                    case "MiB":
                        fM = 8388608;
                        break;
                    // Unidades Giga
                    case "Gb":
                        fM = 1000000000;
                        break;
                    case "GB":
                        fM = 8000000000;
                        break;
                    case "GiB":
                        fM = 8589934592;
                        break;
                    // Unidades Tera
                    case "Tb":
                        fM = 1000000000000;
                        break;
                    case "TB":
                        fM = 8000000000000;
                        break;
                    case "TiB":
                        fM = 8796093022208;
                        break;
                    default:
                        Console.WriteLine("No ha escrito una opcion correcta.");
                        break;
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Por favor digite la cantidad de {opcionPeso}.");
            pesoArchivo = ulong.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ahora digite la unidad de su subida/bajada en segundos. Ej.: Mb,MB,MiB");
            while (fD == 0)
            {
                opcionVelo = Console.ReadLine();
                switch (opcionVelo)
                {
                    // Unidades Kilo
                    case "Kb":
                        fD = 1000;
                        break;
                    case "KB":
                        fD = 8000;
                        break;
                    case "KiB":
                        fM = 8192;
                        break;
                    // Unidades Mega
                    case "Mb":
                        fD = 1000000;
                        break;
                    case "MB":
                        fD = 8000000;
                        break;
                    case "MiB":
                        fD = 8388608;
                        break;
                    // Unidades Giga
                    case "Gb":
                        fD = 1000000000;
                        break;
                    case "GB":
                        fD = 8000000000;
                        break;
                    case "GiB":
                        fD = 8589934592;
                        break;
                    // Unidades Tera
                    case "Tb":
                        fD = 1000000000000;
                        break;
                    case "TB":
                        fD = 8000000000000;
                        break;
                    case "TiB":
                        fD = 8796093022208;
                        break;
                    default:
                        Console.WriteLine("No ha escrito una opcion correcta.");
                        break;
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Ahora digite la cantidad de {opcionVelo}/s.");
            velocidadDescarga = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Espere...");
            Thread.Sleep(3000);
            ulong tiempo = (pesoArchivo * fM) / (velocidadDescarga * fD);
            ulong minutosH = tiempo / 60;
            ulong segundos = tiempo % 60;
            ulong horas = minutosH / 60;
            ulong minutos = minutosH % 60;
            Console.Clear();
            Console.WriteLine($"Su fichero de {pesoArchivo}{opcionPeso} tardara {horas} horas, {minutos} minutos y {segundos} segundos.");

        }
        //Unidades utilizadas:
        //    Peso
        //        Kilo -> Kilobit, KiloByte, KibiByte
        //        Mega -> Megabit, MegaByte, MebiByte
        //        Giga -> Gigabit, GigaByte, GibiByte
        //        Tera -> Terabit, TeraByte, TebiByte
        //    Descarga
        //        Kilo/s -> Kilobit/s, KiloByte/s, KibiByte/s
        //        Mega/s -> Megabit/s, MegaByte/s, MebiByte/s
        //        Giga/s -> Gigabit/s, GigaByte/s, GibiByte/s
        //        Tera/s -> Terabit/s, TeraByte/s, TebiByte/s

        //Equivalencias en bits:
        //    Kilobit = 1000
        //    KiloByte = 8000
        //    KibiByte = 8192

        //    Megabit = 1000000
        //    MegaByte = 8000000
        //    MebiByte = 8388608

        //    Gigabit = 1000000000
        //    GigaByte = 8000000000
        //    GibiByte = 8589934592

        //    Terabit = 1000000000000
        //    TeraByte = 8000000000000
        //    TebiByte = 8796093022208
    }
}