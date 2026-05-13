namespace Ahorcado
{
    public class ConsolaUIViborita
    {
        private readonly MotorViborita _motor;

        public ConsolaUIViborita(MotorViborita motor)
        {
            _motor = motor;
        }

        public void MostrarTablero()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"=== VIBORITA === Puntos: {_motor.Puntos}");
            Console.WriteLine("Jugador: Heidi Esther Peña Betanzos");
            Console.WriteLine("3B");
            Console.WriteLine("=======================================");
            Console.WriteLine("+" + new string('-', _motor.Ancho) + "+");

            for (int y = 0; y < _motor.Alto; y++)
            {
                Console.Write("|");
                for (int x = 0; x < _motor.Ancho; x++)
                {
                    var pos = (x, y);

                    // Lógica de dibujo corregida
                    if (_motor.Cuerpo.First() == pos)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;// cabeza
                        Console.Write("<");
                        Console.ResetColor(); 
                    }
                    else if (_motor.Cuerpo.Contains(pos))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan; // cuerpo
                        Console.Write("=");
                        Console.ResetColor();
                    }
                    else if (_motor.Comida == pos)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // comida
                        Console.Write("°");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" "); // vacío
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("|");
            }

            Console.WriteLine("+" + new string('-', _motor.Ancho) + "+");
            Console.WriteLine("Flechas: mover | Q: salir");
        }

        public ConsoleKey LeerTecla()
        {
            if (Console.KeyAvailable)
                return Console.ReadKey(intercept: true).Key;

            return ConsoleKey.NoName;
        }

        public void MostrarMensaje(string mensaje) =>
        Console.WriteLine(mensaje);
    }
}