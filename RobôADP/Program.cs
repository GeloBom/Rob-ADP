namespace RobôADP
{
    internal class Program
    {
        //Variaveis declaradas fora do escopo main = fields

        static int posX = 1; //coordenada que futuramente pode ser fornecida pelo usuario.
        static int posY = 2; //coordenada que futuramente pode ser fornecida pelo usuario.
        static char direcao = '1'; //coordenada fixa, sempre olhando para norte

        static void Main(string[] args)
        {
            string comando = "MMDMMDMDDM";

            char[] charArray = comando.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'D')
                    VirarDireita();

                if (charArray[i] == 'E')
                    VirarEsquerda();

                if (charArray[i] == 'M')
                    Mover();

            }


            Console.WriteLine(posX + " " + posY + " " + direcao);
            Console.ReadLine();

        }
        static private void VirarDireita()
        {
            if (direcao == 'n')
                direcao = 'l';

            else if (direcao == 'l')
                direcao = 's';

            else if (direcao == 's')
                direcao = 'o';

            else if (direcao == 'o')
                direcao = 'n';
        }

        static private void VirarEsquerda()
        {
            if (direcao == 'n')
                direcao = 'o';

            else if (direcao == 'o')
                direcao = 's';

            else if (direcao == 's')
                direcao = 'l';

            else if (direcao == 'l')
                direcao = 'n';
        }

        static private void Mover()
        {
            if (direcao == 'n')
                posY++;

            else if (direcao == 's')
                posY--;

            else if (direcao == 'l')
                posX++;

            else if (direcao == 'o')
                posX--;
        }

    }
}
