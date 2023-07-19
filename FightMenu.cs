class FightMenu
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;
    private bool EnterWasPressed;
    private string[] YesOrNo;
    private string[] SiONo;
    private string pokemonsAscii;

    public FightMenu(string[] options, string prompt)
    {
        Console.CursorVisible = false;

        Options = options;
        Prompt = prompt;
        SelectedIndex = 0;
        EnterWasPressed = false;
        YesOrNo = new string[] { "Yes", "No" };
        SiONo = new string[] { "Sí", "No" };
        pokemonsAscii = @"
                                                      
                                                       


                    MMMMM                           MMMMM                                                                                                  MM
                    MMMMMMM    MMMMMMMMMMMMMMM    MMMMMMM                                                                                                 MMMM      M              MMMM
                     MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                 MMM,,,MM   MMM            MM,,,,,,MMMM
                        MMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                    MMM,,,MM   MMM            MM,,,,,,MMMM
                          MMMMMMMMMMMMMMMMMMMMMMMM                                                                                                    MMM,,MMMMMMMMMMM            MMM,,,,,,,,,MMMM
     NNNNNNNNN            MMM   MMMMMMMMMMMMM   MMM                                                                                                  MM,,,MMMMMMMMMMMMM            MM,,,,,,,,,,,,,MMMM
      NNNNNNNNNNNNN      MMMM   MMMMMMMMMMMMM   MMMM                                                                                                 MM,,MMMMMMM  MMMMMM          MMM,,,,,,,,,,,,,,,,MMMM
       NNNNNNNNNNNNNNNN MMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                MM,,,,MMMMM  MMMMMMMMM       MMM,,,,,,,,,,,,,,,,,,,,MMM
        NNNNNNNNNNNNNNN MMM  MMMMMMMMMMMMMMMMMM  MMM                                                                                               MMM,,MMMMMMMMMMMMMMMMMMMM    MMM,,,,,,,,,,,,,,,,,,,,,,MMM
                 NNNNNN  MM  MMMMMM       MMMMM  MMM                                                                                               MM,,,MMMMMMMMMMMMMMMMMMMMMM  MM,,,,,,,,,,,,,,,,,,,,,,,,MMM
                 NNNNNN   MMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                 M,,,,,MMMMM     MMMMMMMMMMMMM,,,,,,,,,,,,,,,,,,,,,,,,,MM
                NNNNNN    MMMMMMMMMMMMMMMMMMMMMMMM                                                                                                  MM,,,          MMMMMMMMMMMMMMM,,,,    ,,MMMMM,,,    ,,MMM
               NNNNNN     MMMMMMMMMMMMMMMMMMMMMMMM                                                                                                   MM,          MMMMMMMMMMMM MMMMM        MMMMMM        ,MM
              NNNNNN     MMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                    M         MMMMMMMMMMMMMM MMMMMM      MMMMMMM         M
             NNNNNNN    MMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                          MMMMMMMMMMMMMMMMMM MMMM MM   MMMMMMMM
              NNNNNNNNNNMM MMMMM MMMMMMMMMMM MMMMM MM                                                                                                       MMMMMMMMMMMMMMMMMMMMM MMMM MMMMMMMMMMMM
                  NNNNNNMMM MMM MMMMMMMMMMMMM MMM MMM                                                                                                     MMMMMM  MMMMMMMMMMMMMM MMMM MMMMMMMMMMMM
                    NNNNMMM MMM MMMMMMMMMMMMM MMM MMM                                                                                                     MMMM   MMMMMMMMMMMMMM MMMMM MMMMMMMMMMM
                       MMMMM M MMMMMMMMMMMMMMM M MMMM                                                                                                     MM   MMMMMMMMMMMMMMMMM M M MMMMMMMMM
                       MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                         MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
                        MMMMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                         MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
                         MMMMMMMMMMMMMMMMMMMMMMMMMM                                                                                                          MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
                           MMMMMMMMMMMMMMMMMMMMMMM                                                                                                           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
                           MMMMMMMMMMMMMMMMMMMMMM                                                                                                             MMMMMMMMM            MMMMMMM
                         MMMMMM               MMMMM                                                                                                         MMMMMMMMMMMM           MMMMMMMMM
                                                               




        ";

    }

    private void DisplayOptions(string playerOnePokemon)
    {
        Console.Clear();
        ConsoleColor foregroundColor = ConsoleColor.White;
        ConsoleColor optionForegroundColor = ConsoleColor.Green;
        Console.ForegroundColor = foregroundColor;
        Console.Write(pokemonsAscii);
        Console.ResetColor();
        Console.WriteLine(@$"                                               
                                                                                                {Prompt}, {playerOnePokemon.ToUpper()}
            
            
            ");

        string spaces = @"                                                                                   ";
        Console.Write(spaces);

        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;

            if (i == SelectedIndex)
            {
                prefix = "» ";

                ConsoleColor backgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = optionForegroundColor;
                // Console.BackgroundColor = backgroundColor;

            }
            else
            {
                prefix = "  ";
                Console.ResetColor();
            }

            Console.Write($"{prefix} {currentOption.ToUpper()}   ");
        }
        Console.ResetColor();
    }

    public void HandleKeyboard(ConsoleKeyInfo key)
    {
        EnterWasPressed = false;
        switch (key.Key)
        {
            case ConsoleKey.DownArrow:
                if (SelectedIndex == Options.Length - 1)
                {
                    break;
                }
                else
                {
                    SelectedIndex++;
                    break;
                }

            case ConsoleKey.RightArrow:
                if (SelectedIndex == Options.Length - 1)
                {
                    break;
                }
                else
                {
                    SelectedIndex++;
                    break;
                }

            case ConsoleKey.UpArrow:
                if (SelectedIndex == 0)
                {
                    break;
                }
                else
                {
                    SelectedIndex--;
                    break;
                }

            case ConsoleKey.LeftArrow:
                if (SelectedIndex == 0)
                {
                    break;
                }
                else
                {
                    SelectedIndex--;
                    break;
                }

            case ConsoleKey.Enter:
                EnterWasPressed = true;
                break;
        }
    }

    public int Run(string playerOnePokemon, string playerTwoPokemon, bool playerOne)
    {
        ConsoleKeyInfo pressedKey;

        while (true)
        {

            if (playerOne)
            {
                DisplayOptions(playerOnePokemon);
            }
            else
            {
                DisplayOptions(playerTwoPokemon);
            }

            pressedKey = Console.ReadKey();

            HandleKeyboard(pressedKey);

            if (EnterWasPressed)
            {
                return SelectedIndex;
            }

        }

    }




    private void ResetVariables()
    {
        EnterWasPressed = false;
        SelectedIndex = 0;
    }

}
