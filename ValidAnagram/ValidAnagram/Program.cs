    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ValidAnagram
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                ValidAnagram();
            }

            static bool ValidAnagram()
            {
                string primeiroInput = "samurai";
                string segundoInput = "usariam";
            string obterLetraPrimeiroInput = "";

                if (primeiroInput.Length != segundoInput.Length) return false;
            
                for (int i = 0; i < primeiroInput.Length; i++)
                {
                    for (int j = 0; j < segundoInput.Length; j++)
                    {
                        if (primeiroInput[i] == segundoInput[j])
                        {
                        obterLetraPrimeiroInput += Convert.ToString(primeiroInput[i]);
                            if (obterLetraPrimeiroInput.Length == primeiroInput.Length) return true;
                            else  break;
                        }
                    }
                }
                return false;
            }
        }
    }
