using System;
using System.Collections.Generic;
using System.Linq;

namespace actividad_letras_repetidas
{
    class Program
    {
        private const char V = 'U';

        static void Main(string[] args)
        {
            char[] letras = new char[] { 'J','E','F','F','E','R','S','O','N'};
          

            for (var i = 0; i <letras.Length; i++)
            {
                Console.WriteLine(letras[i]);
            }


            List<char> nameList = new List<char>();

            for (var i = 0; i < letras.Length;i++ )
            {
                nameList.Add(letras[i]);
            }

                foreach (var letra  in nameList)
            {
                if (letra == 'A' || letra == 'E' ||letra == 'I' || letra == 'O'|| letra == 'U')
                {
                    Console.WriteLine("Vocal");
                }

                else if (!nameList.Any(c => c < '0' || c > '9')) 
                {
                    Console.WriteLine("Nombres no contienen números!");
                }
            
                else
                {
                    Console.WriteLine("Consonante");
                }
            }



            Dictionary<char, int> mynameDictionary = new Dictionary<char, int>();

                foreach (var letra in nameList)
                {
                    if (mynameDictionary.ContainsKey(letra))
                    {

                      mynameDictionary[letra]++;
                   
                    }
                    else
                    {

                    mynameDictionary.Add(letra, 1);


                }
                }

            foreach (var letra in mynameDictionary)
            {
                Console.WriteLine(letra);
            }




            char[] letrasPrimerApellido = new char[] { 'O','T','T','O' };
            char[] letrasSegundoApellido = new char[] { 'G','O','N','S','A','L','V','E','S' };

            List<char> primerApellido = new List<char>();
            List<char> segundoApellido = new List<char>();

                for (var i = 0; i < letrasPrimerApellido.Length; i++)
                {
                    primerApellido.Add(letrasPrimerApellido[i]);
                }

                for (var i = 0; i < letrasSegundoApellido.Length; i++)
                {
                    segundoApellido.Add(letrasSegundoApellido[i]);
                }


            List<char> fullName = new List<char>();

            fullName.AddRange(nameList);
            fullName.Add(' ');
            fullName.AddRange(primerApellido);
            fullName.Add(' ');
            fullName.AddRange(segundoApellido);
            Console.WriteLine(fullName);

            foreach (var letra in fullName)
            {
                Console.Write(letra);
            }

        }
    }
}
