namespace triki
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[,] tablero = new string[3, 3];
            Console.Clear();
            string player, player1, player2;

            // Caracter jugadores:
            // player1 = "❌";
            // player2 = "⭕";
            player1 = "X";
            player2 = "O";
            player = player1;

            string[,] tablero = new string[3, 13] { { "|", " ", "-", " ", "|", " ", "-", " ", "|", " ", "-", " ", "|" }, { "|", " ", "-", " ", "|", " ", "-", " ", "|", " ", "-", " ", "|" }, { "|", " ", "-", " ", "|", " ", "-", " ", "|", " ", "-", " ", "|" } };
            int turnos = 0;

            // Coords de las casillas
            int[,] position = new int[10, 2];
            position[1, 1] = 2; position[1, 0] = 0;
            position[2, 1] = 6; position[2, 0] = 0;
            position[3, 1] = 10; position[3, 0] = 0;
            position[4, 1] = 2; position[4, 0] = 1;
            position[5, 1] = 6; position[5, 0] = 1;
            position[6, 1] = 10; position[6, 0] = 1;
            position[7, 1] = 2; position[7, 0] = 2;
            position[8, 1] = 6; position[8, 0] = 2;
            position[9, 1] = 10; position[9, 0] = 2;

            bool winner = false;
            // while ((turnos < 9) && (winner = false))
            while ((turnos < 9))
            {
                System.Console.WriteLine("\n\t\tJueguito de triki fachero 🎮\n");
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    System.Console.Write("\t\t");
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        System.Console.Write(tablero[i, j]);
                    }
                    System.Console.WriteLine();
                }

                // ---------- Ganador
                // Verificar filas
                for (int i = 1; i <= 7; i += 3)
                {
                    if ((tablero[position[i, 0], position[i, 1]] == tablero[position[i + 1, 0], position[i + 1, 1]]) && (tablero[position[i, 0], position[i, 1]] == tablero[position[i + 2, 0], position[i + 2, 1]]) && (tablero[position[i, 0], position[i, 1]] != "-"))
                    {
                        System.Console.WriteLine("Ganó horizontal");
                        winner = true;
                    }
                }
                // Verificar columnas
                for (int i = 1; i <= 3; i++)
                {
                    if ((tablero[position[i, 0], position[i, 1]] == tablero[position[i + 3, 0], position[i + 3, 1]]) && (tablero[position[i, 0], position[i, 1]] == tablero[position[i + 6, 0], position[i + 6, 1]]) && (tablero[position[i, 0], position[i, 1]] != "-"))
                    {
                        System.Console.WriteLine("Ganó vertical");
                        winner = true;
                    }
                }
                // Verificar diagonales

                // Cambio de jugador 
                if (player == player1)
                {
                    player = player2;
                }
                else
                {
                    player = player1;
                }
                // Verificar si el mov. es válido
                while (true)
                {
                    System.Console.Write("\nTurno jugador " + player + " (ingrese una casilla 1-9): ");
                    int pos;
                    pos = Convert.ToInt16(Console.ReadLine());
                    if (tablero[position[pos, 0], position[pos, 1]] == "-")
                    {
                        System.Console.WriteLine("\nMovimiento permitido");
                        tablero[position[pos, 0], position[pos, 1]] = player;
                        turnos++;
                        break;
                    }
                    // En caso de no ser válido el movimiento
                    else
                    {
                        System.Console.WriteLine("\nMovimiento invalido, el jugador " + tablero[position[pos, 0], position[pos, 1]] + " ya utilizó la casilla");
                    }

                }
                Console.Clear();
            }

            // Resumen de la partida
            System.Console.WriteLine("\n\t\tJueguito de triki fachero 🎮\n");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                System.Console.Write("\t\t");
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    System.Console.Write(tablero[i, j]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nJuego terminado, el ganador fue " + player);
            Console.ReadKey();
            // Console.Clear();

        }
    }
}
