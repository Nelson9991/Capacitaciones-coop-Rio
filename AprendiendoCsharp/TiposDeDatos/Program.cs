namespace TiposDeDatos;

internal class Program
{
  static void Main(string[] args)
  {
    #region Tipos de datos Enteros
    //// Tipos numericos Enteros.
    //// sbyte. Ocupa 8 bits en memoria. Le podemos almacenar valores de -128 a 127.
    //sbyte minSbyte = sbyte.MinValue;
    //sbyte maxSbyte = sbyte.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato sbyte es: {0}", minSbyte);
    //Console.WriteLine("El valor maximo del tipo de dato sbyte es: {0}", maxSbyte);

    //// byte. Ocupa 8 bits en memoria. Almacena desde 0 a 255 
    //byte minByte = byte.MinValue;
    //byte maxByte = byte.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato byte es: {0}", minByte);
    //Console.WriteLine("El valor maximo del tipo de dato byte es: {0}", maxByte);

    //// short. Ocupa 16 bits en memoria. Alamacena desde -32 768 a 32 767
    //short minShort = short.MinValue;
    //short maxShort = short.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato short es: {0}", minShort);
    //Console.WriteLine("El valor maximo del tipo de dato short es: {0}", maxShort);

    //// int. Ocupa 32 bits en memoria. Alamacena
    //int minInt = int.MinValue;
    //int maxInt = int.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato int es: {0}", minInt);
    //Console.WriteLine("El valor maximo del tipo de dato int es: {0}", maxInt);

    //// long. Ocupa 64 bits en memoria. Almacena
    //long minLong = long.MinValue;
    //long maxLong = long.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato long es: {0}", minLong);
    //Console.WriteLine("El valor maximo del tipo de dato long es: {0}", maxLong);
    #endregion

    #region Tipos de datos Flotantes
    //// 1 byte = 8 bits.
    //// float. Ocupa 4 bytes = 32 bits. Precision 6 a 9 despues de la coma decimal.
    //// Inicializacion de un foltante. float nombre_variable = x.xF
    //float miFloat = 0.0F;
    //Console.WriteLine(miFloat);

    //float minFloat = float.MinValue;
    //float maxFloat = float.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato float es: {0:f}", minFloat);
    //Console.WriteLine("El valor maximo del tipo de dato float es: {0:f}", maxFloat);

    //// double. Ocupa 8 bytes = 64 bits. Precision de 15 a 17 digis aproximamente.
    //double miDouble = 13.75;
    //Console.WriteLine(miDouble);

    //double minDouble = double.MinValue;
    //double maxDouble = double.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato double es: {0:f}", minDouble);
    //Console.WriteLine("El valor maximo del tipo de dato double es: {0:f}", maxDouble);

    //// \n -> significa un salto de linea en la consola.
    //Console.WriteLine("\n");

    //// el tipo de dato decimal es el mas preciso para las comparaciones.
    //// decimal. 16 bytes = 128 bits. Precision de 28-29 digitos aprox.
    //decimal miDecimal = 1000.45M;
    //Console.WriteLine(miDecimal);

    //decimal minDecimal = decimal.MinValue;
    //decimal maxDecimal = decimal.MaxValue;

    //Console.WriteLine("El valor minimo del tipo de dato decimal es: {0:f}", minDecimal);
    //Console.WriteLine("El valor maximo del tipo de dato decimal es: {0:f}", maxDecimal);
    #endregion

    #region Tipos de datos Alfanumericos.
    // Tenemos dos tipos de datos alfanumericos. char, string.
    // el tipo de dato char es un caracter Unicode (Unicode -> codificacion de los caracteres)
    // el tipo de dato string hace referencia a una cadena de caracteres

    // char. Declaracion
    //char caracter = 'A';
    //string oracion = "Estoy aprendiendo C#";

    //Console.WriteLine(caracter);
    //Console.WriteLine(oracion);
    #endregion

    #region Tipos de datos booleanos
    // El tipo de dato booleaon es el: bool. Se utiliza para realizar operacion logicas.
    bool condicionFalsa = false;
    bool condicionVerdadera = true;

    bool esNumeroMayor = (5 < 10);

    //Console.WriteLine(condicionFalsa);
    //Console.WriteLine(condicionVerdadera);
    Console.WriteLine(esNumeroMayor);
    #endregion
  }
}
