using GameTOP.Interface;
namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Test pateando \n";
        }

        public string Corre()
        {
            return "Test corriendo \n";
        }

        public string Passa()
        {
            return "Test pasando \n";
        }
    }
}