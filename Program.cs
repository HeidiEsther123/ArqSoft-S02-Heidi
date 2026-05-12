using System;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositorio = new PalabrasEnMemoria();
            var motor = new MotorAhorcado(repositorio);
            var ui = new ConsolaUI(motor);

            Console.WriteLine("=== AHORCADO ===");

            while (!motor.Ganado() && !motor.Perdido())
            {
                ui.MostrarTablero();
                char letra = ui.PedirLetra();

                if (motor.LetraYaUsada(letra))
                {
                    ui.MostrarMensaje("Ya usaste esa letra.");
                    continue;
                }

                motor.RegistrarLetra(letra);
            }

            ui.MostrarTablero();

            if (motor.Ganado())
                ui.MostrarMensaje($"\n¡Ganaste! La palabra era: {motor.PalabraSecreta}");
            else
                ui.MostrarMensaje($"\nPerdiste. La palabra era: {motor.PalabraSecreta}");

            if (ui.PreguntarOtraVez())
            {
                var nuevoMotor = new MotorAhorcado(repositorio);
                var nuevaUI = new ConsolaUI(nuevoMotor);
                nuevaUI.MostrarTablero();
            }
        }
    }
}
